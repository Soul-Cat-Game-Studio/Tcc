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

    #region Movement        

    public event UnityAction<Vector2> MoveEvent = delegate { };
    public event UnityAction<Vector2> LookEvent = delegate { };
    public event UnityAction RunEvent = delegate { };
    public event UnityAction CrouchEvent = delegate { };

    #endregion

    public event UnityAction UseEvent = delegate { };
    public event UnityAction InventoryEvent = delegate { };

    public event UnityAction PauseEvent = delegate { };

    private InputActionMap _previouInputMap;
    private InputActionMap _currentInputMap;

    private GameInput gameInput;



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

    #region Change Input   

    public void DisableAllInput()
    {
        gameInput.Gameplay.Disable();
        gameInput.Inspection.Disable();
        gameInput.Inventory.Disable();
        gameInput.Pause.Disable();
    }

    private void SetCurrentMap(InputActionMap inputMap)
    {
        SetPreviousMap(_currentInputMap);
        _currentInputMap = inputMap;
        _currentInputMap.Enable();
    }

    private void SetPreviousMap(InputActionMap inputMap)
    {
        _previouInputMap = inputMap;
        _previouInputMap.Disable();
    }


    public void EnableLastInput() => SetCurrentMap(_previouInputMap);

    public void EnableGameplayInput() => SetCurrentMap(gameInput.Gameplay);

    public void EnableInspectInput() => SetCurrentMap(gameInput.Inspection);

    public void EnableInventoryInput() => SetCurrentMap(gameInput.Inventory);

    public void EnablePauseInput() => SetCurrentMap(gameInput.Pause);

    #endregion


    #region Movement

    public void OnMove(InputAction.CallbackContext context)
    {
        MoveEvent.Invoke(context.ReadValue<Vector2>());
    }

    public void OnRun(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                RunEvent.Invoke();
                break;
        }
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        LookEvent.Invoke(context.ReadValue<Vector2>());
    }

    public void OnCrouching(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                CrouchEvent.Invoke();
                break;
        }
    }

    #endregion


    public void OnInteraction(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                UseEvent.Invoke();
                break;
        }
    }

    public void OnInventory(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                InventoryEvent.Invoke();
                break;
        }
    }

    public void OnPauseGame(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                PauseEvent.Invoke();
                break;
        }
    }
}
