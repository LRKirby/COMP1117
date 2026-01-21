using System.Collections;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    [SerializeField] private PlayerController player;
    [SerializeField] private AbilityCooldowns cooldown;
    private float speed;

    private void Awake()
    {
        speed = 5;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //player.stats.MoveSpeed += speed;
            cooldown.OriginalSpeed(player, speed);
            Destroy(gameObject);
        }
    }
}
