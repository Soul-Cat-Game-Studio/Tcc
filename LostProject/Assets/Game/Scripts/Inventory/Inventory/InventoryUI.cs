using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class InventoryUI : MonoBehaviour
{
    public InventoryEvents inventoryEvents;
    public InventorySystem inventory;
    public CursorProxy cursorProxy;
    public InputReader input;

    public GameObject uiBackground;

    public GameObject useButton;
    public GameObject inspectButton;
    public GameObject discartButton;

    public ItemUI slotPrefab;
    public GridLayoutGroup slotGrid;

    public ItemUI[] slots;

    public TextMeshProUGUI _name, description;

    [SerializeField] private ItemUI _curreSelectSlot;


    private void OnEnable()
    {
        input.GameplayInventoryAccessEvent += OpenUI;
        input.InventoryDeaccessEvent += CloseUI;

        inventoryEvents.UpdateInventoryEvent += BuildUI;
    }

    private void OnDisable()
    {
        input.GameplayInventoryAccessEvent -= OpenUI;
        input.InventoryDeaccessEvent -= CloseUI;

        inventoryEvents.UpdateInventoryEvent -= BuildUI;
    }


    private void Awake()
    {
        CreateSlots();
    }

    private void Start()
    {
        uiBackground.SetActive(false);
    }

    private void CreateSlots()
    {
        var maxSlot = inventory.maxToUseSlot;

        slots = new ItemUI[maxSlot];

        for (int i = 0; i < maxSlot; i++)
        {
            slots[i] = Instantiate(slotPrefab, slotGrid.transform);
            slots[i].selectEvent.AddListener(SelectSlot);
            slots[i].deselectEvent.AddListener(DeselectSlot);
        }
    }

    public void ShowOptions(ItemData item)
    {
        var canDicard = item?.CanDiscart();
        discartButton.SetActive(canDicard.HasValue && canDicard.Value);

        var canUse = item?.CanUse();
        useButton.SetActive(canUse.HasValue && canUse.Value);

        var canIspect = item?.CanInspect();
        inspectButton.SetActive(canIspect.HasValue && canIspect.Value);
    }

    public void HideOptions(ItemData item)
    {
        var canDicard = item?.CanDiscart();
        discartButton.SetActive(false);

        var canUse = item?.CanUse();
        useButton.SetActive(false);

        var canIspect = item?.CanInspect();
        inspectButton.SetActive(false);
    }

    public void BuildUI()
    {
        foreach (var slot in slots)
        {
            slot.itemInfo = default;
            slot.UpdateUI();
        }

        var itens = inventory.bag.Values;

        int i = 0;

        foreach (var item in inventory.bag.Values)
        {
            var slotStack = (float)item.amount / (float)item.itemData.maxStack;


            slotStack = Mathf.Ceil(slotStack);


            for (int k = 0; k < slotStack; k++)
            {
                slots[i].itemInfo = item;
                slots[i].UpdateUI(k);

                i++;
            }
        }
    }

    private void OpenUI()
    {
        input.EnableInventoryInput();
        input.ChangeInteraction(false);

        uiBackground.SetActive(true);

        cursorProxy.ShowCursor();
    }

    private void CloseUI()
    {
        cursorProxy.HideCursor();

        input.EnableGameplayInput();
        input.ChangeInteraction(true);


        _curreSelectSlot?.Deselect();

        uiBackground.SetActive(false);
    }

    private void UpdateNameDiscription(bool t)
    {
        if (t)
        {
            _name.text = _curreSelectSlot.GetName();
            description.text = _curreSelectSlot.GetDescription();
        }
        else
        {
            _name.text = " ";
            description.text = " ";
        }
    }


    #region Interaction

    //Call first
    public void SelectSlot(ItemUI itemUI)
    {        
        _curreSelectSlot = itemUI;

        UpdateNameDiscription(true);

        _curreSelectSlot?.Selected();

        ShowOptions(_curreSelectSlot.itemInfo.itemData);
    }

    //Call second
    public void DeselectSlot(ItemUI itemUI)
    {


        _curreSelectSlot?.Deselected();
    }


    #endregion

    #region Inpector Button

    public void UseSelectStack()
    {
        inventory.useItemEvent.Invoke(_curreSelectSlot.itemInfo);
    }

    public void DiscartSelectStack()
    {
        _curreSelectSlot?.Discarted(inventory);
        UpdateNameDiscription(false);
        HideOptions(_curreSelectSlot.itemInfo.itemData);
    }
    #endregion

}