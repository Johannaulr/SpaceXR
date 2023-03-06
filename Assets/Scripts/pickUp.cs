using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
    public GameObject UI;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Planet")
        {
            //serialController.turnOnLED();
            //cube.GetComponent<MeshRenderer>().material = red;
            UI.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Planet")
        {
            //serialController.turnOffLED();
                   // cube.GetComponent<MeshRenderer>().material = standard;
                    UI.SetActive(false);
        }
    }
        
}
