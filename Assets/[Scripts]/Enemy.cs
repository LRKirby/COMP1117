using UnityEngine;

public class Enemy : Character
{
    [Header("Enemy Settings")]
    [SerializeField] private float patrolDistance = 5;

    protected override void Awake()
    {
        base.Awake();
    }
}
