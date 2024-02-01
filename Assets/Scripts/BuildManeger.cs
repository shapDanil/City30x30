using UnityEngine;
using System.Collections;

public class BuildManager : MonoBehaviour
{
    [SerializeField] private Building _currentTypeBuilding;

    private WaitForSeconds _wait;

    private void Awake()
    {
        _wait = new WaitForSeconds(4f);
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
        if (ResourcesController.GetInstance().Buy(_currentTypeBuilding.GetCost()))
            StartCoroutine(StartConstruction(cellGameObject, _currentTypeBuilding));
    }

    public void SetCurrentTypeBuilding(Building gameObject)
    {
        _currentTypeBuilding = gameObject;
       // _wait = Building.GetWait();
    }

    IEnumerator StartConstruction(GameObject cellGameObject, Building currentTypeBuilding)
    {
        yield return _wait;
        Instantiate(currentTypeBuilding, cellGameObject.transform.position, Quaternion.identity, cellGameObject.transform);
    }

}
