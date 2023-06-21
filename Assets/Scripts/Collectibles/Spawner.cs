using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] List<GameObject> collectibles;

    float XSpawnRange = 7f;
    float YSpawnHeight = 8f;
    float SpawnInSeconds = 2f;

    private void Start()
    {
        InvokeRepeating("MakeObject", 0, SpawnInSeconds);
    }

    GameObject MakeObject()
    {
        Vector3 _randPos = new Vector3(Random.Range(-XSpawnRange, XSpawnRange), YSpawnHeight, 0);
        int _randCount = Random.Range(0, collectibles.Count);

        return Instantiate(collectibles[_randCount], _randPos, Quaternion.identity);
    }
}
