using UnityEngine;
using TMPro;

public class Level : MonoBehaviour
{
    [SerializeField] PlayerStats player;
    [SerializeField] TMP_Text levelText;

    void Update()
    {
        levelText.text = $"Lv {player.level}";
    }
}
