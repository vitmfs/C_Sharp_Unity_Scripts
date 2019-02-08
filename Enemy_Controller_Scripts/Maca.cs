using UnityEngine;
using System.Collections;

public class Maca : MonoBehaviour
{

	public  float       macaSpeed = 10f;
	public  int         macaID;
	private float       z;
	public  AudioClip   apanhou;

	// Use this for initialization
	void Start () {
	
	}
	

	// Update is called once per frame
	void Update ()
    {
		if ( GlobalVar.macaCai == macaID )
        {
			z = Time.deltaTime * macaSpeed;
			transform.Translate (0, 0, -z);
		}
	}

	void OnCollisionEnter( Collision col )
    {
		if ( col.gameObject.tag == "Player" ) {

			GameObject.Find ( "Plane" ).GetComponent<AudioSource> ().PlayOneShot( apanhou );
			GlobalVar.SetPoints();
			GlobalVar.setNovaMaca ();
			Destroy ( this.gameObject );
		}

		if ( col.gameObject.name == "end" )
        {
			GlobalVar.SetNegativePoints();
			GlobalVar.setNovaMaca ();
			Destroy ( this.gameObject );
		}
	
	}
}
