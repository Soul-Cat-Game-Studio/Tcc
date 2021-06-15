using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "InventorySystem", menuName = "InventorySystem/InventorySystem", order = 0)]
public class InventorySystem : ScriptableObject
{
    public delegate void ItemEvent(ItemInfo info);
    public ItemEvent useItemEvent;

    


    public InventoryEvents inventoryEvents;
    public Dictionary<int, ItemInfo> bag = new Dictionary<int, ItemInfo>();

    public int maxToUseSlot;
    [SerializeField] private int _amountUsedSlot;

    private void OnEnable() { _amountUsedSlot = 0; }




    public int Add(Item item)
    {
        var info = new ItemInfo(item);
        return Add(info);
    }

    public int Add(ItemInfo item)
    {
        var id = item.itemData.id;

        if (HasItem(id, out var result))
            return AddExistItem(result, item);

        else if (_amountUsedSlot < maxToUseSlot)
            return AddNewItem(item);


        return 0;
    }

    private int AddExistItem(ItemInfo bagItem, ItemInfo itemAdd)
    {
        var id = itemAdd.itemData.id;

        var maxStack = bagItem.itemData.maxStack;



        var stackToUse = CountStackToUse(bagItem, itemAdd.amount);

        int sobra = CalularSobra(stackToUse, maxToUseSlot, _amountUsedSlot);

        if (sobra <= 0)
        {
            var itemLeftTocompleteStack = maxStack - (bagItem.amount % maxStack);
            var stackToAdd = (stackToUse + sobra);
            var itemToAdd = (itemLeftTocompleteStack != maxStack) ? itemLeftTocompleteStack : 0;


            var maxItemToAdd = stackToAdd * itemAdd.itemData.maxStack;

            itemToAdd += Mathf.Min(itemAdd.amount - itemToAdd, maxItemToAdd);

            _amountUsedSlot += stackToAdd;

            bagItem.amount += itemToAdd;
            bag[id] = bagItem;

            TriggerUpdateInventoryEvent(itemToAdd);

            return itemToAdd;
        }
        else
        {
            _amountUsedSlot += stackToUse;
            bagItem.amount += itemAdd.amount;
            bag[id] = bagItem;

            TriggerUpdateInventoryEvent(itemAdd.amount);

            return itemAdd.amount;
        }
    }

    private int AddNewItem(ItemInfo itemAdd)
    {
        var id = itemAdd.itemData.id;
        var stacks = CountStackToUse(itemAdd, itemAdd.amount);

        int sobra = CalularSobra(stacks, maxToUseSlot, _amountUsedSlot);

        if (sobra < 0)
        {
            var addAmount = (stacks - sobra);
            itemAdd.amount = addAmount * itemAdd.itemData.maxStack;
            _amountUsedSlot += addAmount;
        }
        else
        {
            _amountUsedSlot += stacks;
        }

        bag.Add(id, itemAdd);

        TriggerUpdateInventoryEvent(itemAdd.amount);

        return itemAdd.amount;
    }
    private int CalularSobra(int stackToUse, int stackMax, int stckUsed)
    {
        var slotAvaible = stackMax - stckUsed;
        return slotAvaible - stackToUse;
    }

    private int CountStackToUse(ItemInfo bagItem, int sum)
    {
        float maxStack = bagItem.itemData.maxStack;

        float countItensInLastStack = bagItem.amount % maxStack;

        countItensInLastStack += sum;

        float stacksUsed = countItensInLastStack / maxStack;
        stacksUsed -= 1;
        stacksUsed = Mathf.Max(stacksUsed, 0);

        return (int)Mathf.Ceil(stacksUsed);
    }

    public bool HasItem(int id, out ItemInfo data) => bag.TryGetValue(id, out data);

    public void Remove(int id, int amount)
    {
        if (HasItem(id, out var result))
        {
            var resultAmount = result.amount;

            var currentAmount = Mathf.Max(result.amount - amount, 0);

            var difAmount = currentAmount - resultAmount;

            if (currentAmount <= 0)
                bag.Remove(result.Id);

            else
            {
                result.amount = currentAmount;
                bag[result.Id] = result;
            }


            float maxStack = result.itemData.maxStack;
            var lastCountStack = Mathf.CeilToInt(resultAmount / maxStack);
            var currentCountStack = Mathf.CeilToInt(currentAmount / maxStack);

            _amountUsedSlot -= lastCountStack - currentCountStack;


            inventoryEvents.UpdateInventory();
        }
    }

    public void TriggerUpdateInventoryEvent(int amount)
    {
        if (amount > 0)
            inventoryEvents.UpdateInventory();
    }
}


[SerializeField]
public struct ItemInfo
{
    public ItemData itemData;
    public int amount;

    public int Id => itemData.id;

    public ItemInfo(Item item) : this()
    {
        itemData = item.data;
        amount = item.amount;
    }
}