using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float xSpeed;


    void FixedUpdate()
    {
        Vector3 directionControl = new Vector3(Input.GetAxis("Horizontal") * xSpeed, 0, 0);
        GetComponent<Rigidbody>().velocity = directionControl * Time.deltaTime;
    }
}
