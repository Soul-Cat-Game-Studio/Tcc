using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "UiObserver", menuName = "Game/Ui Observer")]
public class UiObserver : ScriptableObject
{
    //Gameplay
    public event UnityAction ActivateInspectGameplayEvent = delegate { };
    public event UnityAction DeactivateInspectGameplayEvent = delegate { };

    public event UnityAction ActivateReadGameplayEvent = delegate { };
    public event UnityAction DeactivateReadtGameplayEvent = delegate { };

    public event UnityAction ActivateUseGameplayEvent = delegate { };
    public event UnityAction DeactivateUseGameplayEvent = delegate { };

    public event UnityAction ActivatePickupGameplayEvent = delegate { };
    public event UnityAction DeactivatePickupGameplayEvent = delegate { };


    //UI
    public event UnityAction<ObjInteractBase> ActivateInspectUIEvent = delegate { };
    public event UnityAction<ObjInteractBase> DeactivateInspectUIEvent = delegate { };

    public event UnityAction<ObjInteractBase> ActivateReadUIEvent = delegate { };
    public event UnityAction<ObjInteractBase> DeactivateReadUIEvent = delegate { };

    public event UnityAction<ObjInteractBase> ActivatePickupUIEvent = delegate { };
    public event UnityAction<ObjInteractBase> DeactivatePickupUIEvent = delegate { };


    public enum TypeOfUi
    {
        Inspect,
        Pickup,
        Use,
        Read
    }


    //Gameplay
    public void ActivateGameplayCanvas(TypeOfUi uiType)
    {
        switch (uiType)
        {
            case TypeOfUi.Inspect:
                ActivateInspectGameplayEvent.Invoke();
                break;

            case TypeOfUi.Read:
                ActivateReadGameplayEvent.Invoke();
                break;

            case TypeOfUi.Use:
                ActivateUseGameplayEvent.Invoke();
                break;

            case TypeOfUi.Pickup:
                ActivatePickupGameplayEvent.Invoke();
                break;
        }
    }


    public void DeactivateGameplayCanvas(TypeOfUi uiType)
    {
        switch (uiType)
        {
            case TypeOfUi.Inspect:
                DeactivateInspectGameplayEvent.Invoke();
                break;

            case TypeOfUi.Read:
                DeactivateReadtGameplayEvent.Invoke();
                break;

            case TypeOfUi.Use:
                DeactivateUseGameplayEvent.Invoke();
                break;

            case TypeOfUi.Pickup:
                DeactivatePickupGameplayEvent.Invoke();
                break;
        }
    }



    //UI
    public void ActivateUICanvas(TypeOfUi uiType, ObjInteractBase objBase)
    {
        switch (uiType)
        {
            case TypeOfUi.Inspect:
                ActivateInspectUIEvent.Invoke(objBase);
                break;

            case TypeOfUi.Read:
                ActivateReadUIEvent.Invoke(objBase);
                break;

            case TypeOfUi.Use:

                break;

            case TypeOfUi.Pickup:
                ActivatePickupUIEvent.Invoke(objBase);
                break;
        }
    }

    public void DeactivateUICanvas(TypeOfUi uiType, ObjInteractBase objBase)
    {
        switch (uiType)
        {
            case TypeOfUi.Inspect:
                DeactivateInspectUIEvent.Invoke(objBase);
                break;

            case TypeOfUi.Read:
                DeactivateReadUIEvent.Invoke(objBase);
                break;

            case TypeOfUi.Use:

                break;

            case TypeOfUi.Pickup:
                DeactivatePickupUIEvent.Invoke(objBase);
                break;
        }
    }
}