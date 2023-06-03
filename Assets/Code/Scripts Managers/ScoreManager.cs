using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] int score;
    [SerializeField] Text scoreText;

    private void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score.ToString();
    }

    public void ScoreCall()
    {
        Debug.Log($"Your score: {++score}");
        scoreText.text = "Score: " + score.ToString();
    }
}
