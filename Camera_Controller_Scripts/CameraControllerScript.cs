using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerScript : MonoBehaviour
{

    public  GameObject  playerObject;

    private Vector3     offsetVector3;


    // Start is called before the first frame update
    void Start()
    {

        offsetVector3 = transform.position - playerObject.transform.position;
        
    }

    // FOR FOLLOW CAMERAS, PROCEDURAL ANIMATION AND GATHERING LAST KNOWN STATES
    // IT'S BEST TO USE LATEUPDATE RUNS EVERY FRAME AFTER ALL ITEMS HAVE BEEN 
    // PROCESSED
    void Update()
    {

        transform.position = playerObject.transform.position + offsetVector3;
        
    }
}
