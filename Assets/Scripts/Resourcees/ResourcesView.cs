using TMPro;
using UnityEngine;

public class ResourcesView : MonoBehaviour
{
    [Header("UI ресурсов:")]
    [SerializeField] private TextMeshProUGUI _textWood;
    [SerializeField] private TextMeshProUGUI _textGold;
    [SerializeField] private TextMeshProUGUI _textFood;
    [SerializeField] private TextMeshProUGUI _textSteel;

    public void DrawAll(ResourcesModel res)
    {
        _textWood.text = res.Wood.ToString();
        _textFood.text = res.Food.ToString();
        _textGold.text = res.Gold.ToString();
        _textSteel.text = res.Steel.ToString();
    }
    public void DrawWood(int value)
    {
        _textWood.text = value.ToString();
    }
    public void DrawFood(int value)
    {
        _textFood.text = value.ToString();
    }
    public void DrawGold(int value)
    {
        _textGold.text = value.ToString();
    }
    public void DrawSteel(int value)
    {
        _textSteel.text = value.ToString();
    }
}
