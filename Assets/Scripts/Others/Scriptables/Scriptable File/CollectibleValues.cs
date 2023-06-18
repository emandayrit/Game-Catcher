using UnityEngine;

[CreateAssetMenu(fileName = "Collectible Value")]
public class CollectibleValues : ScriptableObject
{
    public int value;
    public float vfxTimer; 
    [SerializeField] GameObject vfx;
    [SerializeField] AudioClip clip;

    public void PlayVFX(Transform parent)
    {
        GameObject _vfx = Instantiate(vfx,parent);
        PlaySFX();
        _vfx.GetComponent<ParticleSystem>()?.Play();
        Destroy(_vfx,vfxTimer);
    }

    void PlaySFX()
    {
        AudioSource source = GameObject.Find("SFX").GetComponent<AudioSource>();
        source.clip = clip;
        source.Play();
    }
}
