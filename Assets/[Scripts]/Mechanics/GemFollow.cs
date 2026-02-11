using System.Collections;
using UnityEngine;

public class GemFollow : MonoBehaviour
{
    [SerializeField] private float waitTime = 5;
    private bool following;

    private void Awake()
    {
        StartCoroutine(DelayFollow());
    }

    private void Update()
    {
        if (following)
            transform.position = Vector2.Lerp(transform.position, Player.instance.transform.position, Time.deltaTime);
    }

    IEnumerator DelayFollow()
    {
        yield return new WaitForSeconds(waitTime);
        following = true;
    }
}
