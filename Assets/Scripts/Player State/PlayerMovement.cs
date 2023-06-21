using UnityEngine;

public class PlayerMovement : MonoBehaviour, IMoveable
{
    [SerializeField] PlayerStats stats;

    void FixedUpdate()
    {
        Vector3 directionControl = new Vector3(Input.GetAxis("Horizontal") * stats.moveSpeed, 0, 0);
        GetComponent<Rigidbody>().velocity = directionControl * Time.deltaTime;
    }

    public void MoveSlow(int value)
    {
        stats.moveSpeed /= 1.05f; 
    }

}
