using UnityEngine;

public class Follower2D : MonoBehaviour
{
    [SerializeField] Transform _target;
    [SerializeField] [Range(0,1)] float _speed = 0.05f;
    private Vector3 _offset;
    
    private void Start()
    {
        _offset = transform.position - _target.transform.position;
    }    

    private void LateUpdate()
    {
        if (_target!=null) Follow();           
    }

    private void Follow()
    {
        Vector3 targetPosition = _target.position;
        targetPosition.z = transform.position.z;
        transform.position = Vector3.Lerp(transform.position, _target.position + _offset, _speed);
    }    
}
