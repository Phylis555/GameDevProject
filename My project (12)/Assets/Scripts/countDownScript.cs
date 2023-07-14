using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class countDownScript : MonoBehaviour
{

    public int currentTime;
    public Text countdownText;
    void Start()
    {
        StartCoroutine(countDownToReturn());
    }
    IEnumerator countDownToReturn()
    {
        while (currentTime > 0)
        {
            countdownText.text = currentTime.ToString();
            yield return new WaitForSeconds(1f);
            currentTime--;
        }
        SceneManager.LoadScene(0);

    }
}




