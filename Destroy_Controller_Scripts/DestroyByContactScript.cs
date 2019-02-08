using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyByContactScript : MonoBehaviour
{
    // MIGHT BE UNNECESSARY
    public GameObject   explosion;
    public GameObject   playerExplosion;

    //public int          scoreValue;
    //private GameControllerScript gameControllerScript;

    private Text scoreText;

    void Start()
    {
        /*
        GameObject gameControllerObject = GameObject.FindWithTag( "GameController_Tag" );

        if (gameControllerObject != null)
        {

            gameControllerScript = gameControllerObject.GetComponent<GameControllerScript>();
        }

        if (gameControllerScript == null)
        {
            Debug.Log( "Cannot find Game Controller Script!" );

        }
        */

        scoreText = GameObject.Find("score_text").GetComponent<Text>();
    }

    void OnTriggerEnter( Collider otherCollider )
    {

        //Debug.Log( otherCollider.name );

        // IGNORE THE BOUNDARY BOX
        if (otherCollider.tag == "Boundary_Tag")
        {
            return;
        }

        // MIGHT BE UNNECESSARY
        Instantiate( explosion, transform.position, transform.rotation );

        if (otherCollider.tag == "Player_Tag")
        {
            Instantiate(playerExplosion, otherCollider.transform.position, otherCollider.transform.rotation);
        }

        GameControllerScript.score += 10;
        scoreText.text = "" + GameControllerScript.score;
        //Debug.Log(GameControllerScript.score);


        //gameControllerScript.AddScore( scoreValue );

        Destroy( otherCollider.gameObject );

        // IT MARKS THE OBJECT TO BE DESTROYED AT THE END
        // OF THE FRAME, IT DOES NOT MATTER THE ORDER IN 
        // WICH WE MARK OUR OBJECTS TO BE DESTROYED, AS 
        // LONG AS THEY ARE MARKED IN THE SAME FRAME
        Destroy( gameObject );
    }
}
