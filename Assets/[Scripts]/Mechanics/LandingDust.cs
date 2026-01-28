using UnityEngine;

public class LandingDust : MonoBehaviour
{
    [SerializeField] private GameObject dust;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Instantiate(dust, transform.position, transform.rotation);
        }
    }
}
