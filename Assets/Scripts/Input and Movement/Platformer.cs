using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platformer : MonoBehaviour
{
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody gameObjectsRigidBody = gameObject.AddComponent<Rigidbody>(); // Add the rigidbody.
        Rigidbody gameObjectsRigidBody = GetComponent<Rigidbody>();
        gameObjectsRigidBody.mass = 1;
    }

    // Update is called once per frame
    void Update(){
        // Movement
        float translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float straffe = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        transform.Translate(straffe, 0, translation);
        transform.rotation = Quaternion.identity;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 5f, ForceMode.Impulse);
        }
    }
}
