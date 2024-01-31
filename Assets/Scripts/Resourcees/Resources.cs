using TMPro;
using UnityEngine;

public class Resources : MonoBehaviour
{
    private static Resources instance;

    [Header("UI ресурсов:")]
    [SerializeField] private TextMeshProUGUI _textWood;
    [SerializeField] private TextMeshProUGUI _textGold;
    [SerializeField] private TextMeshProUGUI _textFood;
    [SerializeField] private TextMeshProUGUI _textSteel;
    
    [Header("Значение ресурсов:")]
    [SerializeField] private int _wood;
    [SerializeField] private int _gold;
    [SerializeField] private int _food;
    [SerializeField] private int _steel;

    private void Awake()
    {
        _textFood.text = _food.ToString();
        _textWood.text = _wood.ToString();
        _textGold.text = _gold.ToString();
        _textSteel.text = _steel.ToString();
    }

    public int Wood { get => _wood; set
        {
            _wood = value;
            _textWood.text = _wood.ToString();
        }
    }
    public int Gold { get => _gold; set
        {
            _gold = value;
            _textGold.text = _gold.ToString();
        }
    }
    public int Food { get => _food; set
        {
            _food = value;
            _textFood.text = _food.ToString();
        }
    }
    public int Steel { get => _steel; set
        {
            _steel = value;
            _textSteel.text = _steel.ToString();
        }
    }

    public Resources()
    {

    }
    public static Resources GetInstance()
    {
        if (instance == null)
            instance = new Resources();
        return instance;
    }
}
