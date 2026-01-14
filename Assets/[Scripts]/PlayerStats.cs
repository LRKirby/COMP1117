using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class PlayerStats
{
    // private fields
    private float moveSpeed, jumpForce;
    private int maxHealth, currentHealth;

    // constructors
    // default constructor
    public PlayerStats()
    {
        moveSpeed = 5;
        jumpForce = 5;
        maxHealth = 100;
        currentHealth = maxHealth;
    }
    // overloaded constructor
    public PlayerStats(float moveSpeed, int maxHealth, float jumpForce)
    {
        this.moveSpeed = moveSpeed;
        this.maxHealth = maxHealth;
        currentHealth = maxHealth;
        this.jumpForce = jumpForce;
    }

    // public properties
    public float MoveSpeed
    {
        get{ return moveSpeed; }
        set
        {
            moveSpeed = Mathf.Clamp(value, 0, 20);
            Debug.Log($"Speed set to {moveSpeed}");
        }
    }

    public int MaxHealth
    {
        get{ return maxHealth; }
    }

    public float JumpForce
    {
        get{ return jumpForce; }
    }

    public int CurrentHealth
    {
        get{ return currentHealth; }
        set
        {
            currentHealth = Mathf.Clamp(value, 0, maxHealth);
            Debug.Log($"Health set to {currentHealth}");
        }
    }
}
