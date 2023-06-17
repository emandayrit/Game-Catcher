using UnityEngine;

public class PlayerMovement : MonoBehaviour, ICollectable
{
    [SerializeField] float xSpeed;

    public void MoveSlow(int value)
    {
        xSpeed /= value; 
    }

    void FixedUpdate()
    {
        Vector3 directionControl = new Vector3(Input.GetAxis("Horizontal") * xSpeed, 0, 0);
        GetComponent<Rigidbody>().velocity = directionControl * Time.deltaTime;
    }

}
