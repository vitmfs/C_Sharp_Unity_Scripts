using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltMoverScript : MonoBehaviour
{

    private Rigidbody rb;

    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
