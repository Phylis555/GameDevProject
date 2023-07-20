using UnityEngine;
using UnityEngine.UI;// we need this namespace in order to access UI elements within our script
using System.Collections;
using UnityEngine.SceneManagement;
public class menuScript : MonoBehaviour
{ //Belong To Main menu
    public Canvas quitMenu;
    public Button startText;
    public Button exitText;
    void Start()
    {
        scoreScript.harts = 3;
        scoreScript.keyColected = false;
        scoreScript.score = 0;
        scoreScript.inMaze = false;
        //  quitMenu = quitMenu.GetComponent<Canvas>();
        //  startText = startText.GetComponent<Button>();
        //  exitText = exitText.GetComponent<Button>();
        quitMenu.enabled = false;
    }
    public void ExitPress()
    {
        quitMenu.enabled = true; //enable the Quit menu when we click the Exit button
        startText.enabled = false; //then disable the Play and Exit buttons so they cannot be clicked
        exitText.enabled = false;
    }
    public void NoPress()
    {//this function will be used for our "NO" button in our Quit Menu
        quitMenu.enabled = false; //we'll disable the quit menu, meaning it won't be visible anymore
        startText.enabled = true; //enable the Play and Exit buttons again so they can be clicked
        exitText.enabled = true;
    }
    public void StartLevel()
    { //this function will be used on our Play button
        SceneManager.LoadScene(1);       //          Application.LoadLevel(1);  "1" is the second scene in our game
    }
    public void ExitGame()
    { // "Yes" button in our Quit menu
        Application.Quit();
    }
    private void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

}