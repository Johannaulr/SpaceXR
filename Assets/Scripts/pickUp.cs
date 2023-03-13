using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
    //public Transform UI;
    public Transform Positions;

    /*private GameObject earthUI;
    private GameObject mercuryUI;
    private GameObject venusUI;
    private GameObject marsUI;
    private GameObject saturnUI;
    private GameObject uranusUI;
    private GameObject neptuneUI;
    private GameObject jupiterUI; */
    
    private GameObject earthGhost;
    private GameObject mercuryGhost;
    private GameObject venusGhost;
    private GameObject marsGhost;
    private GameObject saturnGhost;
    private GameObject uranusGhost;
    private GameObject neptuneGhost;
    private GameObject jupiterGhost;

    public AudioSource earthAudio;
    public AudioSource mercuryAudio;
    public AudioSource venusAudio;
    public AudioSource marsAudio;
    public AudioSource saturnAudio;
    public AudioSource uranusAudio;
    public AudioSource neptuneAudio;
    public AudioSource jupiterAudio;


    //private dialogWindowManager dialogWindowManager;

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

        /*earthUI = UI.Find("CanvasEarth").gameObject;
        mercuryUI = UI.Find("CanvasMercury").gameObject;
        venusUI = UI.Find("CanvasVenus").gameObject;
        marsUI = UI.Find("CanvasMars").gameObject;
        saturnUI = UI.Find("CanvasSaturn").gameObject;
        uranusUI = UI.Find("CanvasUranus").gameObject;
        neptuneUI = UI.Find("CanvasNeptune").gameObject;
        jupiterUI = UI.Find("CanvasJupiter").gameObject;*/

        earthGhost = Positions.Find("EarthPos/Ghost").gameObject;
        mercuryGhost = Positions.Find("MercuryPos/Ghost").gameObject;
        venusGhost = Positions.Find("VenusPos/Ghost").gameObject;
        marsGhost = Positions.Find("MarsPos/Ghost").gameObject;
        saturnGhost = Positions.Find("SaturnPos/Ghost").gameObject;
        uranusGhost = Positions.Find("UranusPos/Ghost").gameObject;
        neptuneGhost = Positions.Find("NeptunePos/Ghost").gameObject;
        jupiterGhost = Positions.Find("JupiterPos/Ghost").gameObject;

    }

    private void OnTriggerExit(Collider other)
    {

        string planetTag = other.tag;
        
        switch (planetTag)
        {

            case "Earth":
                earthGhost.SetActive(true);
                //dialogWindowManager = earthUI.GetComponent<dialogWindowManager>();
                //dialogWindowManager.open();
                earthAudio.Play();
                enabledButton.SetActive(false);
                disabledButton.SetActive(true);
                
                break;

            case "Mercury":
                mercuryGhost.SetActive(true);
                mercuryAudio.Play();
                //dialogWindowManager = mercuryUI.GetComponent<dialogWindowManager>();
                //dialogWindowManager.open();
                enabledButton.SetActive(false);
                disabledButton.SetActive(true);
                
                break;

            case "Venus":
                venusGhost.SetActive(true);
                venusAudio.Play();
                //dialogWindowManager = venusUI.GetComponent<dialogWindowManager>();
                //dialogWindowManager.open();
                enabledButton.SetActive(false);
                disabledButton.SetActive(true);
                
                break;

            case "Mars":
                marsGhost.SetActive(true);
                marsAudio.Play();
                //dialogWindowManager = marsUI.GetComponent<dialogWindowManager>();
                //dialogWindowManager.open();
                enabledButton.SetActive(false);
                disabledButton.SetActive(true);
                break;

            case "Saturn":
                saturnGhost.SetActive(true);
                saturnAudio.Play();
                //dialogWindowManager = saturnUI.GetComponent<dialogWindowManager>();
                //dialogWindowManager.open();
                enabledButton.SetActive(false);
                disabledButton.SetActive(true);
                break;

            case "Uranus":
                uranusGhost.SetActive(true);
                uranusAudio.Play();
                //dialogWindowManager = uranusUI.GetComponent<dialogWindowManager>();
                //dialogWindowManager.open();
                enabledButton.SetActive(false);
                disabledButton.SetActive(true);
                break;

            case "Neptune":
                neptuneGhost.SetActive(true);
                neptuneAudio.Play();
                //dialogWindowManager = neptuneUI.GetComponent<dialogWindowManager>();
                //dialogWindowManager.open();
                enabledButton.SetActive(false);
                disabledButton.SetActive(true);
                break;

            case "Jupiter":
                jupiterGhost.SetActive(true);
                jupiterAudio.Play();
                //dialogWindowManager = jupiterUI.GetComponent<dialogWindowManager>();
                //dialogWindowManager.open();
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
                earthAudio.Stop();
                //dialogWindowManager = earthUI.GetComponent<dialogWindowManager>();
                //dialogWindowManager.close();
                enabledButton.SetActive(true);
                disabledButton.SetActive(false);
                warningWindowManager.close();
                
                break;

            case "Mercury":
                mercuryGhost.SetActive(false);
                mercuryAudio.Stop();
                //dialogWindowManager = mercuryUI.GetComponent<dialogWindowManager>();
                //dialogWindowManager.close();
                enabledButton.SetActive(true);
                disabledButton.SetActive(false);
                warningWindowManager.close();
                
                break;

            case "Venus":
                venusGhost.SetActive(false);
                venusAudio.Stop();
                //dialogWindowManager = venusUI.GetComponent<dialogWindowManager>();
                //dialogWindowManager.close();
                enabledButton.SetActive(true);
                disabledButton.SetActive(false);
                warningWindowManager.close();
                
                break;

            case "Mars":
                marsGhost.SetActive(false);
                marsAudio.Stop();
                //dialogWindowManager = marsUI.GetComponent<dialogWindowManager>();
                //dialogWindowManager.close();
                enabledButton.SetActive(true);
                disabledButton.SetActive(false);
                warningWindowManager.close();
                break;

            case "Saturn":
                saturnGhost.SetActive(false);
                saturnAudio.Stop();
                //dialogWindowManager = saturnUI.GetComponent<dialogWindowManager>();
                //dialogWindowManager.close();
                enabledButton.SetActive(true);
                disabledButton.SetActive(false);
                warningWindowManager.close();
                break;

            case "Uranus":
                uranusGhost.SetActive(false);
                uranusAudio.Stop();
                //dialogWindowManager = uranusUI.GetComponent<dialogWindowManager>();
                //dialogWindowManager.close();
                enabledButton.SetActive(true);
                disabledButton.SetActive(false);
                warningWindowManager.close();
                break;

            case "Neptune":
                neptuneGhost.SetActive(false);
                neptuneAudio.Stop();
                //dialogWindowManager = neptuneUI.GetComponent<dialogWindowManager>();
                //dialogWindowManager.close();
                enabledButton.SetActive(true);
                disabledButton.SetActive(false);
                warningWindowManager.close();
                break;

            case "Jupiter":
                jupiterGhost.SetActive(false);
                jupiterAudio.Stop();
                //dialogWindowManager = jupiterUI.GetComponent<dialogWindowManager>();
                //dialogWindowManager.close();
                enabledButton.SetActive(true);
                disabledButton.SetActive(false);
                warningWindowManager.close();
                break;
        }
    }
}
