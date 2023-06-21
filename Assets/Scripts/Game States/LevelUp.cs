using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUp : MonoBehaviour
{
    [SerializeField] int currentLevel;
    [SerializeField] int scoreToLevel;
    [SerializeField] GameObject levelUpPanel;
    [SerializeField] PlayerStats player;

    void Update()
    {
        if(player.currentScore >= scoreToLevel)
        {
            IncreaseScoreToLevel();
            LevelUpPanelStart();
        }
    }

    void LevelUpPanelStart()
    {
        Time.timeScale = 0f;
        levelUpPanel.SetActive(true);
    }

    void IncreaseScoreToLevel()
    {
        ++currentLevel;
        scoreToLevel *= currentLevel;
    }


    public void Button1Pressed()
    {
        //HP increase (max or current?)
        Time.timeScale = 1f;
    }

    public void Button2Pressed()
    {
        //coin score multiplier?
        Time.timeScale = 1f;
    }

    public void Button3Pressed()
    {
        //player movement speed?
        Time.timeScale = 1f;
    }
}
