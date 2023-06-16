using TMPro;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    [SerializeField] int currentScore;

    private void OnEnable()
    {
        Collectibles.coinCollect += UpdateScoreText;
    }

    void UpdateScoreText(int score)
    {
        currentScore += score;
        scoreText.text = $"Score: {currentScore}";
    }
}
