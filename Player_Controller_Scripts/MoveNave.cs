using UnityEngine;
using System.Collections;

public class MoveNave : MonoBehaviour {
	public float hSpeed = 10f;
	public float vSpeed = 5f;
	public Transform bullet;
	public AudioClip DamageSound;

	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis ("Horizontal") * Time.deltaTime * hSpeed;
		float z = Input.GetAxis ("Vertical") * Time.deltaTime * vSpeed;

		if (transform.position.x > 5) {
			Debug.Log ("Bateu");
			transform.position = new Vector3(5,transform.position.y,transform.position.z);
		} else {
			if (transform.position.x < -5) {
				transform.position = new Vector3(-5,transform.position.y,transform.position.z);
			} else {
				transform.Translate (x, 0, z);
			}
		}
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "Enemy") {
			Destroy(col.gameObject);
			GlobalVar.playerLife--;
			GameObject.Find("st_plane").GetComponent<AudioSource>().PlayOneShot(DamageSound);
		}
	}

	void OnGUI() {
		float boxWidth = 150;
		float boxHeigth = 30;
		GUI.Box (new Rect ((Screen.width/2-boxWidth/2)-250,Screen.height/20,boxWidth,boxHeigth), "Pontos: "+GlobalVar.playerPoints);
		GUI.Box (new Rect ((Screen.width/2-boxWidth/2)+250,Screen.height/20,boxWidth,boxHeigth), "Vidas: "+GlobalVar.playerLife);
		if (GlobalVar.isDead) {
			GUI.Box (new Rect ((Screen.width / 2) - (boxWidth / 2), (Screen.height / 2) - (boxHeigth / 2), boxWidth, boxHeigth), "Perdeste!");
			if(GUI.Button(new Rect((Screen.width / 2) - (boxWidth / 2),(Screen.height / 2) + (boxHeigth / 2) + 10,boxWidth,boxHeigth), "Menu")) {
				Application.LoadLevel(0);
			}
			if(GUI.Button(new Rect((Screen.width / 2) - (boxWidth / 2),(Screen.height / 2) + (boxHeigth / 2) + 50,boxWidth,boxHeigth), "Recomeçar")) {
				Application.LoadLevel(1);
			}
		}
	}
}
