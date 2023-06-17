using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] GameObject _gameOverPanel;
    public bool IsGameOver;


    public void GameOverCall()
    {
        Debug.Log($"Game Over. You cannot move and coins will not spawn anymore.");
        IsGameOver = true;

        // ============================
        // Insert Game Over codes below
        // ============================

        // Enables the gameover panel and freezes time
        _gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }
}
