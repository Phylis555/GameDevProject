using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class enterdHuoseTrigger : MonoBehaviour
{
    public int enter = 1;
    public Text keyInstctionText;
    public Text topGtext;


    // Start is called before the first frame update
    void Start()
    {
        keyInstctionText.enabled = true;
        topGtext.enabled = false;

    }
    private void OnTriggerExit(Collider other)
    {

        topGtext.enabled = false;

    }
    private void OnTriggerEnter(Collider other)
    {
        keyInstctionText.enabled = false;
        if (enter==1)
            topGtext.enabled = true;
        enter++;
    }
}
