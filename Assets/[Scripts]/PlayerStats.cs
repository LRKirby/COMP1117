using UnityEngine;

public class PlayerStats
{
    private int moveSpeed, maxHealth, jumpForce;

    public PlayerStats(int moveSpeed, int maxHealth, int jumpForce)
    {
        this.moveSpeed = moveSpeed;
        this.maxHealth = maxHealth;
        this.jumpForce = jumpForce;
    }

    public int MoveSpeed
    {
        get
        {
            return moveSpeed;
        }
        set
        {
            moveSpeed = value;
        }
    }

    public int MaxHealth
    {
        get
        {
            return maxHealth;
        }
    }

    public int JumpForce
    {
        get
        {
            return jumpForce;
        }
    }
}
