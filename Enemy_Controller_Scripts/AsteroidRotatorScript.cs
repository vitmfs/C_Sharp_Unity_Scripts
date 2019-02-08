using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidRotatorScript : MonoBehaviour { 

    private Rigidbody rb;

    public float tumble;

    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.angularVelocity = Random.insideUnitSphere * tumble;

        rb.velocity = transform.forward * speed;

    }
}
