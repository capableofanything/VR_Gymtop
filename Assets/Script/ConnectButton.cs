using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectButton : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C)) 
        {
            Managers.Bluetooth.Connect();
        }
        if (Managers.Bluetooth.GetOnConnected())
        {
            Managers.Resource.Destroy(gameObject);
        }
    }
}