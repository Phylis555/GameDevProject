using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorController : MonoBehaviour
{

    Animator leftDoorAnimetor;
    // Start is called before the first frame update
    void Start()
    {
        leftDoorAnimetor = this.transform.parent.GetComponent<Animator>();
    }
    private void OnTriggerExit(Collider other)
    {
        leftDoorAnimetor.SetBool("leftIsOpening", false);

    }
    private void OnTriggerEnter(Collider other)
    {
        leftDoorAnimetor.SetBool("leftIsOpening", true);

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
