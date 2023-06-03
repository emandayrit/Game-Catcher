using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public bool IsGameOver;

    [SerializeField] PlayerMovement playerMovement;
    [SerializeField] SpawnManager spawnManager;

    public void GameOverCall()
    {
        Debug.Log($"Game Over. You cannot move and coins will not spawn anymore.");
        IsGameOver = true;

        playerMovement.enabled = false;
        spawnManager.enabled = false;
    }
}
