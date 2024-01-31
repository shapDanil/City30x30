using UnityEngine;

public abstract class Building : MonoBehaviour
{
    protected float constructionTime;
    protected WaitForSeconds waitConstruction;
    [SerializeField] private Cost _cost;

    public WaitForSeconds GetWaitConstruction()
    {
        return waitConstruction;
    }
    public Cost GetCost()
    {
        return _cost;
    }
}