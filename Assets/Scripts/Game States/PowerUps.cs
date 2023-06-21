using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    [SerializeField] PlayerStats player;
    [SerializeField] int totalPowerUps;

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

    void GetPowerUpByNumbers(int _num)
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
    }

    void ResetSpeedPowerUp()
    {
        player.moveSpeed = 1000;
    }

    void BonusScorePowerUp()
    {
        player.currentScore += 3;
    }

    void NoBombsPowerUp()
    {
        //put something here to disable bombs dropping.
        Debug.Log("I'll do something next time. o_o ");
    }

}
