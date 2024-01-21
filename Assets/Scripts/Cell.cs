using UnityEngine;
using UnityEngine.Events;

public class Cell : MonoBehaviour
{
    [SerializeField] private Color _standartColor;
    [SerializeField] private Color _hoverColor;
    private MeshRenderer _meshRenderer;
    private bool _isEmpty;
    public static event UnityAction<GameObject> OnMouseDowned;
    private void Start()
    {
        _isEmpty = true;
        _meshRenderer = GetComponent<MeshRenderer>();
    }
    private void ChangeColor(Color color)
    {
        if(_isEmpty)
            _meshRenderer.material.color = color;
    }
    private void OnMouseEnter()
    {
        ChangeColor(_hoverColor);
    }
    private void OnMouseExit()
    {
        ChangeColor(_standartColor);
    }
    private void OnMouseDown()
    {
        if (_isEmpty)
        {
            OnMouseDowned?.Invoke(gameObject);
            _isEmpty = false;
        }
            
    }
  
}
