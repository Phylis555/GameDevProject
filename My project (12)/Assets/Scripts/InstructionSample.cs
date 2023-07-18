using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class InstructionSample : MonoBehaviour
{
    public Text instrucDiamondTxt;
    void Start()
    {
        // instrucDiamondTxt.gameObject.SetActive(false);
        ShowTextCoroutine();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator ShowTextCoroutine()
    {
        // Show the text
        instrucDiamondTxt.enabled =true;

        // Wait for 5 seconds
        yield return new WaitForSeconds(5f);

        // Hide the text after 5 seconds
        instrucDiamondTxt.enabled =false;
    }
}
