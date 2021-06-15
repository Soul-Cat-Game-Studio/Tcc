using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

public class ObjToTake : ObjInteractBase
{
    [Space(20)]
    [SerializeField] private InputReader _input;

    public float distance = 0.4f;
    public float subtractScale;

    [Space(20)]
    public UnityEvent enterInpectEvent;
    public UnityEvent exitInpectEvent;
    public UnityEvent pickupEvent;

    private Transform _cam;

    [SerializeField] private Vector3 _originPos, _orginRot;

    public InventorySystem inventory;
    public Item item;




    private void Awake() { _cam = Camera.main.transform; }

    private void OnEnable()
    {
        _originPos = transform.position;
        _orginRot = transform.rotation.eulerAngles;
    }

    private void Start() { uiType = UiObserver.TypeOfUi.Pickup; }



    public override void DoPrimaryAction()
    {
        base.DoPrimaryAction();

        var point = _cam.position + _cam.forward * distance;
        var newScale = transform.localScale.x - subtractScale;

        transform.DOMove(point, 0.35f, false);
        transform.DOScale(newScale, 0.35f);

        uiObserver.DeactivateGameplayCanvas(uiType);
        uiObserver.ActivateUICanvas(uiType, this);

        _input.ChangeInteraction(false);

        enterInpectEvent?.Invoke();
    }

    public override void DoPrimaryActionBack()
    {
        var newScale = transform.localScale.x + subtractScale;

        transform.DOScale(newScale, 0.35f);

        transform.DORotate(_orginRot, 0.35f, RotateMode.Fast);

        transform.DOMove(_originPos, 0.35f, false).OnComplete(After);

        uiObserver.DeactivateUICanvas(uiType, this);
    }

    public override void DoSecondAction() { PickUp(); }

    public override void DoSecondActionBack()
    {
        uiObserver.DeactivateUICanvas(uiType, this);

        PickUp();
    }


    private void After()
    {
        _input.ChangeInteraction(true);
        exitInpectEvent.Invoke();
    }


    private void PickUp()
    {
        var takeAmount = inventory.Add(item);
        item.amount -= takeAmount;

        if (takeAmount == 0) return;

        // if (item.amount <= 0)
        // {            
        _input.ChangeInteraction(true);
        pickupEvent?.Invoke();
        gameObject.SetActive(false);
        // }
    }
}