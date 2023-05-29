using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float xSpeed, xInput;

    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(xInput * xSpeed, 0, 0) * Time.deltaTime;
    }
}
