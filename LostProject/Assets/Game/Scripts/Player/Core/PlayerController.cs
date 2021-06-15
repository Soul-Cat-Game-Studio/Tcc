using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public StateMachineData stateData;
    public PlayerStateKeys keys;
    public InputReader input;
    public PlayerConfiguration configuration;



    public bool canMove;

    public bool isMoving;

    public bool isRunning;

    public Vector2 moveValue;

    public bool canCrouch;

    public bool isCrouching;

    public bool canInteract;

    public LayerMask ignoreLayer;
    private CharacterController _characterController;

    private void Awake()
    {
        _characterController =  GetComponent<CharacterController>();
    }

    private void OnEnable()
    {
        input.GameplayRunHoldEvent += HandlerRunningHold;

        input.GameplayRunCancelEvent += HandlerRunningCancel;

        input.GameplayMoveEvent += HandlerMovement;

        input.GameplayCrouchEvent += HandlerCrouching;
    }


    private void OnDisable()
    {
        input.GameplayRunHoldEvent -= HandlerRunningHold;

        input.GameplayRunCancelEvent -= HandlerRunningCancel;

        input.GameplayMoveEvent -= HandlerMovement;

        input.GameplayCrouchEvent -= HandlerCrouching;
    }


    public void HandlerMovement(Vector2 pos)
    {
        if (!canMove) return;

        moveValue = pos;
        var mov = pos.sqrMagnitude > 0f;
        isMoving = mov;
    }

    public void HandlerRunningHold()
    {
        if (!canMove) return;

        isRunning = true;
    }

    private void HandlerRunningCancel()
    {
        isRunning = false;
    }

    public void HandlerCrouching()
    {
        if (!canCrouch) return;

        if (isCrouching)
            if (!CanStadUp()) return;

    }

    private bool CanStadUp()
    {
        var lowerCenter = transform.position + Vector3.up * _characterController.radius;

        var radius = _characterController.radius - Physics.defaultContactOffset;

        if (Physics.SphereCast(lowerCenter, radius, Vector3.up, out var hit, configuration.standUp, ~ignoreLayer, QueryTriggerInteraction.Ignore))
            return false;

        else
            return true;
    }
}
