using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    //Look Obj
    void EnterProximity();

    void ExitProximity();


    void EnterLook();
    void ExitLook();


    void EnterUI();
    void ExitUI();
}