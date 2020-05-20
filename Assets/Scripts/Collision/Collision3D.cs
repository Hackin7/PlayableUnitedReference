using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://docs.unity3d.com/ScriptReference/BoxCollider.html
public class Collision3D : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Required for both Collision and Trigger Detection
        Rigidbody gameObjectsRigidBody = gameObject.AddComponent<Rigidbody>(); // Add the rigidbody.
        gameObjectsRigidBody.mass = 0;
        gameObjectsRigidBody.isKinematic = true;

        BoxCollider boxcollider = gameObject.AddComponent<BoxCollider>(); // Add the rigidbody.
        boxcollider.isTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    ////In-built methods//////////////////////////////////////////////////////////////////////////
    //Colliders: Exerts force
    //https://answers.unity.com/questions/597269/how-to-use-oncollisionenter.html
    //When a rigid body is detected
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter: " + collision.gameObject.name);
    }
    void OnCollisionStay(Collision collision)
    {
        Debug.Log("OnCollisionStay: " + collision.gameObject.name);
    }
    void OnCollisionExit(Collision collision)
    {
        Debug.Log("OnCollisionExit: " + collision.gameObject.name);
    }
    //For Triggers: A trigger is just a collider set only to report overlaps rather than apply a force.
    // When a Box Collider is detected: If this has problems, use the above one with a kinematic rigidbody
    void OnTriggerEnter(Collider coll)
    {
        Debug.Log("OnTriggerEnter: " + coll.gameObject.name);
    }
    void OnTriggerStay(Collider coll)
    {
        Debug.Log("OnTriggerStay: " + coll.gameObject.name);
    }
    void OnTriggerExit(Collider coll)
    {
        Debug.Log("OnTriggerExit: " + coll.gameObject.name);
    }
}
