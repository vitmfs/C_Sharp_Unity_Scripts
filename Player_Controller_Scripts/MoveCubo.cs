using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCubo : MonoBehaviour {

	void Start () {
		
	}

    public float Points = 0;

    public GameObject Bullet;

    float Speed = 3;
    float Speed_rotation = 10;

	void Update () {

        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * Speed);
        }


        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * Speed * -1);
        }


        if (Input.GetKey(KeyCode.RightArrow))
        {

            transform.Rotate(0, Time.deltaTime * Speed_rotation, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, Time.deltaTime * Speed_rotation * -1, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel("MainMenu");            
        }
        
        

	}


    void OnCollisionEnter(Collision obj)
    {
        Debug.Log("Bateu em " + obj.gameObject.name);

        if (obj.gameObject.name == "Flag")
        {
            Points = Points + 100;
            Debug.Log("Tens agora estes Pontos=" + Points);
            Destroy(obj.gameObject);
        }

        if (obj.gameObject.name == "Flag2")
        {
            Points = Points + 50;
            Debug.Log("Tens agora estes Pontos=" + Points);
            Destroy(obj.gameObject);
        }

    }



    void Fire()
    {

        Debug.Log("Space foi pressionado.");

        Instantiate(Bullet, transform.position, transform.rotation);

        /*
        
        var bullet = (GameObject)Instantiate(
            PrefabBullet,
            BulletStart.position,
            BulletStart.rotation);
        */
        //bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6;

        Destroy(Bullet, 2.0f);   


    }


    void OnGUI()
    {
        GUI.Button(new Rect(10, 10, 200, 20), "SCORE:" + Points);
    }

         

}
