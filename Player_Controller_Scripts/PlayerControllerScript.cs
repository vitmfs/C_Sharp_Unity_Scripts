using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin;
    public float xMax;
    public float zMin;
    public float zMax;

}

public class PlayerControllerScript : MonoBehaviour
{

    private Rigidbody   rb;

    public float        speed;

    public Boundary     boundary;

    // MIGHT NOT BE APPLICABLE
    public float        tilt;

    public GameObject boltShot;
    public Transform shotSpawn;

    public  float fireRate;
    private float nextFire;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }




    // JUST BEFORE UPDATING THE FRAME, EVERY FRAME
    // FIRE AND GET INPUT FROM KEYS DOES NOT REQUIRE PYSHICS 
    // AND WE DO NOT WANT TO WAIT
    void Update()
    {
        
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            GameObject clone = Instantiate(boltShot, shotSpawn.position, shotSpawn.rotation) as GameObject;

            audioSource.Play();
        }

    }





    // IF WE USE PHYSICS WE NEED TO USE FIXED UPDATE
    // CALLED BY UNITY BEFORE EACH FIXED PHYSICS STEP
    void FixedUpdate()
    {

        float moveHorizontal    = Input.GetAxis( "Horizontal"   );
        float moveVertical      = Input.GetAxis( "Vertical"     );

        rb = GetComponent<Rigidbody>();

        Vector3 movementVector3 = new Vector3( moveHorizontal, 0.0f, moveVertical );

        rb.velocity = movementVector3 * speed;

        rb.position = new Vector3
        (

            Mathf.Clamp( rb.position.x, boundary.xMin, boundary.xMax ),
            0.0f,
            Mathf.Clamp( rb.position.z, boundary.zMin, boundary.zMax )

        );

        // MIGHT NOT BE APPLICABLE
        rb.rotation = Quaternion.Euler( 0.0f, 0.0f, rb.velocity.x * -tilt );


    }

    
}


