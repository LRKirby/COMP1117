using System.Collections;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    private PlayerController player;
    private AbilityCooldowns cooldown;
    private float speed;

    private void Awake()
    {
        player = FindFirstObjectByType<PlayerController>();
        cooldown = FindFirstObjectByType<AbilityCooldowns>();
        speed = 5;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.stats.MoveSpeed += speed;
            Debug.Log(player.stats.MoveSpeed);
            cooldown.OriginalSpeed(player, player.stats.MoveSpeed - speed);
            Destroy(gameObject);
        }
    }
}
