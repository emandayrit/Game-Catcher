using UnityEngine;
using UnityEngine.Events;

public class ObjectCatcher : MonoBehaviour
{
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

        Destroy(other.gameObject);
    }

}
