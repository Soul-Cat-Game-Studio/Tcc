using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using static InventorySystem;
using TMPro;
using DG.Tweening;

public class ItemUI : MonoBehaviour
{
    public ItemInfo itemInfo;

    private ItemButton _itemButton;

    public bool hasItem => itemInfo.itemData != null;

    public Image icon;

    public TextMeshProUGUI amount;

    public float scaleOffset = 1.5f;


    public ItemUIEvent selectEvent;
    public ItemUIEvent deselectEvent;
    public ItemUIEvent discartEvent;

    private Tween _tween;


    private void Awake()
    {
        _itemButton = GetComponent<ItemButton>();
    }


    public string GetName()
    {
        if (itemInfo.itemData == null) return string.Empty;

        return itemInfo.itemData.name;
    }

    public string GetDescription()
    {
        if (itemInfo.itemData == null) return string.Empty;

        return itemInfo.itemData.descripton;
    }


    public void UpdateUI(int slot = 0)
    {
        if (hasItem)
        {
            icon.color = Color.white;

            icon.sprite = itemInfo.itemData.image;

            var total = itemInfo.amount - (itemInfo.itemData.maxStack * slot);

            amount.text = Mathf.Min(total, itemInfo.itemData.maxStack).ToString();

            _itemButton.interactable = true;
        }
        else
        {
            _itemButton.interactable = false;

            icon.sprite = null;
            amount.text = "0";
            icon.color = new Color(0, 0, 0, 0);
        }
    }

    public ItemUI()
    {
        selectEvent = new ItemUIEvent();
        deselectEvent = new ItemUIEvent();
        discartEvent = new ItemUIEvent();
    }



    public void Select() => selectEvent?.Invoke(this);

    public void Deselect() => deselectEvent?.Invoke(this);

    public void Discart() => discartEvent?.Invoke(this);

    

    public void Selected()
    {
        _tween?.Kill();
        _tween = transform.DOScale(scaleOffset, .5f);
    }    

    public void Deselected()
    {
        _tween?.Kill();
        _tween = transform.DOScale(1, .5f);
    }

    public void Discarted(InventorySystem inventory)
    {        
        if (!hasItem) return;

        inventory.Remove(itemInfo.Id, int.Parse(amount.text));       
    }
}