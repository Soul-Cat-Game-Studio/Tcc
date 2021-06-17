using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public StateMachineData stateData;
    public PlayerStateKeys keys;
    public InputReader input;
    public PlayerControl control;
    public PlayerSettings settings;

    private CharacterController _characterController;

    public LayerMask ignoreLayer;


    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void OnEnable()
    {
        input.RunEvent += HandlerRunning;

        input.MoveEvent += HandlerMovement;

        input.CrouchEvent += HandlerCrouching;
    }


    private void OnDisable()
    {
        input.RunEvent -= HandlerRunning;

        input.MoveEvent -= HandlerMovement;

        input.CrouchEvent -= HandlerCrouching;
    }

    private void Start()
    {
        control.Inicialization();
        settings.Inicialize();
    }

    public void HandlerMovement(Vector2 pos)
    {
        if (!control.canMove) return;

        control.moveValue = pos;
        var mov = pos.sqrMagnitude > 0.1f;
        control.isMoving = mov;
    }

    private void HandlerRunning()
    {
        if (!control.canMove || !control.canRun || !control.isMoving) return;

        control.isRunning = !control.isRunning;
    }

    public void HandlerCrouching()
    {
        if (!control.canCrouch) return;

        if (control.isCrouching)
            if (!CanStadUp()) return;

    }

    private bool CanStadUp()
    {
        var lowerCenter = transform.position + Vector3.up * _characterController.radius;

        var radius = _characterController.radius - Physics.defaultContactOffset;

        if (Physics.SphereCast(lowerCenter, radius, Vector3.up, out var hit, settings.standUp, ~ignoreLayer, QueryTriggerInteraction.Ignore))
            return false;

        else
            return true;
    }
}
