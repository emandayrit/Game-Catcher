using TMPro;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField] int maxHP;
    [SerializeField] int currentHP;
    [SerializeField] TMP_Text hpText;

    private GameOverHandler _gameOver;

    private void Start()
    {
        currentHP = maxHP;
        UpdateHPText(currentHP);
        _gameOver = GameObject.FindGameObjectWithTag("GameOver").GetComponent<GameOverHandler>();
    }

    private void OnEnable() => Collectibles.bombCollect += CheckCurrentHP;

    private void OnDisable() => Collectibles.bombCollect -= CheckCurrentHP;

    void CheckCurrentHP(int _hp)
    {
        UpdateHPText(currentHP -= _hp);

        if (currentHP <= 0)
        {
            _gameOver.GameOverCall();
        }
    }

    public void UpdateHPText(int _hp)
    {
        hpText.text = $"HP: {_hp}";
    }
}
