using UnityEngine;

public class GameOverHandler : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;
    public bool IsGameOver;

    public void GameOverCall()
    {
        IsGameOver = true;

        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ReturnNormalSpeed() => Time.timeScale = 1f;
}
