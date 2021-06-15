using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

public class ObjectToRead : ObjInteractBase
{
    [SerializeField] private InputReader _input;

    public float distance = 0.4f;
    public float subtractScale;

    [Space(20)]

    private Transform _cam;

    private Vector3 _originPos, _orginRot;

    [SerializeField] private Note note;
    [SerializeField] private NoteManager noteManager;

    public UnityEvent enterInpectEvent;
    public UnityEvent exitInpectEvent;




    private void Awake() { _cam = Camera.main.transform; }

    private void OnEnable()
    {
        _originPos = transform.position;
        _orginRot = transform.rotation.eulerAngles;
    }

    private void Start() { uiType = UiObserver.TypeOfUi.Read; }



    public override void DoPrimaryAction()
    {
        base.DoPrimaryAction();

        noteManager.note = note;

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

    private void After()
    {
        _input.ChangeInteraction(true);
        exitInpectEvent.Invoke();
    }

    public override void DoSecondActionBack()
    {
        
    }
}
