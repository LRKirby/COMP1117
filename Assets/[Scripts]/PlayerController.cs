using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerStats stats;

    private void Awake()
    {
        stats = new PlayerStats();
    }
}
