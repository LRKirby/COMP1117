using UnityEngine;

public class Enemy : Character
{
    [Header("Enemy Settings")]
    [SerializeField] private float patrolDistance = 4;
    private Vector2 startPos;
    private int direction = 1;
    private Rigidbody2D rb;

    protected override void Awake()
    {
        base.Awake();
        startPos = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (IsDead)
        {
            return;
        }
        HandleMovement();
    }

    private void HandleMovement()
    {
        float pos = transform.position.x - startPos.x;
        if (pos >= patrolDistance)
        {
            direction = -1;
        }
        else if (pos <= -patrolDistance)
        {
            direction = 1;
        }
        rb.linearVelocity = new Vector2(direction * MoveSpeed, 0);
    }
}
