using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{
    const float SPEED_MULTIPLIER = 1000f;

    [SerializeField] float xSpeed;
    [SerializeField] GameObject player;

    void FixedUpdate()
    {
        Vector3 directionControl = new Vector3(Input.GetAxis("Horizontal") * xSpeed, 0, 0) * SPEED_MULTIPLIER;

        player.GetComponent<Rigidbody>().velocity = directionControl * Time.deltaTime;
    }
}
