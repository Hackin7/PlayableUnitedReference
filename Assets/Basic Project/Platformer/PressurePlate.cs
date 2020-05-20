using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PressurePlate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Material green;
    public Text t;
    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.name == "Player"){
            GetComponent<Renderer>().material = green;
            t.text = "Yay you reached!";
        }
    }
    public Material red;
    void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.name == "Player"){
            //GetComponent<Renderer>().material = red;
        }
    }

}
