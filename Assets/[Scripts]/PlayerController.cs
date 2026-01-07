using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // components
    private Rigidbody2D rb;
    private PlayerStats stats;

    // field variables
    private Vector2 moveInput;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        stats = new PlayerStats();
    }

    private void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    private void FixedUpdate()
    {
        ApplyMovement();
    }

    private void ApplyMovement()
    {
        float velocityX = moveInput.x;

        rb.linearVelocity = new Vector2(velocityX, rb.linearVelocity.y);
    }
}
