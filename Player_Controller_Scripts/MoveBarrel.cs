using UnityEngine;
using System.Collections;

public class MoveBarrel : MonoBehaviour {
	public float hSpeed;
	public int score;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
		float x = Input.GetAxis ("Horizontal") * Time.deltaTime * hSpeed;
		
		if ( transform.position.x > 10 )
        {
			transform.position = new Vector3(10,transform.position.y,transform.position.z);

		}
        else
        {
			if ( transform.position.x < -10 )
            {
				transform.position = new Vector3(-10,transform.position.y,transform.position.z);
			}
            else
            {
				transform.Translate (x, 0, 0);
			}
		}
	}

	void OnGUI() {
		float boxWidth = 150;
		float boxHeigth = 30;

		GUI.Box (new Rect ((Screen.width / 1.2f), Screen.height / 20, boxWidth, boxHeigth), "Score: "+ GlobalVar.score);

		if(GUI.Button(new Rect((Screen.width / 10),(Screen.height / 20) + (boxHeigth / 2) + 10,boxWidth,boxHeigth), "Menu")) {
			Application.LoadLevel(0);
		}
	}
}
