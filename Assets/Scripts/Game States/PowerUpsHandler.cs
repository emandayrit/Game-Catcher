using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PowerUpsHandler : MonoBehaviour
{
    [SerializeField] PlayerStats player;
    [SerializeField] int totalPowerUps;

    [SerializeField] List<TMP_Text> uiTexts;
    public List<PowerUp> powerUps;

    public List<int> GetUniqueRandomNumber()
    {
        List<int> _digits = new List<int>();

        for (int i = 0; i < 3; i++)
        {
            int random = Random.Range(0, totalPowerUps);
            if (_digits.Contains(random))
            {
                --i;
            }
            else
            {
                _digits.Add(random);
            }
        }

        return _digits;
    }

    public void GetPowerUpByNumbers(int _num)
    {
        switch (_num)
        {
            case 0:
                MoreHPPowerUp(); break;
            case 1:
                ResetSpeedPowerUp(); break;
            case 2:
                BonusScorePowerUp(); break;
            case 3:
                NoBombsPowerUp(); break;
            default: break;
        }
    }

    void MoreHPPowerUp()
    {
        ++player.maxHP;
        player.currentHP = player.maxHP;
        uiTexts[0].text = $"HP: {player.currentHP}";
        uiTexts[1].text = $"Score: {player.currentScore}";
        Debug.Log($"You selected More HP +1 Max HP!");
    }

    void ResetSpeedPowerUp()
    {
        uiTexts[0].text = $"HP: {player.currentHP}";
        uiTexts[1].text = $"Score: {player.currentScore}";
        Debug.Log($"You selected Reset Speed!");
    }

    void BonusScorePowerUp()
    {
        player.currentScore += 3;
        uiTexts[0].text = $"HP: {player.currentHP}";
        uiTexts[1].text = $"Score: {player.currentScore}";
        Debug.Log($"You selected More Score +3!");
    }

    void NoBombsPowerUp()
    {
        //put something here to disable bombs dropping.
        Debug.Log("I'll do something next time. o_o But Good Job!");
    }

}
