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
    public uint WoodCapacity { get => _woodCapacity; set => _woodCapacity = value;}
    public uint GoldCapacity { get => _goldCapacity; set => _goldCapacity = value;}
    public uint FoodCapacity { get => _foodCapacity; set => _foodCapacity = value;}
    public uint SteelCapacity { get => _steelCapacity; set => _steelCapacity = value;}



    public void Add(Cost addModel)
    {
        Food = Math.Min(addModel.Food + Food,FoodCapacity);
        Wood = Math.Min(addModel.Wood + Wood, WoodCapacity);
        Steel = Math.Min(addModel.Steel + Steel, SteelCapacity);
        Gold = Math.Min(addModel.Gold + Gold, GoldCapacity);
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
    public void AddCapacity(Cost addCapacity)
    {
        FoodCapacity += addCapacity.Food;
        WoodCapacity += addCapacity.Wood;
        SteelCapacity += addCapacity.Steel;
        GoldCapacity += addCapacity.Gold;
    }
    private bool Enough(Cost subModel)
    {
        if (subModel.Wood < _wood && subModel.Food < _food && subModel.Steel < _steel && subModel.Gold < _gold)
            return true;
        else
            return false;
    }
   
}
