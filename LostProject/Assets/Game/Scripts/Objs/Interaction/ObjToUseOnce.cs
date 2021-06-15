using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObjToUseOnce : ObjInteractBase
{
    [Space(20)]
    public UnityEvent useEvent;

    private ObjToUseOnce _script;




    private void Start()
    {
        uiType = UiObserver.TypeOfUi.Use;
    }

    public override void EnterProximity()
    {
        if (CheckUse()) return;

        base.EnterProximity();
    }

    public override void ExitProximity()
    {
        if (CheckUse()) return;

        base.ExitProximity();
    }

    public override void EnterLook()
    {
        if (CheckUse()) return;

        base.EnterLook();
    }

    public override void ExitLook()
    {
        if (CheckUse()) return;

        base.ExitLook();
    }

    public override void DoPrimaryAction()
    {      
        if (CheckUse()) return;

        UseOnce();       

        base.DoPrimaryAction(); 

        useEvent.Invoke();
    }
}