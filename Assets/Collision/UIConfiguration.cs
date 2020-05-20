using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIConfiguration : MonoBehaviour
{
    public Toggle rigidbodyToggle;
    public Toggle rigidbodyKinematicToggle;
    public Toggle isTriggerToggle;
    public Toggle triggerToggle;
    public Toggle collisionToggle;

    private bool rbKinematic = true;
    // Start is called before the first frame update
    void Start()
    {
        // GameObject Configuration ////////////////////////////
        //Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>(); // Add the rigidbody.
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.mass = 0;
        rigidbody.useGravity = false;
        rigidbody.isKinematic = rbKinematic;

        //BoxCollider boxcollider = gameObject.AddComponent<BoxCollider>(); // Add the rigidbody.
        BoxCollider boxcollider = GetComponent<BoxCollider>();
        boxcollider.isTrigger = true;
        //////////////////////////////////////////////////////
        
        rigidbodyToggle.onValueChanged.AddListener(delegate {
            //GetComponent<Rigidbody>().detectCollisions = rigidbodyToggle.isOn;
            if (rigidbodyToggle.isOn) {
                Rigidbody gameObjectsRigidBody = gameObject.AddComponent<Rigidbody>(); // Add the rigidbody.
                gameObjectsRigidBody.mass = 0;
                gameObjectsRigidBody.useGravity = false;
                gameObjectsRigidBody.isKinematic = rbKinematic;
            }
            else{
                Destroy(GetComponent<Rigidbody>());
            }
        });
        rigidbodyKinematicToggle.onValueChanged.AddListener(delegate {
            rbKinematic = rigidbodyKinematicToggle.isOn;
            if (rigidbodyToggle.isOn) { GetComponent<Rigidbody>().isKinematic = rbKinematic; }
        });
        isTriggerToggle.onValueChanged.AddListener(delegate {
            GetComponent<BoxCollider>().isTrigger = isTriggerToggle.isOn;
        });
        triggerToggle.onValueChanged.AddListener(delegate {
            GetComponent<Trigger>().enabled = triggerToggle.isOn;
        });
        collisionToggle.onValueChanged.AddListener(delegate {
            GetComponent<CollisionLog>().enabled = collisionToggle.isOn;
        });
    }

    // Update is called once per frame
    void Update()
    {
        //Reset the state if it's messed up
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Collision Simulation");
        }
    }
}
