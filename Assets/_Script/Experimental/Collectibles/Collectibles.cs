using System;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    public static Action<int> coinCollect, bombCollect;
    [SerializeField] CollectibleValues collectible;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            CheckCollisionTag(gameObject.tag);
            collectible.PlayVFX(other.gameObject.transform);
        }

        Destroy(gameObject);
    }

    void CheckCollisionTag(string _tag)
    {
        switch (_tag)
        {
            case "Coin": coinCollect?.Invoke(collectible.value); break;
            case "Bomb": bombCollect?.Invoke(collectible.value); break;
            default: break;
        }
    }

}
