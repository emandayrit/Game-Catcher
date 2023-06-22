using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelUp : MonoBehaviour
{
    [SerializeField] GameObject levelUpPanel;
    [SerializeField] PowerUpsHandler powerUps;
    [SerializeField] PlayerStats player;

    private List<int> powerUpNumber;

    [SerializeField] List<TMP_Text> powerUpNames;
    [SerializeField] List<Image> powerUpImages;

    private void Start()
    {
        powerUpNumber = new List<int>();
    }

    void Update()
    {
        if(player.currentScore >= player.scoreToLevel)
        {
            PauseHandler(true, 0);
            player.UpdateStatsOnLevelUp();
            ChangePowerUpsUI();
        }
    }

    #region Buttons Stuffs
    public void PowerUpButtonOne()
    {
        powerUps.GetPowerUpByNumbers(powerUpNumber[0]);
        PauseHandler(false, 1);
    }

    public void PowerUpButtonTwo()
    {
        powerUps.GetPowerUpByNumbers(powerUpNumber[1]);
        PauseHandler(false, 1);
    }

    public void PowerUpButtonThree()
    {
        powerUps.GetPowerUpByNumbers(powerUpNumber[2]);
        PauseHandler(false, 1);
    }
    #endregion

    #region Initialization Stuffs
    void PauseHandler(bool _status, int _time)
    {
        levelUpPanel.SetActive(_status);
        Time.timeScale = _time;
    }

    void ChangePowerUpsUI()
    {
        powerUpNumber.Clear();
        powerUpNumber = powerUps.GetUniqueRandomNumber();

        for (int i = 0; i < 3; i++)
        {
            powerUpNames[i].text = powerUps.powerUps[powerUpNumber[i]].powerUpName;
            powerUpImages[i].sprite = powerUps.powerUps[powerUpNumber[i]].powerUpImage;
        }
    }
    #endregion
}
