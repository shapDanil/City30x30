using System;
using UnityEngine;

[Serializable]
public class ResourcesModel: Cost
{
    [Header("Вместимость:")]
    [SerializeField, Min(0)] private uint _woodCapacity;
    [SerializeField, Min(0)] private uint _goldCapacity;
    [SerializeField, Min(0)] private uint _foodCapacity;
    [SerializeField, Min(0)] private uint _steelCapacity;
    public ResourcesModel(uint wood, uint gold, uint food, uint steel)
    {
        Food = food;
        Wood = wood;
        Gold = gold;
        Steel = steel;
    }
    public uint WoodCapacity { get => _woodCapacity; set => _wood = Math.Min(value, _woodCapacity); }
    public uint GoldCapacity { get => _goldCapacity; set => _gold = Math.Min(value, _goldCapacity);  }
    public uint FoodCapacity { get => _foodCapacity; set => _food = Math.Min(value, _foodCapacity); }
    public uint SteelCapacity { get => _steelCapacity; set => _steel = Math.Min(value, _steelCapacity); }



    public void Add(Cost addModel)
    {
        Food += addModel.Food;
        Wood += addModel.Wood;
        Steel += addModel.Steel;
        Gold += addModel.Gold;
        ResourcesController.GetInstance().View.Draw(this);
    }
    public bool Subtract(Cost subModel)
    {
        if (Enough(subModel))
        {
            Food -= subModel.Food;
            Wood -= subModel.Wood;
            Steel -= subModel.Steel;
            Gold -= subModel.Gold;
            ResourcesController.GetInstance().View.Draw(this);
            return true;
        }
        else
        {
            Debug.Log("Не хватает ресурсов!");
            return false;
        }
    }
    private bool Enough(Cost subModel)
    {
        if (subModel.Wood < _wood && subModel.Food < _food && subModel.Steel < _steel && subModel.Gold < _gold)
            return true;
        else
            return false;
    }
   
}
