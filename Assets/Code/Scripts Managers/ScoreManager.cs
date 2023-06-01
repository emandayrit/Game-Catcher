using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] int score;

    public void ScoreCall()
    {
        Debug.Log($"Your score: {++score}");
    }
}
