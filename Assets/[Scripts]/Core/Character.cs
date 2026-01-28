using UnityEngine;

[RequireComponent(typeof(Animator), typeof(Rigidbody2D))]
public class Character : MonoBehaviour
{
    // private variables
    [Header("Character Stats")]
    [SerializeField] private float moveSpeed = 5;
    [SerializeField] private int maxHealth = 100;

    private int currentHealth;
    private bool isDead = false;
    protected Animator anim;
    protected Rigidbody2D rb;

    // public properties
    public float MoveSpeed
    {
        get {  return moveSpeed; }
    }

    public bool IsDead
    {
        get { return isDead; }
    }

    protected int CurrentHealth
    {
        get { return currentHealth; }
        set { currentHealth = Mathf.Clamp(value, 0, maxHealth); }
    }

    protected virtual void Awake()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        // level of protection
        if (IsDead)
        {
            return;
        }

        CurrentHealth -= amount;
        Debug.Log($"{gameObject.name} HP is now: {CurrentHealth}");
        if (CurrentHealth <= 0)
        {
            Die();
        }
    }

    protected void Die()
    {
        isDead = true;
        Debug.Log($"{gameObject.name} has died.");
    }
}
