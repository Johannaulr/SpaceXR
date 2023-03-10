using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
    public Transform UI;
    public Transform Positions;

    private GameObject earthUI;
    private GameObject earthGhost;

    private GameObject mercuryUI;
    private GameObject mercuryGhost;

    private GameObject venusUI;
    private GameObject venusGhost;

    private GameObject marsUI;
    private GameObject marsGhost;

    private GameObject saturnUI;
    private GameObject saturnGhost;

    private GameObject uranusUI;
    private GameObject uranusGhost;

    private GameObject neptuneUI;
    private GameObject neptuneGhost;

    private GameObject jupiterUI;
    private GameObject jupiterGhost;

    private dialogWindowManager dialogWindowManager;

    private warningWindowManager warningWindowManager;
    private GameObject windowWarning;

    public GameObject enabledButton;
    public GameObject disabledButton;

    

    // Start is called before the first frame update
    void Start()
    {
        windowWarning = GameObject.Find("WarningUI");
        warningWindowManager = windowWarning.GetComponent<warningWindowManager>();

        enabledButton.SetActive(true);
        disabledButton.SetActive(false);

        earthUI = UI.Find("CanvasEarth").gameObject;
        earthGhost = Positions.Find("EarthPos/Ghost").gameObject;

        mercuryUI = UI.Find("CanvasMercury").gameObject;
        mercuryGhost = Positions.Find("MercuryPos/Ghost").gameObject;

        venusUI = UI.Find("CanvasVenus").gameObject;
        venusGhost = Positions.Find("VenusPos/Ghost").gameObject;

        marsUI = UI.Find("CanvasMars").gameObject;
        marsGhost = Positions.Find("MarsPos/Ghost").gameObject;

        saturnUI = UI.Find("CanvasSaturn").gameObject;
        saturnGhost = Positions.Find("SaturnPos/Ghost").gameObject;

        uranusUI = UI.Find("CanvasUranus").gameObject;
        uranusGhost = Positions.Find("UranusPos/Ghost").gameObject;

        neptuneUI = UI.Find("CanvasNeptune").gameObject;
        neptuneGhost = Positions.Find("NeptunePos/Ghost").gameObject;

        jupiterUI = UI.Find("CanvasJupiter").gameObject;
        jupiterGhost = Positions.Find("JupiterPos/Ghost").gameObject;

    }

    private void OnTriggerExit(Collider other)
    {

        string planetTag = other.tag;
        
        switch (planetTag)
        {

            case "Earth":
                earthGhost.SetActive(true);
                dialogWindowManager = earthUI.GetComponent<dialogWindowManager>();
                dialogWindowManager.open();
                enabledButton.SetActive(false);
                disabledButton.SetActive(true);
                //serialController.Temp_Earth();
                serialController.Temp_Reset();
                break;

            case "Mercury":
                mercuryGhost.SetActive(true);
                dialogWindowManager = mercuryUI.GetComponent<dialogWindowManager>();
                dialogWindowManager.open();
                enabledButton.SetActive(false);
                disabledButton.SetActive(true);
                //serialController.Temp_Mercury();
                serialController.Temp_Reset();
                break;

            case "Venus":
                venusGhost.SetActive(true);
                dialogWindowManager = venusUI.GetComponent<dialogWindowManager>();
                dialogWindowManager.open();
                enabledButton.SetActive(false);
                disabledButton.SetActive(true);
                // serialController.Temp_Venus();
                serialController.Temp_Reset();
                break;

            case "Mars":
                marsGhost.SetActive(true);
                dialogWindowManager = marsUI.GetComponent<dialogWindowManager>();
                dialogWindowManager.open();
                enabledButton.SetActive(false);
                disabledButton.SetActive(true);
                break;

            case "Saturn":
                saturnGhost.SetActive(true);
                dialogWindowManager = saturnUI.GetComponent<dialogWindowManager>();
                dialogWindowManager.open();
                enabledButton.SetActive(false);
                disabledButton.SetActive(true);
                break;

            case "Uranus":
                uranusGhost.SetActive(true);
                dialogWindowManager = uranusUI.GetComponent<dialogWindowManager>();
                dialogWindowManager.open();
                enabledButton.SetActive(false);
                disabledButton.SetActive(true);
                break;

            case "Neptune":
                neptuneGhost.SetActive(true);
                dialogWindowManager = neptuneUI.GetComponent<dialogWindowManager>();
                dialogWindowManager.open();
                enabledButton.SetActive(false);
                disabledButton.SetActive(true);
                break;

            case "Jupiter":
                jupiterGhost.SetActive(true);
                dialogWindowManager = jupiterUI.GetComponent<dialogWindowManager>();
                dialogWindowManager.open();
                enabledButton.SetActive(false);
                disabledButton.SetActive(true);
                break;

        }
    }

    private void OnTriggerEnter(Collider other)
    {

        //serialController.Temp_Reset();

        string planetTag = other.tag;

        switch (planetTag) {

            case "Earth":
                earthGhost.SetActive(false);
                dialogWindowManager = earthUI.GetComponent<dialogWindowManager>();
                dialogWindowManager.close();
                enabledButton.SetActive(true);
                disabledButton.SetActive(false);
                warningWindowManager.close();
                serialController.Temp_Earth();
                break;

            case "Mercury":
                mercuryGhost.SetActive(false);
                dialogWindowManager = mercuryUI.GetComponent<dialogWindowManager>();
                dialogWindowManager.close();
                enabledButton.SetActive(true);
                disabledButton.SetActive(false);
                warningWindowManager.close();
                serialController.Temp_Mercury();
                break;

            case "Venus":
                venusGhost.SetActive(false);
                dialogWindowManager = venusUI.GetComponent<dialogWindowManager>();
                dialogWindowManager.close();
                enabledButton.SetActive(true);
                disabledButton.SetActive(false);
                warningWindowManager.close();
                serialController.Temp_Venus();
                break;

            case "Mars":
                marsGhost.SetActive(false);
                dialogWindowManager = marsUI.GetComponent<dialogWindowManager>();
                dialogWindowManager.close();
                enabledButton.SetActive(true);
                disabledButton.SetActive(false);
                warningWindowManager.close();
                break;

            case "Saturn":
                saturnGhost.SetActive(false);
                dialogWindowManager = saturnUI.GetComponent<dialogWindowManager>();
                dialogWindowManager.close();
                enabledButton.SetActive(true);
                disabledButton.SetActive(false);
                warningWindowManager.close();
                break;

            case "Uranus":
                uranusGhost.SetActive(false);
                dialogWindowManager = uranusUI.GetComponent<dialogWindowManager>();
                dialogWindowManager.close();
                enabledButton.SetActive(true);
                disabledButton.SetActive(false);
                warningWindowManager.close();
                break;

            case "Neptune":
                neptuneGhost.SetActive(false);
                dialogWindowManager = neptuneUI.GetComponent<dialogWindowManager>();
                dialogWindowManager.close();
                enabledButton.SetActive(true);
                disabledButton.SetActive(false);
                warningWindowManager.close();
                break;

            case "Jupiter":
                jupiterGhost.SetActive(false);
                dialogWindowManager = jupiterUI.GetComponent<dialogWindowManager>();
                dialogWindowManager.close();
                enabledButton.SetActive(true);
                disabledButton.SetActive(false);
                warningWindowManager.close();
                break;
        }
    }
}
