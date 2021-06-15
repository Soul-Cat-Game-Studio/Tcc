using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "ItemData", menuName = "InventorySystem/ItemData", order = 1)]
[Serializable]
public class ItemData : ScriptableObject
{
    public int id = -1;

    public int maxStack;

    public GameObject prefab;
    

    [Space(20)]
    public bool dropable;
    public bool usable;
    public bool inspectable;


    [Space(20)]

    public Sprite image;

    public string _name;



    [TextArea(10, 20)]
    public string descripton;

    public virtual bool CanUse()
    {
        return usable;
    }

    public virtual bool CanInspect()
    {
        return inspectable;
    }
    public virtual bool CanDiscart()
    {
        return dropable;
    }


}
