using UnityEngine;

public class PlayerCollector : MonoBehaviour
{
    [SerializeField] CapsuleCollider playerColliderCollector;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"{collision.gameObject.name} touches {playerColliderCollector.name}");
    }
}
