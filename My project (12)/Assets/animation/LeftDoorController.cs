using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftDoorController : MonoBehaviour
{
    Animator LeftDoorAnimetor;

    // Start is called before the first frame update
    void Start()
    {
        LeftDoorAnimetor = this.transform.parent.GetComponent<Animator>();
    }
    private void OnTriggerExit(Collider other)
    {
        if(scoreScript.keyColected)
        LeftDoorAnimetor.SetBool("leftIsOpening", false);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (scoreScript.keyColected)
            LeftDoorAnimetor.SetBool("leftIsOpening", true);

    }
}
