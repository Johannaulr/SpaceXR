using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warningWindowManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.LeanScale(Vector3.zero, 0.3f);
    }
    public void open()
    {
        transform.LeanScale(Vector3.one / 3.0f, 0.3f);

    }

    public void close()
    {
        transform.LeanScale(Vector3.zero, 0.3f);

    }
}
