using UnityEngine;
using UnityEngine.Events;

[System.Serializable] public class InputAction
{
    public KeyCode[] keys;
    public UnityEvent action;
    public enum Types{Press, Hold, Release};
    public Types type;
}
