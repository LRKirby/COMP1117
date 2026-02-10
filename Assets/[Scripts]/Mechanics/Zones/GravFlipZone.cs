using UnityEngine;

public class GravFlipZone : Zone
{
    [SerializeField] private float gravity = -9.81f;

    protected override void ApplyZoneEffect(Player player)
    {
        Physics2D.gravity = new Vector2 (0, -gravity);
        player.transform.localScale = new Vector3(1, -1, 1);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.TryGetComponent(out Player player))
        {
            Physics2D.gravity = new Vector2(0, gravity);
            player.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
