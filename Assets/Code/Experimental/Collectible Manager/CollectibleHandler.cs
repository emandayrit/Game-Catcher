using UnityEngine;

enum CollectibleType { good,bad }
public class CollectibleHandler : MonoBehaviour
{
    [SerializeField] int collectibleValue;
    [SerializeField] CollectibleType collectibleType;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //increase game score points if this a coin.
            //decrease player HP if this is a bomb.
            Debug.Log($"You caught {collectibleType} and it gives you {collectibleValue} points.");
        }

        Destroy(gameObject);
    }
       
}
