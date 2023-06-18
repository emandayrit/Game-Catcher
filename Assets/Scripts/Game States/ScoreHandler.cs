using TMPro;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    public int currentScore { get; private set; }

    private void OnEnable() =>Collectibles.coinCollect += UpdateScoreText;

    private void OnDisable() =>Collectibles.coinCollect -= UpdateScoreText;

    void UpdateScoreText(int _score)
    {
        currentScore += _score;
        scoreText.text = $"Score: {currentScore}";
    }
}
