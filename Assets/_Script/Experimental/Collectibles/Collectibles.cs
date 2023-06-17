using System;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    public static Action<int> coinCollect, bombCollect;
    [SerializeField] CollectibleValues collectible;

    void OnCollisionEnter(Collision _collider)
    {
        if (_collider.gameObject.CompareTag("Player"))
        {
            CheckCollisionTag(gameObject.tag, _collider);
            collectible.PlayVFX(_collider.gameObject.transform);
        }

        Destroy(gameObject);
    }

    void CheckCollisionTag(string _tag, Collision _collider)
    {
        switch (_tag)
        {
            case "Coin": SlowModifier(_collider); coinCollect?.Invoke(collectible.value); break;
            case "Bomb": bombCollect?.Invoke(collectible.value); break;
            default: break;
        }
    }

    //To Move Slow when cancering an object -vincent
    void SlowModifier(Collision _collider)
    {
        IMoveable _move = _collider.gameObject.GetComponent<IMoveable>();
        _move.MoveSlow(collectible.value);
    }


}
