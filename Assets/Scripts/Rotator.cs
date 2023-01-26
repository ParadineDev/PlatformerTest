using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 rotation;
    void Update()
    {
        transform.Rotate(rotation);        
    }
}
