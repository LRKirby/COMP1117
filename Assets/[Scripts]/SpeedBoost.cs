using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    private PlayerController player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

        }
    }
}
