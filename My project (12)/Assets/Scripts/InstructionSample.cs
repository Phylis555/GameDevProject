using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class InstructionSample : MonoBehaviour
{
    public Text instrucDiamondTxt;
    public Text instrucDoorTxt;

    void Start()
    {
        instrucDiamondTxt.gameObject.SetActive(false);
        instrucDoorTxt.gameObject.SetActive(false);
        ShowTextForDuration();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowTextForDuration()
    {
        StartCoroutine(showTempDiamondsTxt());
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collision with player detected!");
           
            StartCoroutine(showTempDoorTxt());
            Destroy(this.gameObject);
        }
    }

    private IEnumerator showTempDoorTxt()
    {
        instrucDoorTxt.gameObject.SetActive(true);
        yield return new WaitForSeconds(5f);
        instrucDoorTxt.gameObject.SetActive(false);

    }

    private IEnumerator showTempDiamondsTxt()
    {
        // Show the text
        instrucDiamondTxt.gameObject.SetActive(true);

        // Wait for 5 seconds
        yield return new WaitForSeconds(5f);

        // Hide the text after 5 seconds
        instrucDiamondTxt.gameObject.SetActive(false);
    }
}
