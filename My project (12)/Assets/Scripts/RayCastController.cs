using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;
using UnityEngine.UI;


public class RayCastController : MonoBehaviour
{

    private int layerMask;
    private int layerNumber = 6;

    GameObject player;
    NavMeshAgent agent;
    public Text guardHitTxt;


    public float raycastCooldown = 1f; 
    private float raycastTimer = 0f;

    public float raycastDistance = 8f;





    public float elevation = 2.0f; // Adjust this value to control the elevation of the raycast
                                  
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player");
        layerMask = 1 << layerNumber;
        guardHitTxt.gameObject.SetActive(false);
    }
    void Update()
    {
        if (raycastTimer <= 0f)
        {
            RaycastHit hit;
            Vector3 raycastStartPosition = transform.position + Vector3.up * elevation;
            Debug.DrawRay(raycastStartPosition, transform.forward * 5, Color.green);
            Vector3 raycastDirection = transform.forward;



            // if (Physics.Raycast(raycastStartPosition, transform.forward, out hit, 15))
            if (Physics.Raycast(raycastStartPosition, transform.forward, out hit, raycastDistance, layerMask))
            {
                StartCoroutine(showGuardHitTxt());
                Debug.Log("Hit");
                Debug.Log("inside: " + scoreScript.harts);
                scoreScript.harts--;
                if (scoreScript.harts <= 0)
                    SceneManager.LoadScene(3);

                raycastTimer = raycastCooldown;
            }
        }
        else
        {
            raycastTimer -= Time.deltaTime;
        }
    }


    private IEnumerator showGuardHitTxt()
    {
        // Show the text
        guardHitTxt.gameObject.SetActive(true);

        // Wait for 5 seconds
        yield return new WaitForSeconds(5f);

        // Hide the text after 5 seconds
        guardHitTxt.gameObject.SetActive(false);
    }
}

