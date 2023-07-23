using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectingCoins : MonoBehaviour
{
    public int coins;
    public GameObject ball;
    [SerializeField] private AudioSource collectSound;
    // Start is called before the first frame update
    void Start()
    {
        ball.SetActive(false);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Coin")
        {
            collectSound.Play();
            Debug.Log("Coin collected! ");
            coins = coins + 1;
            Destroy(col.gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    {
        if(coins == 5)
        { 
            ball.SetActive(true);
        }
        if(coins > 5)
        {
            SceneManager.LoadScene(5);

        }

    }
}
