using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSphereControllerScript : MonoBehaviour
{
    private Rigidbody   rb;

    public  float       speed;

    private int         count;
    public  Text        countText;

    public  Text        winText;
  

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        count = 0;
        SetCountText();

        winText.text = "";

    }

    // Update IS CALLED BEFORE RENDERING A FRAME
    void Update()
    {
        
    }

    void FixedUpdate()
    {

        float moveHorizontal    = Input.GetAxis( "Horizontal" );
        float moveVertical      = Input.GetAxis( "Vertical" );

        Vector3 movementVector3 = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce( movementVector3 * speed );

    }

    void OnTriggerEnter( Collider otherCollider )
    {
        if ( otherCollider.gameObject.CompareTag( "pick_up" ) )
        {

            otherCollider.gameObject.SetActive( false );

            count = count + 1;
            SetCountText();

            if  ( count >= 12 )
            {
                winText.text = "You Win!";

            }

        }

        // Destroy( otherCollider.gameObject );

    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
    }

    
}
