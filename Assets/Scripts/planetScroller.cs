using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetScroller : MonoBehaviour
{
    public GameObject buttonLeft;
    public GameObject buttonRight;

    buttonCheck btnLeft;
    buttonCheck btnRight;

    [SerializeField]
    private float translateSpeed = 2f;
    
    // Start is called before the first frame update
    void Start()
    {
        btnLeft = buttonLeft.GetComponent<buttonCheck>();
        btnRight = buttonRight.GetComponent<buttonCheck>();
    }

    // Update is called once per frame
    void Update()
    {
        if (btnLeft.isPressed)
        {
            transform.Translate(new Vector3(-translateSpeed, 0, 0));
        }
        if (btnRight.isPressed)
        {
            transform.Translate(new Vector3(translateSpeed, 0, 0));
        }
    }
}
