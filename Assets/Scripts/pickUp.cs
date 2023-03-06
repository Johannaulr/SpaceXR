using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
    public GameObject UI;

    private GameObject Earth;
    private GameObject EarthUI;
    // Start is called before the first frame update
    void Start()
    {
        Earth = GameObject.Find("Earth");
        EarthUI = GameObject.Find("EarthUI");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Planet")
        {

            UI.SetActive(true);
            if (other == Earth)
            {
                //serialController.turnOnLED();
                EarthUI.SetActive(true);
            }

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
