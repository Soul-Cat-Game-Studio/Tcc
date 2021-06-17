using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State Machine/ Action/ Player/ Idle", fileName = "Player Idle ACT")]
public class PlayerIdleAct : Action
{
    [SerializeField] private PlayerStateKeys _keys;
    [SerializeField] private PlayerControl _playerControl;
    [SerializeField] private PlayerSettings _settings;

    private PlayerAnimations _animations;
    private CharacterController _characterController;


    // public override void ActAwake(StateMachine stateMachine)
    // {

    // }

    public override void ActEnter(StateMachine stateMachine)
    {
        var stateData = stateMachine.StateData;

        stateData.GetData<CharacterController>(_keys.characterController, out var characterController);


        _playerControl.isRunning = false;
        _playerControl.isCrouching = false;


        if (characterController.height != _settings.standUp)
            characterController.height = _settings.standUp;
    }

    public override void ActUpdate(StateMachine stateMachine)
    {
        var stateData = stateMachine.StateData;

        stateData.GetData<PlayerAnimations>(_keys.animations, out var animations);

        animations.SetFloat(animations.moveSpeed, 0, .1f);
    }
}
