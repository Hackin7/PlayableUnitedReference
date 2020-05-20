using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //// Horrible movement /////////////////////////////////////
        transform.rotation = Quaternion.identity; //Keep the rotation fixed
        if (Input.GetKey("left"))
        {
            // Run code here when key is pressed
            transform.Translate(new Vector3(-10f * Time.deltaTime, 0f, 0f));
        }
        if (Input.GetKey("right"))
        {
            // Run code here when key is pressed
            transform.Translate(new Vector3(10f * Time.deltaTime, 0f, 0f));
        }
        if (Input.GetKey("up"))
        {
            // Run code here when key is pressed
            transform.Translate(new Vector3(0f, 0f ,10f * Time.deltaTime));
        }
        if (Input.GetKey("down"))
        {
            // Run code here when key is pressed
            transform.Translate(new Vector3(0f, 0f, -10f * Time.deltaTime));
        }
        //////////////////////////////////////////////////////////////
        /*
        float translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float straffe = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        transform.Translate(straffe, 0, translation);
        transform.rotation = Quaternion.identity;
        */

    }
    private void OnCollisionStay(Collision collision)
    {
       if (collision.gameObject.tag=="Floor")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GetComponent<Rigidbody>().AddForce(Vector3.up * 5f,
                ForceMode.Impulse);
            }
        }
    }
}
