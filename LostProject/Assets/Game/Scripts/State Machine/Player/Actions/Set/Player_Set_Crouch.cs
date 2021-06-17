using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Cinemachine;

[CreateAssetMenu(menuName = "State Machine/ Action/ Player/ Velocity/ Player_Set_Crouch", fileName = "Player_Set_Crouch_Velocity_ACT")]
public class Player_Set_Crouch : Action
{
    [SerializeField] private PlayerSettings _settings;
    public PlayerControl playerControl;
    [SerializeField] private PlayerStateKeys _keys;

    public override void ActEnter(StateMachine stateMachine)
    {        

        var stateData = stateMachine.StateData;

        // stateData.GetData<Animator>(_keys.animator, out var animator);
        stateData.GetData<CharacterController>(_keys.characterController, out var controller);

        // animator.SetBool(_keys.animIsMovin, false);
        // animator.SetBool(_keys.animIsCrouching, true);

        playerControl.isCrouching = true;
        if(controller.height != _settings.standDown) controller.height = _settings.standDown;      
    }
}