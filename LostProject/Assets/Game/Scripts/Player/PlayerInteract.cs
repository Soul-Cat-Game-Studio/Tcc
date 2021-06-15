using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public StateMachineData stateData;
    public PlayerStateKeys keys;
    public InputReader input;

    public InteractView interactView;

    private PlayerController _playerController;

    private void Awake()
    {
        _playerController = GetComponent<PlayerController>();
    }

    private void OnEnable()
    {
        input.GameplayPrimaryActionEvent += HandlerPrimartAction;
        input.GameplaySecondActionEvent += HandlerSecondAction;

        input.CanInteractEvent += UpdateCanInteract;
    }


    private void OnDisable()
    {
        input.GameplayPrimaryActionEvent -= HandlerPrimartAction;
        input.GameplaySecondActionEvent -= HandlerSecondAction;

        input.CanInteractEvent -= UpdateCanInteract;
    }


    public void HandlerPrimartAction()
    {
        if (!_playerController.canInteract || interactView.currentActions == null) return;

        interactView.currentActions?.DoPrimaryAction();
    }

    public void HandlerSecondAction()
    {
        if (!_playerController.canInteract || interactView.currentActions == null) return;

        interactView.currentActions?.DoSecondAction();
    }


    private void UpdateCanInteract(bool f)
    {
        _playerController.canInteract = f;
    }
}