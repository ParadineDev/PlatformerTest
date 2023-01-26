using UnityEngine;

[RequireComponent(typeof(Control))]
[RequireComponent(typeof(Incline))]
[RequireComponent(typeof(Rigidbody2D))]
public class ControlSwitcher : MonoBehaviour
{
    [SerializeField][Range(1,85)] float _maxInclineAngle = 45f; 
    private Control _control;
    private Incline _incline;
    private Rigidbody2D _rigidBody;

    private void Awake()
    {
        _control = GetComponent<Control>();
        _incline = GetComponent<Incline>();
        _rigidBody = GetComponent<Rigidbody2D>();         
    }

    private void Update()
    {
        SwitchControl();        
    }

    private void SwitchControl()
    {
        if (_incline.Angle > _maxInclineAngle && _rigidBody.velocity.x!=0)
        {
            _control.enabled = false; 
        }
        else
        {
            _control.enabled = true; 
        }
    }    
}
