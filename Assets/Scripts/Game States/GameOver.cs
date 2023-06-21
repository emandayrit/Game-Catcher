using UnityEngine;

public class GameOver : MonoBehaviour
{
    public bool IsGameOver;
    [SerializeField] GameObject gameOverPanel;

    public void GameOverCall()
    {
        IsGameOver = true;

        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }
}
