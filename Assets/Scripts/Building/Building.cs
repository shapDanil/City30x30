using UnityEngine;

public abstract class Building : MonoBehaviour
{
    protected float constructionTime;
    protected WaitForSeconds waitConstruction;
    private ResourcesModel _cost;

    public WaitForSeconds GetWaitConstruction()
    {
        return waitConstruction;
    }
}