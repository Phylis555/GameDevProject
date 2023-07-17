using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    [SerializeField] private Rigidbody rb;

    public void Init(float velocity) {
        rb.velocity = transform.forward * velocity;
    }
}
