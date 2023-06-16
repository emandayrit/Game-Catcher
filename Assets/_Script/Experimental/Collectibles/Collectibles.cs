using System.Collections;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    [SerializeField] CollectibleValues collectible;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //increase game score points if this a coin.
            //decrease player HP if this is a bomb.
            collectible.PlayVFX(other.gameObject.transform);
        }

        Destroy(gameObject);
    }
}
