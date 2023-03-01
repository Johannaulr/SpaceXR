using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
    public GameObject cube;
    public Material red;
    public Material standard;
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
        serialController.turnOnLED();
        cube.GetComponent<MeshRenderer>().material = red;
    }

    private void OnTriggerEnter(Collider other)
    {
        serialController.turnOffLED();
        cube.GetComponent<MeshRenderer>().material = standard;
    }
}
