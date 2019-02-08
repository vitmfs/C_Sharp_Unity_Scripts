using UnityEngine;
using System.Collections;

public class MoveCar : MonoBehaviour {
	public float carSpeed = 10f;
	public float rotateCar = 30f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float z = Input.GetAxis ("Vertical") * Time.deltaTime * carSpeed;

		transform.Translate (0, 0, z);

		/*if (Input.GetAxis("Horizontal") > 0) {
			transform.Rotate (Vector3.up * rotateCar * Time.deltaTime);
		} else if (Input.GetAxis("Horizontal") < 0) {
			transform.Rotate (Vector3.up * -rotateCar * Time.deltaTime);
		}*/

		if (Input.GetButton ("Horizontal")) {
			if (Input.GetAxis("Horizontal") > 0) {
			transform.Rotate (Vector3.up * rotateCar * Time.deltaTime);
			} else {
			transform.Rotate (Vector3.up * -rotateCar * Time.deltaTime);
			}
		} 

	}
}
