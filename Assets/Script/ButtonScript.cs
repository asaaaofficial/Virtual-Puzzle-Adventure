using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.InputSystem.HID.HID;

public class ButtonScript : MonoBehaviour
{
    // Start is called before the first frame update

    public UnityEngine.UI.Button myButton;
    public UnityEngine.UI.Button confirmButton;
    void Start()
    {
        if (myButton != null)
        {
            myButton.onClick.AddListener(OnButtonClick);
        }
        else
        {
            Debug.LogWarning("Button belum di-assign di Inspector!");
        }

        if (confirmButton != null)
        {
            confirmButton.onClick.AddListener(EndPuzzle);
        }
        else
        {
            Debug.LogWarning("confirmButton belum di-assign di Inspector!");
        }
    }

    // Update is called once per frame

    void OnButtonClick()
    {
        Debug.Log("Tombol diklik!");
    }

    void EndPuzzle()
    {
        Debug.Log("Puzzle selesai! Tombol Confirm ditekan.");
    }
    void Update()
    {
        
    }
}
