using UnityEngine;

[CreateAssetMenu(fileName = "Player Stats")]
public class PlayerStats : ScriptableObject
{
    public int level;
    public int currentScore;
    public int scoreToLevel;

    public int maxHP;
    public int currentHP;

    public float moveSpeed;
    public GameObject player;

    public void InitializePlayer()
    {
        level = 1;
        currentScore = 0;
        scoreToLevel = 4;

        maxHP = 5;
        currentHP = maxHP;

        moveSpeed = 1000;
    }
}
