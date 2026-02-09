using UnityEngine;
using UnityEngine.Windows;

public class GravFlipZone : Zone
{
    protected override void ApplyZoneEffect(Player player)
    {
        Physics2D.gravity = new Vector2 (0, 9.81f);
        player.transform.localScale = new Vector3(1, -1, 1);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.TryGetComponent(out Player player))
        {
            Physics2D.gravity = new Vector2(0, -9.81f);
            player.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
