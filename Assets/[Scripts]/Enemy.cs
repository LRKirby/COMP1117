using UnityEngine;
using UnityEngine.InputSystem;

public class Enemy : MonoBehaviour
{
    [SerializeField] private PlayerController player;
    [SerializeField] private int damage;

    public void OnAttack(InputValue value)
    {
        if (value.isPressed)
        {
            player.TakeDamage(damage);
        }
    }
}
