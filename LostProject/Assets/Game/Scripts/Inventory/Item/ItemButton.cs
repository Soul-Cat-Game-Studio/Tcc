using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemButton : Button
{
    public ItemUI itemUI;

    protected override void Awake()
    {
        base.Awake();        
        itemUI = GetComponent<ItemUI>();
    }

    public override void OnPointerClick(PointerEventData eventData)
    {
        if(!interactable) return;

        base.OnPointerClick(eventData);
        itemUI.Select();
    }

    public override void OnDeselect(BaseEventData eventData)
    {
        if(!interactable) return;

        base.OnDeselect(eventData);
        itemUI.Deselect();
    }   
}