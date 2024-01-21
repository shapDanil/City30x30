using UnityEngine;

public class BuildManager : MonoBehaviour
{
    [SerializeField] private Vector2Int _sizePlane = new Vector2Int(30, 30);
    [SerializeField] private Camera _camera;
    [SerializeField] private GameObject _currentTypeBuilding;

    private void OnEnable()
    {
        Cell.OnMouseDowned += Build;
    }
    private void OnDisable()
    {
        Cell.OnMouseDowned -= Build;
    }
    private void Build(GameObject cellGameObject)
    {
        Instantiate(_currentTypeBuilding, cellGameObject.transform.position, Quaternion.identity,cellGameObject.transform);
    }
}
