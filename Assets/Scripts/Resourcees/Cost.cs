using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cost 
{
    [Header("Ресурсы:")]
    [SerializeField, Min(0)] protected uint _wood;
    [SerializeField, Min(0)] protected uint _gold;
    [SerializeField, Min(0)] protected uint _food;
    [SerializeField, Min(0)] protected uint _steel;
    public uint Wood { get => _wood; set => _wood = value; }
    public uint Gold { get => _gold; set => _gold = value; }
    public uint Food { get => _food; set => _food = value; }
    public uint Steel { get => _steel; set => _steel = value; }
}
