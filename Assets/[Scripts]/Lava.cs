using UnityEngine;

public class Lava : MonoBehaviour
{
    private PlayerController player;
    [SerializeField] private int damage;

    private void Awake()
    {
        player = FindFirstObjectByType<PlayerController>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.TakeDamage(damage);
        }
    }
}
