using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveT : MonoBehaviour {

    public Transform mira;

	void Start () {
		
	}
	
	
	void Update () {

        transform.LookAt(mira);
		
	}
}


