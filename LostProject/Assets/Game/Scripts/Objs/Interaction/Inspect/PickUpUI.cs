using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpUI : MonoBehaviour
{
    [SerializeField] private InputReader _input;
    private ObjInteractBase _action;


    private void OnEnable()
    {
        _input.InspectPrimaryActionEvent += DropOff;
        _input.InspectSecondActionEvent += Pickup;
    }

    private void OnDisable()
    {
        _input.InspectPrimaryActionEvent -= DropOff;
        _input.InspectSecondActionEvent -= Pickup;
    }

    private void DropOff()
    {
        _action?.DoPrimaryActionBack();
        OffInteraction();
    }

    private void Pickup()
    {
        _action?.DoSecondActionBack();
        OffInteraction();
    }


    public void SetInspection(ObjInteractBase objBase)
    {
        _action = objBase;
    }

    public void OffInteraction()
    {
        _action = null;
    }
}
