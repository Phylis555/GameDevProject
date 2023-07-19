using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestractivScript : MonoBehaviour
{
    public Transform remain;


    void Update()
    {
        if (Input.GetKey(KeyCode.G))
        { 
            Instantiate(remain, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
    }

}
