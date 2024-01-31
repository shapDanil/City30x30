using UnityEngine;

public class ResourcesController : MonoBehaviour
{
    private static ResourcesController _instance;
   
    [SerializeField] private ResourcesView _view;
    [SerializeField] private ResourcesModel _model;

    public static ResourcesController Instance { get => _instance;}
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
        return Instance;
    }
    public void AddResources(ResourcesModel res)
    {
        _model.Add(res);
    }
   
}
