using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightDoorController : MonoBehaviour
{
  
    
    Animator rightDoorAnimetor;

    // Start is called before the first frame update
    void Start()
    {
        rightDoorAnimetor = this.transform.parent.GetComponent<Animator>();
    }
    private void OnTriggerExit(Collider other)
    {
        rightDoorAnimetor.SetBool("RightIsOpen", false);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (scoreScript.keyColected)
            rightDoorAnimetor.SetBool("RightIsOpen", true);

    }


    // Update is called once per frame
    void Update()
    {

    }
}
