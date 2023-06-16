using UnityEngine;

public class Collectibles : MonoBehaviour
{
    [SerializeField] CollectibleValues collectible;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //increase game score points if this a coin.
            //decrease player HP if this is a bomb.
            Debug.Log($"This collectible value is: {collectible.value}");
        }

        Destroy(gameObject);
    }
       
}
