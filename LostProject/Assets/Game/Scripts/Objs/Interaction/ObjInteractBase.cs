using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjInteractBase : MonoBehaviour, IInteractable, IInteractionActions
{
    public InputReader input;
    public SpriteRenderer uiProximity;
    public UiObserver uiObserver;

    [HideInInspector] public UiObserver.TypeOfUi uiType;

    private bool _used;

    private void OnEnable()
    {
        input.EnterGamplayMapEevnt += UiObjActivation;
        input.ExitGamplayMapEevnt += UiObjDeactivation;
    }

    private void OnDisable()
    {
        input.EnterGamplayMapEevnt -= UiObjActivation;
        input.ExitGamplayMapEevnt -= UiObjDeactivation;
    }


    private void UiObjActivation() { uiProximity.gameObject.SetActive(true); }

    private void UiObjDeactivation() { uiProximity.gameObject.SetActive(false); }


    public virtual void EnterProximity()
    {
        uiProximity.enabled = true;
    }

    public virtual void ExitProximity()
    {
        if (uiProximity == null) return;

        uiProximity.enabled = false;
    }

    public virtual void EnterLook()
    {
        ExitProximity();
        EnterUI();
    }

    public virtual void ExitLook()
    {
        EnterProximity();
        ExitUI();
    }

    public virtual void EnterUI() { uiObserver.ActivateGameplayCanvas(uiType); }

    public virtual void ExitUI() { uiObserver.DeactivateGameplayCanvas(uiType); }

    public void UseOnce()
    {
        ExitLook();
        ExitProximity();
    }

    public bool CheckUse() { return _used; }


    public virtual void DoPrimaryAction() { _used = true; }

    public virtual void DoPrimaryActionBack() { return; }


    public virtual void DoSecondAction() { return; }

    public virtual void DoSecondActionBack() { return; }
}
