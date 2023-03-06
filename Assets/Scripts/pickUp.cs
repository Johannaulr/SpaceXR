using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
    public Transform UI;
    private GameObject EarthUI;
    private GameObject MercuryUI;
    private GameObject VenusUI;
    private GameObject MarsUI;
    private GameObject SaturnUI;
    private GameObject UranusUI;
    private GameObject NeptuneUI;
    private GameObject JupiterUI;

    // Start is called before the first frame update
    void Start()
    {
        EarthUI = UI.Find("CanvasEarth").gameObject;
        MercuryUI = UI.Find("CanvasMercury").gameObject;
        VenusUI = UI.Find("CanvasVenus").gameObject;
        MarsUI = UI.Find("CanvasMars").gameObject;
        SaturnUI = UI.Find("CanvasSaturn").gameObject;
        UranusUI = UI.Find("CanvasUranus").gameObject;
        NeptuneUI = UI.Find("CanvasNeptune").gameObject;
        JupiterUI = UI.Find("CanvasJupiter").gameObject;

    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        string planetTag = other.tag;
        
        switch (planetTag)
        {

            case "Earth": 
                EarthUI.SetActive(true);
                serialController.Temp_Earth();
                break;

            case "Mercury":
                MercuryUI.SetActive(true);
                serialController.Temp_Mercury();
                break;

            case "Venus":
                VenusUI.SetActive(true);
                serialController.Temp_Venus();
                break;

            case "Mars":
                MarsUI.SetActive(true);
                break;

            case "Saturn":
                SaturnUI.SetActive(true);
                break;

            case "Uranus":
                UranusUI.SetActive(true);
                break;

            case "Neptune":
                NeptuneUI.SetActive(true);
                break;

            case "Jupiter":
                JupiterUI.SetActive(true);
                break;

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        serialController.Temp_Reset();
        string planetTag = other.tag;

        switch (planetTag) {

            case "Earth":
                EarthUI.SetActive(false);
                break;

            case "Mercury":
                MercuryUI.SetActive(false);
                break;

            case "Venus":
                VenusUI.SetActive(false);
                break;

            case "Mars":
                MarsUI.SetActive(false);
                break;

            case "Saturn":
                SaturnUI.SetActive(false);
                break;

            case "Uranus":
                UranusUI.SetActive(false);
                break;

            case "Neptune":
                NeptuneUI.SetActive(false);
                break;

            case "Jupiter":
                JupiterUI.SetActive(false);
                break;
        }
    }
        
}
