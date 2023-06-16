using TMPro;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField] int maxHP;
    [SerializeField] int currentHP;

    [SerializeField] TMP_Text hpText;

    private void Start()
    {
        currentHP = maxHP;
        UpdateHPText(currentHP);
    }

    private void OnEnable() => Collectibles.bombCollect += CheckCurrentHP;

    private void OnDisable() => Collectibles.bombCollect -= CheckCurrentHP;

    void CheckCurrentHP(int _hp)
    {
        currentHP -= _hp;
        UpdateHPText(currentHP);

        if (currentHP == 0)
        {
            Debug.Log($"You died.");
        }
    }

    public void UpdateHPText(int _hp)
    {
        hpText.text = $"HP: {_hp}";
    }
}
