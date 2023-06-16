using UnityEngine;

[CreateAssetMenu(fileName = "Collectible Value")]
public class CollectibleValues : ScriptableObject
{
    [SerializeField] protected int value;
    [SerializeField] protected ParticleSystem vfx;
}
