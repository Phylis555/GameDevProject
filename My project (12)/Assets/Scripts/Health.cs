using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    
    public Animator anim;
    private bool dead = false;




    private void OnTriggerEnter(Collider other)
    {
        Destroy(transform.GetComponent<Rigidbody>());
        if (other.tag == "Bear")
        {
            if (!dead)
            {
                anim.SetTrigger("die");
                GetComponent<playerMovmentScript>().enabled = false;
                StartCoroutine(delay());
                dead = true;

               


            }
        }
    }

    private IEnumerator delay()
    {
        // Wait for 2 seconds
        yield return new WaitForSeconds(2f);

        // Code to be executed after the delay
        SceneManager.LoadScene(1);
    }

}
