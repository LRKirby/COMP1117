using UnityEngine;

public class Lava : MonoBehaviour
{
    private Player player;
    [SerializeField] private int damage;

    private void Awake()
    {
        player = FindFirstObjectByType<Player>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.TakeDamage(damage);
        }
    }
}
