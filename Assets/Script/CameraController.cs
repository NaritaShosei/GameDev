using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform _followTarget;
    [SerializeField] Vector3 _offset;
    void Start()
    {
        transform.position = _followTarget.position + _offset;
    }
    private void LateUpdate()
    {
        transform.position = _followTarget.position + _offset;
    }
}
