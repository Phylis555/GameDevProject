using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class house3doorController : MonoBehaviour
{
    Animator DoorAnimetor;

    // Start is called before the first frame update
    void Start()
    {
        DoorAnimetor = this.transform.parent.GetComponent<Animator>();
    }
    private void OnTriggerExit(Collider other)
    {
        DoorAnimetor.SetBool("isOpen", false);

    }
    private void OnTriggerEnter(Collider other)
    {
        DoorAnimetor.SetBool("isOpen", true);

    }


    // Update is called once per frame
    void Update()
    {

    }
}
