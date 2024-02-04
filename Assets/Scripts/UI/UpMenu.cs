using System.Collections.Generic;
using UnityEngine;
using TMPro;


class UpMenu : MonoBehaviour
{

    [SerializeField] private GameObject _upMenu;
    [SerializeField] private TextMeshProUGUI _textNowWood;
    [SerializeField] private TextMeshProUGUI _textNowFood;
    [SerializeField] private TextMeshProUGUI _textNowSteel;
    [SerializeField] private TextMeshProUGUI _textNowGold;
    [SerializeField] private TextMeshProUGUI _nextWood;
    [SerializeField] private TextMeshProUGUI _nextFood;
    [SerializeField] private TextMeshProUGUI _nextSteel;
    [SerializeField] private TextMeshProUGUI _nextGold;

    private IndustrialBuilding _currentBuilding;
    private Cost _upContent;

    private void OnEnable()
    {
        IndustrialBuilding.MouseDowned += EnableUpMenu;
    }
    private void OnDisable()
    {
        IndustrialBuilding.MouseDowned -= EnableUpMenu;
    }

    private void EnableUpMenu(IndustrialBuilding gameObject, Cost upContent)
    {
        _upContent = upContent;
        _currentBuilding = gameObject;
        Time.timeScale = 0f;
        _upMenu.SetActive(true);
        UpdateContent();
    }

    private void DisableUpMenu()
    {
       //_nextFood.SetActive(false);
       //_nextWood.SetActive(false);
       //_nextGold.SetActive(false);
       //_nextSteel.SetActive(false);
        _upMenu.SetActive(false);
    }
    private void UpdateContent()
    {
        var temp = _currentBuilding.GetIncom();
        _textNowWood.text = temp.Wood.ToString();
        _textNowFood.text = temp.Food.ToString();
        _textNowGold.text = temp.Gold.ToString();
        _textNowSteel.text = temp.Steel.ToString();
        _nextWood.text = _upContent.Wood.ToString();
        _nextFood.text = _upContent.Food.ToString();
        _nextGold.text = _upContent.Gold.ToString();
        _nextSteel.text = _upContent.Steel.ToString();
    }

    public void CancelButtonClick()
    {
        DisableUpMenu();
        Time.timeScale = 1f;
    }
    public void OkButtonClick()
    {
        _currentBuilding.BuffBuilding();
        DisableUpMenu();
        Time.timeScale = 1f;
    }
}

