using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] List<GameObject> collectibleObjects;

    [SerializeField] float xSpawnRange;
    [SerializeField] float ySpawnHeight;
    [SerializeField] float spawnInSeconds;

    private void Start()
    {
        InvokeRepeating("MakeObject",0,spawnInSeconds);
    }

    GameObject MakeObject()
    {
        Vector3 _randPos = new Vector3(Random.Range(-xSpawnRange, xSpawnRange), ySpawnHeight, 0);
        int _randCount = Random.Range(0,collectibleObjects.Count);

        return Instantiate(collectibleObjects[_randCount], _randPos, Quaternion.identity);
    }
}
