using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

[RequireComponent(typeof(PlayerInputHandler), typeof(Rigidbody2D))]
public class PlayerController : Character
{
    // jumping logic
    [Header("Movement Settings")]
    [SerializeField] private float jumpForce = 12;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private float groundCheckRadius = 0.2f;

    // components
    private Rigidbody2D rb;
    private PlayerInputHandler input;
    private bool isGrounded;

    protected override void Awake()
    {
        base.Awake();
        // initialize
        rb = GetComponent<Rigidbody2D>();
        input = GetComponent<PlayerInputHandler>();
    }

    private void Update()
    {
        // perform ground check
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        Debug.Log(isGrounded);
    }

    private void FixedUpdate()
    {
        if (IsDead)
        {
            return;
        }

        HandleMovement();
        HandleJump();
    }

    private void HandleMovement()
    {
        float horizontalVelocity = input.MoveInput.x * MoveSpeed;

        rb.linearVelocity = new Vector2(horizontalVelocity, rb.linearVelocity.y);
    }

    private void HandleJump()
    {
        if (input.JumpTriggered && isGrounded)
        {
            ApplyJumpForce();
        }
    }

    private void ApplyJumpForce()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0);

        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
