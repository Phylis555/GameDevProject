using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class WinMenuScript : MonoBehaviour
{
    public Button startText;
    public Button returnText;
    public Text numOfDimond;
   
    public void StartLevel()
    { //this function will be used on our Play button
        SceneManager.LoadScene(1);
    }
    public void MenuLevel()
    { //this function will be used on our Play button
        SceneManager.LoadScene(0);
    }

    private void Start()
    {
        numOfDimond.text = scoreScript.score.ToString();
       
    }
    private void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }


    //public void OnEnable()
    //{

    //}

    //public void OnDisable()
    //{
    //    Cursor.lockState = CursorLockMode.Locked;
    //    Cursor.visible = false;
    //}
}
