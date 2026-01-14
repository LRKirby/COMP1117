using UnityEngine;

public class PlayerStats
{
    // private fields
    private float moveSpeed, jumpForce;
    private int maxHealth, currentHealth;

    // constructor
    public PlayerStats(float moveSpeed, int maxHealth, float jumpForce)
    {
        this.moveSpeed = moveSpeed;
        this.maxHealth = maxHealth;
        this.currentHealth = maxHealth;
        this.jumpForce = jumpForce;
    }

    // public properties
    public float MoveSpeed
    {
        get{return moveSpeed;}
        set
        {
            if (value > 20)
            {
                moveSpeed = 20;
            }
            else
            {
                moveSpeed = value;
            }
        }
    }

    public int MaxHealth
    {
        get{return maxHealth;}
    }

    public float JumpForce
    {
        get{return jumpForce;}
    }

    public int CurrentHealth
    {
        get{return currentHealth;}
        set
        {
            currentHealth = value;
            currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        }
    }
}
