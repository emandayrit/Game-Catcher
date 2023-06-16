using UnityEngine;

public class PlayerCollector : MonoBehaviour
{
    [SerializeField] CapsuleCollider playerColliderCollector;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"{other.name} touches {playerColliderCollector.name}");
    }
}
