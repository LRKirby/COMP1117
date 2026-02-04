using UnityEngine;

public class WaterZone : Zone
{
    [Range(0, 1)]
    [SerializeField] private float speedModifier = 0.5f;
    protected override void ApplyZoneEffect(Player player)
    {
        player.ApplySpeedModifier(speedModifier);
    }
}
