using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using UnityEngine;

public class Motor : MonoBehaviour
{
    SerialPort port;
    // Start is called before the first frame update
    void Start()
    {
        port = new SerialPort();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    double getRotation() {


        return 0;
    }
}
