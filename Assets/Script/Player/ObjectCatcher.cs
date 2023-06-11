using System;
using UnityEngine;


public class ObjectCatcher : MonoBehaviour
{
<<<<<<< HEAD
    [SerializeField] GameObject catcher;

    private void OnTriggerStay(Collider other)
    {
        
=======
    [SerializeField] UnityEvent coinTrigger;
    [SerializeField] UnityEvent bombTrigger;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            coinTrigger.Invoke();
        }

        if (other.gameObject.CompareTag("Bomb"))
        {
            bombTrigger.Invoke();
        }

>>>>>>> main
        Destroy(other.gameObject);
    }

}
