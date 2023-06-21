using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] PlayerStats player;
    [SerializeField] TMP_Text scoreText;

    private void OnEnable() =>Collectibles.coinCollect += UpdateScoreText;
    private void OnDisable() =>Collectibles.coinCollect -= UpdateScoreText;

    void UpdateScoreText(int _score)
    {
        scoreText.text = $"Score: {player.currentScore += _score}";
    }
}
