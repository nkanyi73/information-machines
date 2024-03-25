using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera ARCamera;
    public Camera[] cameras;
    private int currentCameraIndex;

    void Start()
    {
        //// Disable all cameras except the first one
        //for (int i = 1; i < cameras.Length; i++)
        //{
        //    cameras[i].gameObject.SetActive(false);
        //}
    }

    public void SwitchToARMode ()
    {
        for(int i = 0; i < cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(false);
        }
        ARCamera.gameObject.SetActive(true);
    }

    public void SwitchCamera()
    {
        if (ARCamera.gameObject.activeSelf)
        {
            ARCamera.gameObject.SetActive(false);
            cameras[0].gameObject.SetActive(true);
        } 
        else
        {
            for (int i = 0; i < cameras.Length; i++)
            {
                cameras[i].gameObject.SetActive(false);
            }
            // Move to the next camera
            currentCameraIndex++;
            if (currentCameraIndex >= cameras.Length)
            {
                currentCameraIndex = 0; // Loop back to the first camera
            }

            // Enable the new current camera
            cameras[currentCameraIndex].gameObject.SetActive(true);
        }

        
    }
}
