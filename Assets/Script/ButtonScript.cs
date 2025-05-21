using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public int pindahScene = 1;

    public void ChangeScene()
    {
        SceneManager.LoadScene(pindahScene);
    }
    void Update()
    {
        
    }
}
