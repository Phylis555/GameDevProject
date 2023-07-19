using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestractivScript : MonoBehaviour
{
    public Transform remain;
    [SerializeField] private bool _broken;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if (_broken) return;
        else
        {
            _broken = true;
           
                Instantiate(remain, transform.position, Quaternion.identity);
                Destroy(gameObject);
            
        }
    }
}
