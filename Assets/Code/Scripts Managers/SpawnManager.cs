using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject coinPrefab;
    [SerializeField] GameObject bombPrefab;

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
            yield return MakeObject();
            yield return new WaitForSeconds(prefabSpawnInSeconds);
        }
    }
    GameObject MakeObject()
    {
        float randomXRange = Random.Range(-spawnXRange, spawnXRange);
        return Instantiate(coinPrefab,new Vector3(randomXRange,spawnYLimiter,0),Quaternion.identity);
    }
}
