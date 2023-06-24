using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Spawner : MonoBehaviour
{
    [SerializeField] List<GameObject> collectibles;
    public GameObject noBombPanel;
    public TMP_Text noBombTimerText;

    public int noBombs = 0;
    public float noBombsTime = 10f;
    private float currentNoBombsTime;

    float XSpawnRange = 7f;
    float YSpawnHeight = 8f;
    float SpawnInSeconds = 2f;

    private void Start()
    {
        InvokeRepeating("MakeObject", 0, SpawnInSeconds);
    }

    private void Update()
    {
        if (noBombPanel.activeInHierarchy)
        {
            
            noBombTimerText.text = $"No Bombs Until: {(int)(currentNoBombsTime -= Time.deltaTime)} seconds";
        }
    }

    GameObject MakeObject()
    {
        Vector3 _randPos = new Vector3(Random.Range(-XSpawnRange, XSpawnRange), YSpawnHeight, 0);
        int _randCount = Random.Range(0, collectibles.Count - noBombs);

        return Instantiate(collectibles[_randCount], _randPos, Quaternion.identity);
    }

    public void SetNoBombsUI()
    {
        currentNoBombsTime = noBombsTime;
        noBombPanel.SetActive(true);
        noBombs = 1;
        StartCoroutine(BeginNoBombTimerCoroutine(noBombsTime));
    }

    IEnumerator BeginNoBombTimerCoroutine(float _timeinSeconds)
    {   
        yield return new WaitForSeconds(_timeinSeconds);

        noBombs = 0;
        noBombPanel.SetActive(false);
    }
}
