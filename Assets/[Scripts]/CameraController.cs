using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform target;
    private float smoothTime = 0.2f;
    private Vector3 velocity;

    public float SmoothTime
    {
        get
        {
            return smoothTime;
        }
        set
        {
            smoothTime = value;
        }
    }

    private void Update()
    {
        Vector3 targetPos = target.TransformPoint(new Vector3(0, 0, -10));
        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);
    }
}
