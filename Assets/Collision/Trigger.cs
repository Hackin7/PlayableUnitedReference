using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public Material enter;
    public Material exit;
    // Start is called before the first frame update
    void Start()
    {
        /* The following components should be created and configured in this manner */
        //BoxCollider boxcollider = gameObject.AddComponent<BoxCollider>(); // Add the rigidbody.
        BoxCollider boxcollider = GetComponent<BoxCollider>();
        boxcollider.isTrigger = true;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    /* 
    Triggers happen between 2 overlapping/colliding GameObjects where
        At least 1 GameObject's collider must have isTrigger=true
        At least 1 GameObject must have a Rigidbody
    They run the functions below WITHOUT exerting a force on the previous GameObject
    (Only report overlaps)
    */
    void OnTriggerEnter(Collider coll)
    {
        if (!enabled) { return; }
        Debug.Log("OnTriggerEnter: " + coll.gameObject.name);
        GetComponent<Renderer>().material = enter;
    }
    void OnTriggerStay(Collider coll)
    {
        if (!enabled) { return; }
        Debug.Log("OnTriggerStay: " + coll.gameObject.name);
    }
    void OnTriggerExit(Collider coll)
    {
        if (!enabled) { return; }
        Debug.Log("OnTriggerExit: " + coll.gameObject.name);
        GetComponent<Renderer>().material = exit;
    }
}
