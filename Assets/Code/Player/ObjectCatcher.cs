using System;
using UnityEngine;


public class ObjectCatcher : MonoBehaviour
{
    [SerializeField] GameObject catcher;

    private void OnTriggerStay(Collider other)
    {
        
        Destroy(other.gameObject);
    }

}
