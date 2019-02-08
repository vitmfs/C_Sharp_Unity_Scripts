using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHero : MonoBehaviour {

	void Start () {
		
	}


    Rigidbody m_Rigidbody;
    float Speed = 5;
    float Speed_rotation = 10;

	void Update () {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * Speed);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * -Speed);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {

            transform.Rotate(0, Time.deltaTime * Speed_rotation, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, Time.deltaTime * Speed_rotation * -1, 0);
        }

		
	}
}

