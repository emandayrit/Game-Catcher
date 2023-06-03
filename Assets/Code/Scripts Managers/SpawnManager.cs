using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] List<GameObject> collectibleObjects;

    [SerializeField] float spawnXRange;
    [SerializeField] float spawnYLimiter;
    [SerializeField] float prefabSpawnInSeconds;

    private void Start()
    {
        StartCoroutine("ISpawnObject");
    }

    IEnumerator ISpawnObject()
    {
        while (!GetComponent<GameOverManager>().IsGameOver)
        {
            yield return GetObject(GetRandomPrefab());
            yield return new WaitForSeconds(prefabSpawnInSeconds);
        }
    }

    GameObject GetRandomPrefab()
    {
        int _percentageChecker = Random.Range(0, collectibleObjects.Count);
        return collectibleObjects[_percentageChecker];
    }

    GameObject GetObject(GameObject returnedPrefab)
    {
        float randomXRange = Random.Range(-spawnXRange, spawnXRange);
        return Instantiate(returnedPrefab,new Vector3(randomXRange,spawnYLimiter,0),Quaternion.identity);
    }

}
