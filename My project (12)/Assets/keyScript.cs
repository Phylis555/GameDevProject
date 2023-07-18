using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyScript : MonoBehaviour
{

   
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="key")
        {
            scoreScript.score += 10;
            scoreScript.keyColected = true;
            other.gameObject.SetActive(false);
        }
    

    }
}
