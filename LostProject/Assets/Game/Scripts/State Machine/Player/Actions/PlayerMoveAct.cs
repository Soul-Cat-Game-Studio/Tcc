using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State Machine/ Action/ Player/ Move", fileName = "Player Move ACT")]
public class PlayerMoveAct : Action
{
    [SerializeField] private PlayerStateKeys _keys;
    [SerializeField] private PlayerConfiguration _config;

    public PlayerConfiguration.velocity setVelocity;
        

    public override void ActEnter(StateMachine stateMachine)
    {
        _config.velocitySelected = setVelocity;
        _config.changeVelocity();
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

        stateData.GetData<PlayerController>(_keys.playerController, out var playerController);

        // stateData.GetData<Animator>(_keys.animator, out var animator);
        

        var move = (player.right * playerController.moveValue.x + player.forward * playerController.moveValue.y);

        controller.Move(move * _config.currentVelocity * Time.deltaTime);

        // animator.SetFloat(_keys.animhorizontal, playerController.moveValue.x, 0.1f, Time.deltaTime);
        // animator.SetFloat(_keys.animvertical, playerController.moveValue.y, 0.1f, Time.deltaTime);
    }
}
