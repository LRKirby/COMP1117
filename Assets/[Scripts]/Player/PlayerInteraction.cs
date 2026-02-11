using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteraction : MonoBehaviour
{
    [Header("Interaction Settings")]
    [SerializeField] private float interactRange = 1.5f;
    [SerializeField] private LayerMask interactableLayer;

    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            PerformInteraction();
        }
    }

    private void PerformInteraction()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, interactRange, interactableLayer);

        if (hit != null)
        {
            if (hit.TryGetComponent(out IInteractable interactable))
            {
                interactable.Interact();
                Debug.Log($"Interacted with {hit.name}");
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, interactRange);
    }
}
