using UnityEngine;
using UnityEngine.Events;

public class ObjectCatcher : MonoBehaviour
{
    [SerializeField] UnityEvent scoreCatcher, bombCatcher;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            scoreCatcher.Invoke();
        }
        if (other.gameObject.CompareTag("Bomb"))
        {
            bombCatcher.Invoke();
        }
        Destroy(other.gameObject);
    }

}
