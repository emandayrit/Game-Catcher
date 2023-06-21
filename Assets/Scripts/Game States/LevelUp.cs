using System.Collections.Generic;
using UnityEngine;

public class LevelUp : MonoBehaviour
{
    [SerializeField] GameObject levelUpPanel;
    [SerializeField] PowerUps powerUps;
    [SerializeField] PlayerStats player;

    private List<int> powerUpNumber;

    void Update()
    {
        if(player.currentScore >= player.scoreToLevel)
        {
            StartLevelUp();
        }
    }

    void GetRandomPowerUps()
    {
        //get the 3 random power ups to show in the level up panel/UI.
        powerUpNumber = powerUps.GetUniqueRandomNumber();
        //How can I make this work?
        //I wanted to use this List of int numbers from powerUpNumber to return the designated
    }

    #region Buttons Stuffs
    public void PowerUpButtonOne()
    {
        Debug.Log($"You Selected Power up 1!");
        //HP increase (max or current?)
        InitializeLevelUpUI(false, 1);
    }

    public void PowerUpButtonTwo()
    {
        Debug.Log($"You Selected Power up 2!");
        //coin score multiplier?
        InitializeLevelUpUI(false, 1);
    }

    public void PowerUpButtonThree()
    {
        Debug.Log($"You Selected Power up 3!");
        //player movement speed?
        InitializeLevelUpUI(false, 1);
    }
    #endregion

    #region Initialization Stuffs
    void StartLevelUp()
    {
        InitializeLevelUpUI(true, 0);

        player.UpdateStatsOnLevelUp();
    }

    void InitializeLevelUpUI(bool _status, int _time)
    {
        levelUpPanel.SetActive(_status);
        Time.timeScale = _time;
    }
    #endregion
}
