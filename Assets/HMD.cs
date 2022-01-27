using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HMD : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Is Device Active " + XRSettings.isDeviceActive);
        Debug.Log("Device Name is : " + XRSettings.loadedDeviceName);

        if (!XRSettings.isDeviceActive)
        {
            Debug.Log("No Headset plugged");
        }
        else if (XRSettings.isDeviceActive && (XRSettings.loadedDeviceName == "HMD"
            || XRSettings.loadedDeviceName == "MockHMDDisplay"))
        {
            Debug.Log("Using MOCK HMD");
        }

        else
        {
            Debug.Log("We Have a headset " + XRSettings.loadedDeviceName);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
