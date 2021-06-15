using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "ItemLibary", menuName = "Inventory/ItemLibary", order = 2)]
public class ItemLibary : ScriptableObject
{
    public List<ItemData> itemDatas;

    public Dictionary<int, int> searchEasy;

    public bool Find(int id, out ItemData itemData)
    {
        if(GetSearch().TryGetValue(id, out var index))
        {
            itemData = itemDatas[index];
            return true;
        }

        itemData = default;

        return false;
    }

    private Dictionary<int, int> GetSearch()
    {
        if (searchEasy == null)
        {
            searchEasy = new Dictionary<int, int>();

            for (int i = 0; i < itemDatas.Count; i++)
            {
                searchEasy.Add(itemDatas[i].id, i);
            }            
        }

        return searchEasy;
    }
}