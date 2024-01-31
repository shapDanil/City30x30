using UnityEngine;
using System.Collections;

public class BuildManager : MonoBehaviour
{
    [SerializeField] private GameObject _currentTypeBuilding;

    private WaitForSeconds _wait;

    private void Awake()
    {
        _wait = new WaitForSeconds(3f);
    }
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
        var temp = _currentTypeBuilding.GetComponent<IndustrialBuilding>();
        if (ResourcesController.GetInstance().Buy(temp.GetCost()))
            StartCoroutine(StartConstruction(cellGameObject));
    }

    public void SetCurrentTypeBuilding(GameObject gameObject)
    {
        _currentTypeBuilding = gameObject;
       // _wait = Building.GetWait();
    }

    IEnumerator StartConstruction(GameObject cellGameObject)
    {
        yield return _wait;
        Instantiate(_currentTypeBuilding, cellGameObject.transform.position, Quaternion.identity, cellGameObject.transform);
    }

}
