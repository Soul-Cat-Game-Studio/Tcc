using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "InputReader", menuName = "Game/Input Reader")]
public class InputReader : ScriptableObject, GameInput.IGameplayActions, GameInput.IInspectionActions,
 GameInput.IInventoryActions, GameInput.IPauseActions
{

    // Assign delegate{} to events to initialise them with an empty delegate
    // so we can skip the null check when we use them

    #region Gameplay    


    public event UnityAction PauseEvent = delegate { };

    public event UnityAction CanLookEvent = delegate { };
    public event UnityAction CantLookEvent = delegate { };

    public event UnityAction<bool> CanInteractEvent = delegate { };



    public event UnityAction<Vector2> GameplayMoveEvent = delegate { };
    public event UnityAction<Vector2> GameplayLookEvent = delegate { };
    public event UnityAction GameplayRunHoldEvent = delegate { };
    public event UnityAction GameplayRunCancelEvent = delegate { };
    public event UnityAction GameplayCrouchEvent = delegate { };
    public event UnityAction GameplayVaultEvent = delegate { };



    public event UnityAction GameplayPrimaryActionEvent = delegate { };
    public event UnityAction GameplaySecondActionEvent = delegate { };

    public event UnityAction GameplayInventoryAccessEvent = delegate { };


    //Lampião
    public event UnityAction<float> GameplayFlashSwitchEvent = delegate { };
    public event UnityAction GameplayFlashTurnOffEvent = delegate { };
    public event UnityAction GameplayFlashTurnOnEvent = delegate { };
    public event UnityAction GameplayFlashRechargeEvent = delegate { };

    #endregion


    #region Inspect

    public event UnityAction<Vector2> InspectRotateObjEvent = delegate { };
    public event UnityAction InspectPrimaryActionEvent = delegate { };
    public event UnityAction InspectSecondActionEvent = delegate { };

    #endregion

    #region Inventory
    public event UnityAction InventoryDeaccessEvent = delegate { };

    #endregion

    #region  Action Maps
    public event UnityAction EnterGamplayMapEevnt = delegate { };
    public event UnityAction ExitGamplayMapEevnt = delegate { };

    public event UnityAction EnterInventoryMapEevnt = delegate { };
    public event UnityAction ExitInventoryMapEevnt = delegate { };

    public event UnityAction EnterInspectMapEevnt = delegate { };
    public event UnityAction ExitInspectMapEevnt = delegate { };

    public event UnityAction EnterPauseMapEevnt = delegate { };
    public event UnityAction ExitPauseMapEevnt = delegate { };

    public enum ActionMapCallEvent
    {
        Gameplay,
        Inventory,
        Inspect,
        Pause
    }

    private ActionMapCallEvent lastActionMapCall;
    private ActionMapCallEvent currentActionMapCall;

    public enum ActionMapStateCallEvent
    {
        Enter,
        Exit
    }
    #endregion


    private GameInput gameInput;

    private InputActionMap lastInputMap;

    private InputActionMap currentInputMap;




    private void OnEnable()
    {
        if (gameInput == null)
        {
            gameInput = new GameInput();

            gameInput.Gameplay.SetCallbacks(this);
            gameInput.Inspection.SetCallbacks(this);
            gameInput.Inventory.SetCallbacks(this);
            gameInput.Pause.SetCallbacks(this);
        }

        DisableAllInput();
        EnableGameplayInput(); //Tirar
    }

    private void OnDisable()
    {
        DisableAllInput();
    }

    public void ChangeInteraction(bool can)
    {
        CanInteractEvent.Invoke(can);
    }


    #region Action Maps

    public void ActionCallEvent(ActionMapCallEvent call, ActionMapStateCallEvent state)
    {
        switch (call)
        {
            case ActionMapCallEvent.Gameplay:

                switch (state)
                {
                    case ActionMapStateCallEvent.Enter:
                        CanLookEvent.Invoke();
                        EnterGamplayMapEevnt.Invoke();
                        break;

                    case ActionMapStateCallEvent.Exit:
                        CantLookEvent.Invoke();

                        ExitGamplayMapEevnt.Invoke();
                        break;
                }

                break;

            case ActionMapCallEvent.Inventory:

                switch (state)
                {
                    case ActionMapStateCallEvent.Enter:
                        EnterInventoryMapEevnt.Invoke();
                        break;

                    case ActionMapStateCallEvent.Exit:
                        ExitInventoryMapEevnt.Invoke();
                        break;
                }

                break;

            case ActionMapCallEvent.Inspect:

                switch (state)
                {
                    case ActionMapStateCallEvent.Enter:
                        EnterInspectMapEevnt.Invoke();
                        break;

                    case ActionMapStateCallEvent.Exit:
                        ExitInspectMapEevnt.Invoke();
                        break;
                }

                break;

            case ActionMapCallEvent.Pause:

                switch (state)
                {
                    case ActionMapStateCallEvent.Enter:
                        EnterPauseMapEevnt.Invoke();
                        break;

                    case ActionMapStateCallEvent.Exit:
                        ExitPauseMapEevnt.Invoke();
                        break;
                }

                break;
        }
    }


    #endregion

    #region Change Input   

    public void DisableAllInput()
    {
        gameInput.Gameplay.Disable();
        gameInput.Inspection.Disable();
        gameInput.Inventory.Disable();
        gameInput.Pause.Disable();
    }

    private void EnableEspecificInput(InputActionMap input, ActionMapCallEvent call)
    {
        lastActionMapCall = currentActionMapCall;
        lastInputMap = currentInputMap;

        ActionCallEvent(lastActionMapCall, ActionMapStateCallEvent.Exit);
        lastInputMap?.Disable();

        currentActionMapCall = call;
        currentInputMap = input;

        currentInputMap?.Enable();
        ActionCallEvent(currentActionMapCall, ActionMapStateCallEvent.Enter);
    }

    public void EnableLastInput()
    {
        currentActionMapCall = lastActionMapCall;
        currentInputMap = lastInputMap;

        EnableEspecificInput(currentInputMap, currentActionMapCall);
    }


    public void EnableGameplayInput()
    {
        EnableEspecificInput(gameInput.Gameplay, ActionMapCallEvent.Gameplay);
    }

    public void EnableInspectInput()
    {
        EnableEspecificInput(gameInput.Inspection, ActionMapCallEvent.Inspect);
    }

    public void EnableInventoryInput()
    {
        EnableEspecificInput(gameInput.Inventory, ActionMapCallEvent.Inventory);
    }

    public void EnablePauseInput()
    {
        EnableEspecificInput(gameInput.Pause, ActionMapCallEvent.Pause);
    }

    #endregion


    #region Gameplay
    public void OnMove(InputAction.CallbackContext context)
    {
        GameplayMoveEvent.Invoke(context.ReadValue<Vector2>());
    }

    public void OnRun(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                GameplayRunHoldEvent.Invoke();
                break;
            case InputActionPhase.Canceled:
                GameplayRunCancelEvent.Invoke();
                break;
        }
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        GameplayLookEvent.Invoke(context.ReadValue<Vector2>());
    }

    public void OnCrouching(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                GameplayCrouchEvent.Invoke();
                break;
        }
    }

    public void OnVault(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                GameplayVaultEvent.Invoke();
                break;
        }
    }

    public void OnPrimaryAction(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                GameplayPrimaryActionEvent.Invoke();
                break;
        }
    }

    public void OnSecondAction(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                GameplaySecondActionEvent.Invoke();
                break;
        }
    }

    public void OnInventoryAccess(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                GameplayInventoryAccessEvent.Invoke();
                break;
        }
    }

    public void OnLightOn(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                GameplayFlashTurnOnEvent.Invoke();
                break;
        }
    }

    public void OnLightOff(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                GameplayFlashTurnOffEvent.Invoke();
                break;
        }
    }

    public void OnLightSwitch(InputAction.CallbackContext context)
    {
        GameplayFlashSwitchEvent.Invoke(context.ReadValue<float>());
    }

    public void OnRechargeOil(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                GameplayFlashRechargeEvent.Invoke();
                break;
        }
    }
    #endregion


    #region Inpection


    void GameInput.IInspectionActions.OnRotate(InputAction.CallbackContext context)
    {
        InspectRotateObjEvent.Invoke(context.ReadValue<Vector2>());
    }

    void GameInput.IInspectionActions.OnPrimaryActionInspect(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                InspectPrimaryActionEvent.Invoke();
                break;
        }
    }

    void GameInput.IInspectionActions.OnSecondActionInspect(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                InspectSecondActionEvent.Invoke();
                break;
        }
    }


    #endregion


    #region Inventory
    public void OnInventoryDeaccess(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                InventoryDeaccessEvent.Invoke();
                break;
        }
    }

    public void OnPauseMenu(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                PauseEvent.Invoke();
                break;
        }
    }



    #endregion

}
