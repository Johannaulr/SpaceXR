using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetScroller : MonoBehaviour
{
    public GameObject buttonLeft;
    public GameObject buttonRight;

    buttonCheck btnLeft;
    buttonCheck btnRight;

    public GameObject planetDisplaySmall;
    public GameObject planetDisplayLarge;
    public GameObject planetChecker;

    public GameObject[] planets;

    private Transform[] initialPos;

    private planetCheck planetScript;

    [SerializeField]
    private float translateSpeed = 2f;

    bool isMoved = false;

    // Start is called before the first frame update
    void Start()
    {
        btnLeft = buttonLeft.GetComponent<buttonCheck>();
        btnRight = buttonRight.GetComponent<buttonCheck>();
        planetScript = planetChecker.GetComponent<planetCheck>();

       // for(int i = 0; i < planets.Length; i++)
       // {
       //     initialPos[i].position = planets[i].transform.position;
       // }
    }

    // Update is called once per frame
    void Update()
    {
        if (btnLeft.isPressed && planetScript.planetDetect == false)
        {
            if (!isMoved)
            {
                string planet = planetScript.planetTag;
                PlanetDisplay(SetIndex(planet));
                transform.Translate(new Vector3(-translateSpeed, 0, 0));
                Debug.Log(translateSpeed);
            }
            
        }
        else if (planetScript.planetDetect == true)
        {
            string planet = planetScript.planetTag;
            PlanetDisplay(SetIndex(planet));

            StartCoroutine(StopScroll(2f));
            isMoved = false;
        }

        if (btnRight.isPressed && planetScript.planetDetect == false)
        {
            if(!isMoved)
            {
                string planet = planetScript.planetTag;
                PlanetDisplay(SetIndex(planet));
                transform.Translate(new Vector3(translateSpeed, 0, 0));
                Debug.Log(translateSpeed);
            }
           
        }
        else if (planetScript.planetDetect == true)
        {
            string planet = planetScript.planetTag;
            PlanetDisplay(SetIndex(planet));
            StartCoroutine(StopScroll(2f));
            isMoved = false;
        }
    }

    IEnumerator StopScroll(float waitTime)
    {
        float init_translateSpeed = translateSpeed;
        translateSpeed = 0f;
        Debug.Log(translateSpeed + " Planet");
        yield return new WaitForSeconds(waitTime);
        translateSpeed = init_translateSpeed;
        // Stops scrolling of planets. Can also be used to display UI
    }

    void PlanetDisplay(int index)
    {
        GameObject activePlanet = planets[index];
        Vector3 initPos = activePlanet.transform.position;
        if (index < 4)
        {
            
            activePlanet.transform.position = planetDisplaySmall.transform.position;
            isMoved = true;
        }
        else if(index<8)
        {
            activePlanet.transform.position = planetDisplayLarge.transform.position;
            isMoved = true;
        }

        if (btnLeft.isPressed || btnRight.isPressed)
        {
            activePlanet.transform.position = initPos;
            isMoved = false;
        }




    }

    private int SetIndex(string tag)
    {
        if (tag!="empty")
        {
            switch (tag)
            {
                case "Mercury":
                    return 0;

                case "Venus":
                    return 1;

                case "Earth":
                    return 2;

                case "Mars":
                    return 3;

                case "Jupiter":
                    return 4;

                case "Saturn":
                    return 5;

                case "Uranus":
                    return 6;

                case "Neptune":
                    return 7;

            }
        }
        
        return 8;
    }
}
