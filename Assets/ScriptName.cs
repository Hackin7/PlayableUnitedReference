using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptName : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
        {
            print("K");
            // Run code here when key is pressed
            transform.Translate(new Vector3(10f * Time.deltaTime,0f, 0f));
        }

    }
}
