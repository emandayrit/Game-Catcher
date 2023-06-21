using TMPro;
using UnityEngine;

public class HealthPoints : MonoBehaviour
{
    [SerializeField] PlayerStats player;
    [SerializeField] GameOver gameOver;

    [SerializeField] TMP_Text hpText;

    private void Start()
    {
        hpText.text = $"HP: {player.currentHP}";
    }

    private void OnEnable() => Collectibles.bombCollect += UpdateCurrentHP;
    private void OnDisable() => Collectibles.bombCollect -= UpdateCurrentHP;

    void UpdateCurrentHP(int _hp)
    {
        hpText.text = $"HP: {player.currentHP -= _hp}";

        if (player.currentHP <= 0)
        {
            gameOver.GameOverCall();
        }
    }

}
