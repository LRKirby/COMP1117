using System.Collections;
using UnityEngine;

public class AbilityCooldowns : MonoBehaviour
{
    public void OriginalSpeed(Player player, float speed)
    {
        StartCoroutine(Speed(player, speed));
    }

    IEnumerator Speed(Player player, float speed)
    {
        yield return new WaitForSeconds(5);
        //player.stats.MoveSpeed -= speed;
    }
}
