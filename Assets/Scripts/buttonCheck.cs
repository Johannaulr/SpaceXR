using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonCheck : MonoBehaviour
{
    public bool isPressed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void buttonPressed()
    {
        isPressed = true;
    }

    public void buttonRelease()
    {
        isPressed = false;
    }
}
