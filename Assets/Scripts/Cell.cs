using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    [SerializeField] private Color _standartColor;
    [SerializeField] private Color _hoverColor;
    private MeshRenderer _meshRenderer;
    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }
    private void ChangeColor(Color color)
    {
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
}
