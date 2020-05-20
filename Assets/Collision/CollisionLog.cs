using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionLog : MonoBehaviour
{
    public Material enter;
    public Material exit;
    // Start is called before the first frame update
    void Start()
    {
        /* The following components should be created and configured in this manner */
        //Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>(); // Add the rigidbody.
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.mass = 0;
        rigidbody.useGravity = false;
        rigidbody.isKinematic = false; //MUST be disabled for at least 1 object
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /* 
    Collisions happen between 2 overlapping/colliding GameObjects where
        Both GameObjects' collider must have isTrigger=false
        Both GameObjects must have Rigidbodies
        At least 1 GameObject's Rigidbody must have isKinematic=false
    They run the functions below AND exert a force on the previous GameObject
    */
    void OnCollisionEnter(Collision collision)
    {
        if (!enabled) { return; }
        Debug.Log("OnCollisionEnter: " + collision.gameObject.name);
        GetComponent<Renderer>().material = enter;
    }
    void OnCollisionStay(Collision collision)
    {
        if (!enabled) { return; }
        Debug.Log("OnCollisionStay: " + collision.gameObject.name);
    }
    void OnCollisionExit(Collision collision)
    {
        if (!enabled) { return; }
        Debug.Log("OnCollisionExit: " + collision.gameObject.name);
        GetComponent<Renderer>().material = exit;
    }
}
