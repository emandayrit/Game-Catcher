using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] PlayerStats playerStats;
    [SerializeField] GameObject playerParent;
    [SerializeField] GameOver GameOverHandler;

    private void Awake()
    {
        InitializePlayer();
        InitializeGame();
    }

    void InitializePlayer()
    {
        playerStats.ResetPlayerStats();
        
        GameObject _player = Instantiate(playerStats.player,playerParent.transform);
        _player.name = "Player";
    }

    void InitializeGame()
    {
        Time.timeScale = 1f;
        GameOverHandler.IsGameOver = false;
    }
}
