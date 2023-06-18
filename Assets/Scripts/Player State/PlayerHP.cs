using TMPro;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField] int maxHP;
    [SerializeField] int currentHP;

    [SerializeField] TMP_Text hpText;
    private GameObject gameOver;

    private void Start()
    {
        currentHP = maxHP;
        UpdateHPText(currentHP);
        gameOver = GameObject.Find("/Game Status Manager");
    }

    private void OnEnable() => Collectibles.bombCollect += CheckCurrentHP;

    private void OnDisable() => Collectibles.bombCollect -= CheckCurrentHP;

    void CheckCurrentHP(int _hp)
    {
        currentHP -= _hp;
        UpdateHPText(currentHP);

        if (currentHP <= 0)
        {
            // Checks if game object exists then gets the GameOverManager component to activate the game over
            if (gameOver)
                gameOver.GetComponent<GameOverManager>().GameOverCall();
        }
    }

    public void UpdateHPText(int _hp)
    {
        hpText.text = $"HP: {_hp}";
    }
}
