using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CollisionDetectText : MonoBehaviour
{
    // Start is called before the first frame update

    public Text instrucDoorTxt;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "invisibleBox")
        {
            Debug.Log("Collision with player detected!");
            instrucDoorTxt.gameObject.SetActive(true);
          //  StartCoroutine(showTempDoorTxt());
        }
    }

    private IEnumerator showTempDoorTxt()
    {
        
        yield return new WaitForSeconds(5f);
        instrucDoorTxt.gameObject.SetActive(false);

    }
}
