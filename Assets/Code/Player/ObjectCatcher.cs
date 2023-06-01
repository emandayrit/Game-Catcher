using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCatcher : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Debug.Log($"Your score: {1}");
        }
        if (other.gameObject.CompareTag("Bomb"))
        {
            Debug.Log($"You catch a bomb! {true}");
        }
        Destroy(other.gameObject);
    }
}
