using UnityEngine;

public class Incline : MonoBehaviour
{
    [SerializeField][Range(0,1)] private float _distance = 0.1f;
    [HideInInspector]public float Angle {get; private set;}
    
    private void Update()
    {
        Angle = GetInclineAngle();        
    }

    private float GetInclineAngle()
    {                
        Vector3 pointA = transform.position + Vector3.up + Vector3.left * _distance;
        Vector3 pointB = transform.position + Vector3.up + Vector3.right * _distance;
        RaycastHit2D hitA = Physics2D.Raycast(pointA, Vector2.down, 1);
        RaycastHit2D hitB = Physics2D.Raycast(pointB, Vector2.down, 1);                  
        Vector2 delta = (hitB.point-hitA.point).normalized;        
        return Vector2.Angle(Vector2.right, delta);
    }
}
