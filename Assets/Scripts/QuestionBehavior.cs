using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class ButtonBehavior : MonoBehaviour
{
    public UnityEvent onClick;

    private void OnMouseDown()
    {
        // This function is called when the object is clicked
        onClick.Invoke(); // Invoke the UnityEvent
    }
}