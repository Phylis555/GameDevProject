using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class cabinToMazeButten : MonoBehaviour
{
    public Text cannonText;
    public Button mazeButten;

    // Start is called before the first frame update
    void Start()
    {
        if (scoreScript.inMaze == false)
        {
            cannonText.enabled = false;
            mazeButten.enabled = true;
            
        }
        else
        {
            mazeButten.gameObject.SetActive(false);
            cannonText.enabled = true;
        }

    }

    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void mButten()
    {
        
        scoreScript.inMaze = true;
        SceneManager.LoadScene(6);
    }
}
