using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class InventorySave : MonoBehaviour
{
    public ItemLibary itemLibary;
    public InventoryUI inventoryUI;

    public void Save(InventorySystem inventory)
    {
        SaveData saveData = new SaveData();

        var itens = inventory.bag.Values.ToArray();

        saveData.bag = new ItemSave[itens.Length];

        for (int i = 0; i < itens.Length; i++)
        {
            saveData.bag[i].id = itens[i].itemData.id;
            saveData.bag[i].amount = itens[i].amount;
        }

        var save = JsonUtility.ToJson(saveData);

        PlayerPrefs.SetString("Bag", save);
        PlayerPrefs.Save();

        print(save);
    }

    public void Load(InventorySystem inventory)
    {
        var save = PlayerPrefs.GetString("Bag", "");
        var load = JsonUtility.FromJson<SaveData>(save);

        inventory.bag.Clear();

        foreach (var item in load.bag)
        {
            var info = new ItemInfo();

            info.amount = item.amount;
            itemLibary.Find(item.id, out var itemData);

            info.itemData = itemData;

            inventory.Add(info);
        }       

        print(save);
    }
}

[Serializable]
public class SaveData
{
    [SerializeField] public ItemSave[] bag;
}

[Serializable]
public struct ItemSave
{
    public int id;
    public int amount;

    public ItemSave(ItemInfo item) : this()
    {
        id = item.itemData.id;
        amount = item.amount;
    }
}