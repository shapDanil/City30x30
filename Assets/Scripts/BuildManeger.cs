using UnityEngine;

public class BuildManager : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private GameObject _currentTypeBuilding;

    private void OnEnable()
    {
        Cell.OnMouseDowned += Build;
        ShopUI.OnBuildingChose += SetCurrentTypeBuilding;
    }
    private void OnDisable()
    {
        Cell.OnMouseDowned -= Build;
        ShopUI.OnBuildingChose -= SetCurrentTypeBuilding;
    }
    private void Build(GameObject cellGameObject)
    {
        Instantiate(_currentTypeBuilding, cellGameObject.transform.position, Quaternion.identity,cellGameObject.transform);
    }

    public void SetCurrentTypeBuilding(GameObject gameObject)
    {
        _currentTypeBuilding = gameObject;
    }
    
}
