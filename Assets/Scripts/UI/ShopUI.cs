
using UnityEngine;
using UnityEngine.Events;

public class ShopUI : MonoBehaviour
{
    [SerializeField] private GameObject _shopBuildingUI;
    public static event UnityAction OnBuildModeChanged;
    public static event UnityAction<GameObject> OnBuildingChose;

    public void Close()
    {
        _shopBuildingUI.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Open()
    {
        _shopBuildingUI.SetActive(true);
        Time.timeScale = 0f;
    }
    public void SelectBuilding(GameObject building)
    {
        OnBuildingChose?.Invoke(building);
        Close();
    }
}
