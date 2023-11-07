using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private Transform target;

    private Transform _transform;

    // [SerializeField] [Range(0f, 1f)] private float t = .5f;
    private Vector3 _offset;

    private void Awake()
    {
        _transform = gameObject.transform;
        target = FindObjectOfType<PlayerController>().transform;
        _offset = _transform.position - target.position;
    }

    private void LateUpdate()
    {
        var targetPos = target.position;
        var targetPosition = new Vector3(targetPos.x, targetPos.y, targetPos.z);
        _transform.position = targetPosition + _offset;
        // _transform.position = Vector3.Lerp(_transform.position, targetPosition, t * Time.deltaTime);
    }
}