using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // components
    private Rigidbody2D rb;
    public PlayerStats stats;

    // field variables
    private Vector2 moveInput;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        stats = new PlayerStats(5, 100, 5);
        Debug.Log($"Move speed: {stats.MoveSpeed} Max health: {stats.MaxHealth} Jump force: {stats.JumpForce}");
    }

    private void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    private void OnJump(InputValue value)
    {
        float velocityY = stats.JumpForce;
        rb.linearVelocityY = velocityY;
    }

    private void FixedUpdate()
    {
        ApplyMovement();
    }

    private void ApplyMovement()
    {
        float velocityX = moveInput.x;

        rb.linearVelocity = new Vector2(velocityX * stats.MoveSpeed, rb.linearVelocity.y);
    }
}
