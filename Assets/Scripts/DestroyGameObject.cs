using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObject : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.LogError(other.gameObject.name);

        Destroy(other.gameObject);
    }
}
