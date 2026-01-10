using System.Collections;
using UnityEngine;

public class AbilityCooldowns : MonoBehaviour
{
    public void OriginalSpeed(PlayerController player, int speed)
    {
        StartCoroutine(Speed(player, speed));
    }

    IEnumerator Speed(PlayerController player, int speed)
    {
        yield return new WaitForSeconds(5);
        player.stats.MoveSpeed -= speed;
        Debug.Log(player.stats.MoveSpeed);
    }
}
