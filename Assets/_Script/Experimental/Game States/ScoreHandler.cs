using TMPro;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;

    void UpdateScoreText()
    {
        scoreText.text = $"Score: {2}";
    }
}
