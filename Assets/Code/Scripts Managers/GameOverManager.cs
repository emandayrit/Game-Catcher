using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public bool IsGameOver;

    [SerializeField] SpawnManager spawnManager;

    public void GameOverCall()
    {
        Debug.Log($"Game Over. You cannot move and coins will not spawn anymore.");
        IsGameOver = true;

        spawnManager.enabled = false;
    }
}
