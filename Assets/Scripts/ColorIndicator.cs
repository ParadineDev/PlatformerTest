using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class ColorIndicator : MonoBehaviour
{
    [SerializeField] MonoBehaviour _componentToIndicate;
    [SerializeField] Material _materialDefault;
    [SerializeField] Material _materialChange;
    Renderer _render;
    private void Start()
    {
        _render = GetComponent<Renderer>();
    }
    private void Update()
    {
        if (_componentToIndicate != null) SwitchMaterial();
    }
    private void SwitchMaterial()
    {
        Debug.Log(_componentToIndicate.enabled);
        if (_componentToIndicate.enabled)
        {
            _render.sharedMaterial = _materialDefault;
        }
        if (!_componentToIndicate.enabled)
        {
            _render.sharedMaterial = _materialChange;
        }
    }
}
