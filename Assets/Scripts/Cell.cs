using UnityEngine;
using UnityEngine.Events;

public class Cell : MonoBehaviour
{
    [SerializeField] private Color _standartColor;
    [SerializeField] private Color _hoverColor;
    private MeshRenderer _meshRenderer;
    private bool _isEmpty;
    private static bool _isBuildModeEnable;
    public static event UnityAction<GameObject> MouseDowned;
    private void Start()
    {
        _isEmpty = true;
        _isBuildModeEnable = false;
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnEnable()
    {
        ShopUI.OnBuildingChose += EnableBuildMode;
    }
    private void OnDisable()
    {
        ShopUI.OnBuildingChose -= EnableBuildMode;
    }
    private void ChangeColor(Color color)
    {
        if(_isEmpty && _isBuildModeEnable)
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
        if (_isEmpty && _isBuildModeEnable)
        {
            _isEmpty = false;
            _isBuildModeEnable = false;
            MouseDowned?.Invoke(gameObject);   
        }
    }
    private void EnableBuildMode(Building gameObject)
    {
        _isBuildModeEnable = true;
    }
}
