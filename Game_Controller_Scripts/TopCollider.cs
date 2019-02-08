using UnityEngine;
using System.Collections;

public class TopCollider : MonoBehaviour {

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "Bullet") {
			Destroy (col.gameObject);
		}
	}
}
