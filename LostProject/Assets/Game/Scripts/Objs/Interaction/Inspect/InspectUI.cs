using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectUI : MonoBehaviour
{
    [SerializeField] private InputReader _input;
    private ObjInteractBase _action;


    private void OnEnable()
    {
        _input.InspectPrimaryActionEvent += DropOff;
    }

    private void OnDisable()
    {
        _input.InspectPrimaryActionEvent -= DropOff;
    }

    private void DropOff()
    {
        _action?.DoPrimaryActionBack();
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