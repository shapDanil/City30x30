using UnityEngine;

public class ResourcesController : MonoBehaviour
{
    private static ResourcesController _instance;
   
    [SerializeField] private ResourcesView _view;
    [SerializeField] private ResourcesModel _model;

    public ResourcesView View { get => _view;}

    private void Awake()
    {
        View.Draw(_model);
    }
    public ResourcesController()
    {

    }
    public static ResourcesController GetInstance()
    {
        if (_instance == null)
            _instance = new ResourcesController();
        return _instance;
    }
    public void AddResources(ResourcesModel res)
    {
        _model.Add(res);
    }
    public bool Buy(Cost res)
    {
        return _model.Subtract(res);
    }
}
