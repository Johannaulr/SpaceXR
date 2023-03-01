using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using System.Threading;

public class serialController : MonoBehaviour
{

    public static SerialPort sp = new SerialPort("COM10", 9600);
    // Start is called before the first frame update
    void Start()
    {
        OpenConnection();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenConnection()
    {
        if (sp != null)
        {
            if (sp.IsOpen)
            {
                sp.Close();
                print("Closing port");
            }
            else
            {
                sp.Open();
                sp.ReadTimeout = 100;
                print("Port open");
            }
        }
        else
        {
            if (sp.IsOpen)
            {
                print("Port is already open");
            }
            else
            {
                print("Port == null");
            }
        }

    }

    void OnApplicationQuit()
    {
        sp.Close();
    }

    public static void turnOnLED()
    {
        if (!sp.IsOpen)
        {
            sp.Open();
            sp.Write("y");
        }

        else
        {
            sp.Write("y");
        }

    }

    public static void turnOffLED()
    {
        if (!sp.IsOpen)
        {
            sp.Open();
            sp.Write("n");
        }

        else
        {
            sp.Write("n");
        }

    }
}

