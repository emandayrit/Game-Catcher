using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField] int maxHP;
    [SerializeField] int currentHP;

    private void Start()
    {
        currentHP = maxHP;
    }

    void CheckCurrentHP()
    {
        if(currentHP == 0)
        {
            Debug.Log($"You died.");
        }
    }
}
