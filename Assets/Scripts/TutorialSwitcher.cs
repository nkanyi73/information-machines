using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialSwitcher : MonoBehaviour
{
    public GameObject questionGameObject;
    public GameObject machineInfoGameObject;
    public GameObject[] machineHelpGameObjects;


    public void SwitchTutorial()
    {
        if (questionGameObject.activeSelf)
        {
            questionGameObject.SetActive(false);
            for(int i = 0; i < machineHelpGameObjects.Length; i++)
            {
                machineHelpGameObjects[i].SetActive(false);
            }
            
            machineInfoGameObject.SetActive(true);
        } else
        {
            questionGameObject.SetActive(true);
            machineInfoGameObject.SetActive(false);
        }
    }
   
}
