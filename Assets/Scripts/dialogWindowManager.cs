using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogWindowManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = Vector3.zero;
    }

    public void open()
    {
        transform.LeanScale(Vector3.one/2.0f, 0.3f);

    }

    public void close()
    {
        transform.LeanScale(Vector3.zero, 0.3f);

    }
}
