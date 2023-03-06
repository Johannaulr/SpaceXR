using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using System.Threading;

public class serialController : MonoBehaviour
{

    public static SerialPort sp = new SerialPort("COM12", 9600);
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

    public static void Temp_Earth()
    {
        if (!sp.IsOpen)
        {
            sp.Open();
            sp.Write("E");
        }
        


        else
        {
            sp.Write("E");
        }
        Debug.Log("Earth Picked Up");
    }
    public static void Temp_Mercury()
    {
        if (!sp.IsOpen)
        {
            sp.Open();
            sp.Write("M");
        }



        else
        {
            sp.Write("M");
        }
        Debug.Log("Mercury Picked Up");
    }
    public static void Temp_Venus()
    {
        if (!sp.IsOpen)
        {
            sp.Open();
            sp.Write("V");
        }



        else
        {
            sp.Write("V");
        }
        Debug.Log("Venus Picked Up");
    }
    public static void Temp_Reset()
    {
        if (!sp.IsOpen)
        {
            sp.Open();
            sp.Write("empty");
        }



        else
        {
            sp.Write("empty");
        }
        Debug.Log("Planet put down");
    }


}

