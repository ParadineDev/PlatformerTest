using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField] private InputAction[] _inputActions;
    private void Update()
    {
        ActBasedOnInput();
    }

    private void ActBasedOnInput()
    {
        foreach (var inputAction in _inputActions)
        {
            foreach (var key in inputAction.keys)
            {
                if (Input.GetKey(key) && inputAction.type==InputAction.Types.Hold 
                || Input.GetKeyDown(key) && inputAction.type==InputAction.Types.Press
                || Input.GetKeyUp(key) && inputAction.type==InputAction.Types.Release) 
                inputAction.action.Invoke();                
            }
        }
    }        
}

