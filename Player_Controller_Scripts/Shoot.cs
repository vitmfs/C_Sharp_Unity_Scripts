using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	public Transform bullet;
	public AudioClip ShootSound;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump"))  {
			GameObject.Find("st_plane").GetComponent<AudioSource>().PlayOneShot(ShootSound);
			Instantiate(bullet, transform.position, transform.rotation);

		}
	}

	//key events
	/*bool down = Input.GetButtonDown("Jump");
	bool held = Input.GetButton("Jump");
	bool up = Input.GetButtonUp("Jump");*/
}
