using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
[CreateAssetMenu(fileName = "InputReader", menuName = "Input/Input Reader")]
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


    public event UnityAction<ControlDeviceType> ChangeDeviceEvent = delegate { };
    private ControlDeviceType _currentControlDevice;
    public enum ControlDeviceType
    {
        Keyboard,
        Mouse,
        Gamepad,
        DualShockGamepad,
    }


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

        InputSystem.onActionChange += OnChangeDevice;

        DisableAllInput();
        EnableGameplayInput(); //Tirar        
    }

    private void OnDisable()
    {
        InputSystem.onActionChange += OnChangeDevice;
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


    public void OnChangeDevice(object obj, InputActionChange change)
    {
        if (change == InputActionChange.ActionPerformed)
        {
            var inputAction = (InputAction)obj;
            var lastControl = inputAction.activeControl;
            var lastDevice = lastControl.device;

            // Debug.Log($"device: {lastDevice.displayName}");
            // Debug.Log($"device Layout: {lastDevice.layout}");

            if (InputSystem.IsFirstLayoutBasedOnSecond(lastDevice.layout, ControlDeviceType.Keyboard.ToString()) ||
           InputSystem.IsFirstLayoutBasedOnSecond(lastDevice.layout, ControlDeviceType.Mouse.ToString()))
            {
                if (_currentControlDevice != ControlDeviceType.Keyboard)
                {
                    _currentControlDevice = ControlDeviceType.Keyboard;
                    ChangeDeviceEvent.Invoke(_currentControlDevice);
                }
            }
            else if (InputSystem.IsFirstLayoutBasedOnSecond(lastDevice.layout, ControlDeviceType.Gamepad.ToString()))
            {
                if (_currentControlDevice != ControlDeviceType.Gamepad)
                {
                    _currentControlDevice = ControlDeviceType.Gamepad;
                    ChangeDeviceEvent.Invoke(_currentControlDevice);
                }
            }
            else if (InputSystem.IsFirstLayoutBasedOnSecond(lastDevice.layout, ControlDeviceType.DualShockGamepad.ToString()))
            {
                if (_currentControlDevice != ControlDeviceType.DualShockGamepad)
                {
                    _currentControlDevice = ControlDeviceType.DualShockGamepad;
                    ChangeDeviceEvent.Invoke(_currentControlDevice);
                }
            }
        }
    }

}
