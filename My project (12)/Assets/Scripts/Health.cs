using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Health : MonoBehaviour
{
    //[SerializeField] private float startingHealth;
    //public float currentHealth { get; private set; }

    [SerializeField] private int health;
    [SerializeField] private int numOfHearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    
    public Animator anim;
  //  private bool dead = false;

    private void Start()
    {
        health = scoreScript.harts;
    }

    void Update()
    {

        if(health > numOfHearts)
        {
            health = numOfHearts;
        }
        for (int i = 0; i < hearts.Length; i++)
        {

       
            if (i < scoreScript.harts)

            {
                hearts[i].sprite = fullHeart;

            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            if(i <numOfHearts)
            {
                hearts[i].enabled = true;
            } else {
                hearts[i].enabled = false;
            }

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(transform.GetComponent<Rigidbody>());
        if (other.tag == "Bear")
        {

            health--;
            scoreScript.harts = health;
            if (health <= 0)
            {
                anim.SetTrigger("die");
                GetComponent<playerMovmentScript>().enabled = false;
                StartCoroutine(delay());
               // dead = true;

               


            }
        }
    }

    private IEnumerator delay()
    {
        // Wait for 2 seconds
        yield return new WaitForSeconds(2f);

        // Code to be executed after the delay
        SceneManager.LoadScene(3);
    }

}
