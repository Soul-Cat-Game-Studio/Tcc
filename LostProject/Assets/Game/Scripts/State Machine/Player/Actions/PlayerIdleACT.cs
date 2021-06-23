using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State Machine/ Action/ Player/ Idle", fileName = "Player Idle ACT")]
public class PlayerIdleAct : Action
{
    [SerializeField] private PlayerStateKeys _keys;
    [SerializeField] private PlayerControl _control;

    //Try to awake
    private PlayerAnimations _animations;
    private CharacterController _characterController;


    public override void ActAwake(StateMachine stateMachine)
    {
        var stateData = stateMachine.StateData;
        stateData.GetData<CharacterController>(_keys.characterController, out _characterController);
    }

    public override void ActEnter(StateMachine stateMachine)
    {

        _control.isRunning = false;
        _control.isCrouching = false;


        if (_characterController.height != _control.standUp)
            _characterController.height = _control.standUp;
    }

    public override void ActUpdate(StateMachine stateMachine)
    {
        var stateData = stateMachine.StateData;

        stateData.GetData<PlayerAnimations>(_keys.animations, out var animations);

        animations.SetFloat(animations.moveSpeed, 0, .1f);
    }
}
