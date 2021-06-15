using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObjsToUse :ObjInteractBase
{
    
    [Space(20)]
    public UnityEvent useEvent;


    private void Start() 
    {
        uiType = UiObserver.TypeOfUi.Use;
    }

    public override void EnterProximity()
    {
        base.EnterProximity();
    }

    public override void ExitProximity()
    {
        base.ExitProximity();
    }

    public override void DoPrimaryAction()
    {
        base.DoPrimaryAction();
        
        useEvent.Invoke();
    } 
}
