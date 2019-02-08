using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryDestroyerScript : MonoBehaviour
{
    void OnTriggerExit( Collider otherCollider )
    {
        Destroy( otherCollider.gameObject );

    }
}
