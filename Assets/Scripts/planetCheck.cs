using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetCheck : MonoBehaviour
{

    public bool planetDetect=false;
    public string planetTag="empty";

    BoxCollider boxcollider;
    // Start is called before the first frame update
    void Start()
    {
        boxcollider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Empty")
        {
            planetDetect = true;
            planetTag = other.tag;
            Debug.Log(planetTag);
            StartCoroutine(DisableCollider(1f));
        }
        

    }

   

    IEnumerator DisableCollider(float time)
    {
        boxcollider.enabled = false;
        yield return new WaitForSeconds(time);
        boxcollider.enabled = true;
        planetDetect = false;
    }
}
