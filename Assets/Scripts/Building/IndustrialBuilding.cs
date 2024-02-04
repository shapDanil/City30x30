
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IndustrialBuilding : Building
{
    [SerializeField] private float _timeProduction;
    [SerializeField] private Cost _income;
    [SerializeField] private GameObject _ui;
    [SerializeField] private Cost _buff;
    [SerializeField] private bool _withBuff;

    public static event UnityAction<IndustrialBuilding, Cost> MouseDowned;

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
    private void OnMouseDown()
    {
        if(_withBuff)
            MouseDowned?.Invoke(this,_buff);
        Debug.Log("нажал");
    }
    public void BuffBuilding()
    {
        var buff = _buff;    
        _income.Wood += buff.Wood;
        _income.Steel += buff.Steel;
        _income.Gold += buff.Gold;
        _income.Food += buff.Food;
    }
    public Cost GetIncom()
    {
        return _income;
    }
}
