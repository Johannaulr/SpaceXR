using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetRotate : MonoBehaviour
{
    public float rotateDir;
    public float  rotationsPerMin;
    bool canRotate=true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canRotate)
        transform.Rotate(0, 6.0f * rotationsPerMin * rotateDir * Time.deltaTime, 0);
    }
}
