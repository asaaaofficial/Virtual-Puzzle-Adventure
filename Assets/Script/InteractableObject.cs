using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public bool playerInRange;
    public string itemName;
    private SelectionManager selectionManager;

    // Corrected the type of SelectionManager to match its intended usage
    public SelectionManager GetSelectionManager()
    {
        return selectionManager;
    }

    public string GetItemName()
    {
        return itemName;
    }

    public string getItemName()
    {
        return itemName;
    }
    void Update()
    {
        // Fixed the condition to properly check SelectionManager.Instance
        if (Input.GetKeyDown(KeyCode.Mouse0) && playerInRange && SelectionManager.Instance.onTarget)
        {
            if (!InventorySystem.Instance.CheckIfFull)
            {
                InventorySystem.Instance.AddItemToInventory(itemName);
                Destroy(gameObject);
            }
            else
            {
                Debug.Log("Inventory is full");
            }
        }
    }
}