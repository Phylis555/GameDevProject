using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class RayCastController : MonoBehaviour
{

    private int layerMask;
    private int layerNumber = 6;

    GameObject player;
    NavMeshAgent agent;
    [SerializeField] float sightRange;
    bool playerInSight;
    //public float raycastDistance = 10f;

    //// Update is called once per frame
    //void Update()
    //{
    //    transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    //    RaycastHit hit;
    //    if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward),out hit, Mathf.Infinity))
    //    {
    //        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
    //    }
    //    else
    //    {
    //        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 8, Color.blue);
    //    }
    //}

    public float elevation = 2.0f; // Adjust this value to control the elevation of the raycast
                                   //  public GameObject firstPersonController;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player");
        layerMask = 1 << layerNumber;
    }
    void Update()
    {
        RaycastHit hit;
        Vector3 raycastStartPosition = transform.position + Vector3.up * elevation;
        Debug.DrawRay(raycastStartPosition, transform.forward * 5, Color.green);
        Vector3 raycastDirection = transform.forward;

        

        // if (Physics.Raycast(raycastStartPosition, transform.forward, out hit, 15))
        if (Physics.Raycast(raycastStartPosition, transform.forward, out hit, 15, layerMask))
        {
            // Debug.Log("Hit");
            // if (hit.collider.gameObject.tag == "Player")
            // {
            //hit.collider.transform.position = new Vector3(719f, 18.8f, 503f);
            //transform.position = new Vector3(519f, -0.8f, 420f);
            Chase();
            //Debug.Log("inside: " + scoreScript.harts);
            //scoreScript.harts--;
            //if (scoreScript.harts <= 0)
            //    SceneManager.LoadScene(3);


            // }

        }
    }

    void Chase()
    {
        agent.SetDestination(player.transform.position);
    }
}

