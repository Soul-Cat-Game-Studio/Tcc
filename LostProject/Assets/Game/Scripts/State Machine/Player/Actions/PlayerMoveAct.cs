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

        stateData.GetData<Transform>(_keys.player, out var player);

        stateData.GetData<CharacterController>(_keys.characterController, out var controller);
        

        // stateData.GetData<Animator>(_keys.animator, out var animator);
        

        var move = (player.right * _control.moveValue.x + player.forward * _control.moveValue.y);

        controller.Move(move * _settings.currentVelocity * Time.deltaTime);

        // animator.SetFloat(_keys.animhorizontal, playerController.moveValue.x, 0.1f, Time.deltaTime);
        // animator.SetFloat(_keys.animvertical, playerController.moveValue.y, 0.1f, Time.deltaTime);
    }
}
