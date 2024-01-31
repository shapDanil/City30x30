using TMPro;
using UnityEngine;

public class ResourcesController : MonoBehaviour
{
    private static ResourcesController instance;
   
    [SerializeField] private ResourcesView _view;
    private ResourcesModel _model;

    private void Awake()
    {
        _model = new ResourcesModel(100,100,100,100);
        _view.DrawAll(_model);
    }
    public ResourcesController()
    {

    }
    public static ResourcesController GetInstance()
    {
        if (instance == null)
            instance = new ResourcesController();
        return instance;
    }
}
