using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectionManager : MonoBehaviour
{
    Text interaction_text;
    public static SelectionManager Instance { get; private set; }

    public bool onTarget; 

    private void Awake()
    {
        onTarget = false; 
    }

    void Update()
    {
        // Update onTarget based on your game logic
        // For example, you might want to set it to true when the player is looking at an interactable object
        // and false otherwise.

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var selectionTransform = hit.transform;
            InteractableObject interactable = selectionTransform.GetComponent<InteractableObject>();

            if (interactable && interactable.playerInRange)
            {
                onTarget = true; // Player is looking at an interactable object
            }
            else
            {
                onTarget = false; // Player is not looking at an interactable object
            }
        }
        else
        {
            onTarget = false; // No hit detected
        }
    }
}