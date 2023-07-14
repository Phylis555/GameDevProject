using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinMenuScript : MonoBehaviour
{
    public void StartLevel()
    { //this function will be used on our Play button
        SceneManager.LoadScene(1);
    }
    public void MenuLevel()
    { //this function will be used on our Play button
        SceneManager.LoadScene(0);
    }

 


    public void OnEnable()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void OnDisable()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
