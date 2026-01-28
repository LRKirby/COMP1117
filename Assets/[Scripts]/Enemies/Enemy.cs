using UnityEngine;

public class Enemy : Character
{
    [Header("Enemy Settings")]
    [SerializeField] private float patrolDistance = 5;
    private Vector2 startPos;
    private int direction = -1;

    protected override void Awake()
    {
        base.Awake();
        startPos = transform.position;
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
        // movement bounds
        float leftBound = startPos.x - patrolDistance;
        float rightBound = startPos.x + patrolDistance;

        // move enemy
        transform.Translate(Vector2.right * direction * MoveSpeed * Time.deltaTime);

        // flip enemy
        if (transform.position.x >= rightBound)
        {
            direction = -1;
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (transform.position.x <= leftBound)
        {
            direction = 1;
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
