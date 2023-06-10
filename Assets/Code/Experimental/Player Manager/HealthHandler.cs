using UnityEngine;

public class HealthHandler : MonoBehaviour
{
    [SerializeField] int currentHP;
    [SerializeField] int maxHP;

    void CurrentHPZero()
    {
        if(currentHP == 0)
        {
            //trigger the game over script
        }
    }
}
