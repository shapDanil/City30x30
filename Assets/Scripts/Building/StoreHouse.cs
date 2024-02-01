using UnityEngine;

public class StoreHouse : Building
{
    [SerializeField]private Cost _capacity;

    private void Start()
    {
        ResourcesController.GetInstance().AddCapacity(_capacity);
    }
}
