using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] int score;
    [SerializeField] Text scoreText;
    [SerializeField] ParticleSystem goldReceievedVFX;

    private void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score.ToString();
    }

    public void AddScore()
    {
        Debug.Log($"Your score: {++score}");
        scoreText.text = "Score: " + score.ToString();

        // Checks and plays if VFX prefab is exist
        if (goldReceievedVFX)
            goldReceievedVFX.Play();
    }
}
