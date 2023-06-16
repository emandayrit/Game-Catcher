using UnityEngine;

public class Collectibles : MonoBehaviour
{
    [SerializeField] int value;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //increase game score points if this a coin.
            //decrease player HP if this is a bomb.
        }

        Destroy(gameObject);
    }
       
}
