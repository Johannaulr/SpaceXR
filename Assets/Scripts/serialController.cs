using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.IO.Ports;
using System.Threading;

public class serialController : MonoBehaviour
{
    string ConnectionText;
    public static SerialPort sp;
    
    // Start is called before the first frame update
    void Start()
    {
        ConnectToPort();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ConnectToPort()
    {
        string port = "COM12";

        try
        {
            sp = new SerialPort(port, 9600);
            sp.Open();
            ConnectionText = "Connected to {port}";
            Debug.Log(ConnectionText);
        }
        catch(Exception e)
        {
            ConnectionText = e.Message;
        }
    }

    public void Disconnect()
    {
        if (sp != null)
        {
            if (sp.IsOpen)
            {
                sp.Close();
                print("Closing port");
            }
            sp.Dispose();
            sp = null;
            if (ConnectionText != null)
            {
                ConnectionText = "";
            }
            Debug.Log("Disconnected");
        }
    }
    

    void OnApplicationQuit()
    {
        Disconnect();
        
    }

    public static void Temp_Earth()
    {
        char[] outBuffer = new char[1];
        outBuffer[0] = 'e';
        sp.Write(outBuffer, 0, 1);
        Debug.Log("Earth Picked Up");
    }
    public static void Temp_Mercury()
    {
        char[] outBuffer = new char[1];
        outBuffer[0] = 'm';
        sp.Write(outBuffer, 0, 1);
        Debug.Log("Mercury Picked Up");
    }
    public static void Temp_Venus()
    {
        char[] outBuffer = new char[1];
        outBuffer[0] = 'v';
        sp.Write(outBuffer, 0, 1);
        Debug.Log("Venus Picked Up");
    }
    public static void Temp_Reset()
    {
        char[] outBuffer = new char[1];
        outBuffer[0] = 'n';
        sp.Write(outBuffer, 0, 1);
        Debug.Log("Planet put down");
    }


}

