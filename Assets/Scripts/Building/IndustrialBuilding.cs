using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IndustrialBuilding : Building
{
    [SerializeField] private float _timeProduction;
    [SerializeField] private ResourcesModel _income;

    //public static event UnityAction<ResourcesModel> ResourcesProduced;
    private void Start()
    {
        InvokeRepeating(nameof(Production), _timeProduction, _timeProduction);
    }
    public void Production()
    {
        ResourcesController.GetInstance().AddResources(_income);
    }

   
    
}
