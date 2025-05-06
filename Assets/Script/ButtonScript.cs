using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public ButtonOnClick targetButton;

    public void DisableButton()
    {
        targetButton.interactable = false; 
    }

    public void OnButtonClick()
    {
        Debug.Log("Tombol diklik!");
    }
}

public class ButtonOnClick
{
    internal bool interactable;
}