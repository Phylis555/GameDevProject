using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keyScript : MonoBehaviour
{
    
    public Text keyCollectText;
    public Text cabinText;
    public Text gardText;

    private void Start()
    {
        keyCollectText.enabled = false;
        cabinText.enabled = false;
        StartCoroutine(showgardTxt());

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="key")
        {
            // keyCollectText.enabled = true;
            StartCoroutine(showKeyTxt());

            cabinText.enabled = true;
            scoreScript.score += 10;
            scoreScript.keyColected = true;
            other.gameObject.SetActive(false);
        }
      
    }
   

    private IEnumerator showKeyTxt()
    {
        keyCollectText.enabled = true;
        yield return new WaitForSeconds(5f);
        keyCollectText.enabled = false;
    }

    private IEnumerator showgardTxt()
    {
        gardText.enabled = true;
        yield return new WaitForSeconds(5f);
        gardText.enabled = false;
    }




}
