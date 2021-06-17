using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State Machine/ Action/ Player/ Move", fileName = "Player Move ACT")]
public class PlayerMoveAct : Action
{
    [SerializeField] private PlayerStateKeys _keys;
    [SerializeField] private PlayerSettings _settings;
    [SerializeField] private PlayerControl _control;

    public PlayerSettings.velocity setVelocity;


    public override void ActEnter(StateMachine stateMachine)
    {
        _settings.changeVelocity(setVelocity);
    }

    public override void ActUpdate(StateMachine stateMachine)
    {
        Walk(stateMachine);
    }

    private void Walk(StateMachine stateMachine)
    {
        var stateData = stateMachine.StateData;

        stateData.GetData<Transform>(_keys.playerTransform, out var player);

        stateData.GetData<CharacterController>(_keys.characterController, out var controller);

        var move = (player.right * _control.moveValue.x + player.forward * _control.moveValue.y);

        controller.Move(move * _settings.currentVelocity * Time.deltaTime);
    }
}
