using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingCoins : MonoBehaviour
{
    public int coins;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        ball.SetActive(false);
        
        
    }
    public void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Coin")
        {
            Debug.Log("Coin collected! ");
            coins = coins + 1;
            col.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(coins == 5)
        {
            
            ball.SetActive(true);
        }
        
    }
}
