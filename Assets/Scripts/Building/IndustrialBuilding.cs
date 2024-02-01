using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndustrialBuilding : Building
{
    [SerializeField] private float _timeProduction;
    [SerializeField] private ResourcesModel _income;
    [SerializeField] private GameObject _ui;

    private void Start()
    {
        StartProduction();
    }
    private void StartProduction()
    {
        Invoke(nameof(Production), _timeProduction);
    }
    public void Production()
    {
        _ui.SetActive(true);
    }

    public void Collect()
    {
        _ui.SetActive(false);
        ResourcesController.GetInstance().AddResources(_income);
        StartProduction();
    }

}
