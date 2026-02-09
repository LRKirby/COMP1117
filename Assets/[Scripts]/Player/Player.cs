using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

[RequireComponent(typeof(PlayerInputHandler))]
public class Player : Character
{
    // jumping logic
    [Header("Movement Settings")]
    [SerializeField] private float jumpForce = 12;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private float groundCheckRadius = 0.2f;

    // components
    private PlayerInputHandler input;
    private bool isGrounded;
    private float currentSpeedModifier = 1;

    protected override void Awake()
    {
        base.Awake();
        // initialize
        input = GetComponent<PlayerInputHandler>();
    }

    private void Update()
    {
        // perform ground check
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        Debug.Log(isGrounded);

        anim.SetFloat("XVelocity", Mathf.Abs(rb.linearVelocity.x));

        // jumping
        anim.SetBool("IsGrounded", isGrounded);
        anim.SetFloat("YVelocity", rb.linearVelocity.y);

        // sprite flipping
        if (input.MoveInput.x != 0 && !isDead)
        {
            transform.localScale = new Vector3(Mathf.Sign(input.MoveInput.x), transform.localScale.y, 1);
        }
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
        float horizontalVelocity = input.MoveInput.x * MoveSpeed * currentSpeedModifier;

        rb.linearVelocity = new Vector2(horizontalVelocity, rb.linearVelocity.y);

        currentSpeedModifier = 1;
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        if (enemy != null)
        {
            if (rb.linearVelocity.y < 0)
            {
                enemy.TakeDamage(100);
            }
            else
            {
                TakeDamage(10);
            }
        }
    }

    public void ApplySpeedModifier(float speedModifier)
    {
        currentSpeedModifier = speedModifier;
    }

    public override void Die()
    {
        isDead = true;
        Debug.Log("Player has died");

        // add player specific death logic
        // set death animation
        // trigger death ui
        // level reset logic
    }
}
