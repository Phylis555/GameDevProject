using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keyScript : MonoBehaviour
{
    public Text keyInstctionText;
    public Text keyCollectText;
    public Text cabinText;

    private void Start()
    {
        keyInstctionText.enabled = true;
        keyCollectText.enabled = false;
        cabinText.enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="key")
        {
            cabinText.enabled = false;
            keyInstctionText.enabled = false;
            keyCollectText.enabled = true;
            scoreScript.score += 10;
            scoreScript.keyColected = true;
            other.gameObject.SetActive(false);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        keyCollectText.enabled = false;
        cabinText.enabled = true;
    }

}
