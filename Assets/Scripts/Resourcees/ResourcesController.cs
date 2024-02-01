using UnityEngine;

public class ResourcesController : MonoBehaviour
{
    private static ResourcesController _instance;
   
    [SerializeField] private ResourcesView _view;
    [SerializeField] private ResourcesModel _model;

   
    public ResourcesView View { get => _view;}
    public ResourcesModel Model { get => _model; }

    private void Awake()
    {
        View.Draw(Model);
        _instance = this;
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
    public void AddResources(Cost res)
    {
        Model.Add(res);
    }
    public void AddCapacity(Cost res)
    {
        Model.AddCapacity(res);
    }
    public bool Buy(Cost res)
    {
        return Model.Subtract(res);
    }
}
