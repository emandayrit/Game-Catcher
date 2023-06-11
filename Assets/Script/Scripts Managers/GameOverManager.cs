using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public bool IsGameOver;

<<<<<<< HEAD
    [SerializeField] HorizontalMovement playerMovement;
    [SerializeField] SpawnManager spawnManager;
=======
>>>>>>> main

    public void GameOverCall()
    {
        Debug.Log($"Game Over. You cannot move and coins will not spawn anymore.");
        IsGameOver = true;
    }
}
