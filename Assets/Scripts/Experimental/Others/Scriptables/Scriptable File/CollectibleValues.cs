using UnityEngine;

[CreateAssetMenu(fileName = "Collectible Value")]
public class CollectibleValues : ScriptableObject
{
    public int value;
    public float vfxTimer; 
    [SerializeField] GameObject vfx;

    public void PlayVFX(Transform parent)
    {
        GameObject _vfx = Instantiate(vfx,parent);
        _vfx.GetComponent<ParticleSystem>()?.Play();
        Destroy(_vfx,vfxTimer);
    }
}
