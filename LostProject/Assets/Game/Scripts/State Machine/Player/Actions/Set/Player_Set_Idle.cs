using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Cysharp.Threading;
using Cysharp.Threading.Tasks;
using Cinemachine;

[CreateAssetMenu(menuName = "State Machine/ Action/ Player/ Velocity/ Set Idle", fileName = "Player_Set_Idle_Velocity_ACT")]
public class Player_Set_Idle : Action
{
    [SerializeField] private PlayerControl playerControl;
    [SerializeField] private PlayerSettings _settings;
    [SerializeField] private PlayerStateKeys _keys;

    public override void ActEnter(StateMachine stateMachine)
    {
        var stateData = stateMachine.StateData;

        // stateData.GetData<Animator>(_keys.animator, out var animator);
        stateData.GetData<CharacterController>(_keys.characterController, out var controller);


        // animator.SetBool(_keys.animIsMovin, false);
        // animator.SetBool(_keys.animIsCrouching, false);
        playerControl.isCrouching = false;


        if (controller.height != _settings.standUp) controller.height = _settings.standUp;

    }
}
