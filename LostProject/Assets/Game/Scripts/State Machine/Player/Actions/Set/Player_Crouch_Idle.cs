using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State Machine/ Action/ Player/ Idle Crouch", fileName = "Player_IdleCroucht ACT")]
public class Player_Crouch_Idle : Action
{
    [SerializeField] private PlayerConfiguration _config;
    [SerializeField] private PlayerStateKeys _keys;

    public override void ActEnter(StateMachine stateMachine)
    {      
       var stateData = stateMachine.StateData;

        stateData.GetData<Animator>(_keys.animator, out var animator);
        stateData.GetData<PlayerController>(_keys.animator, out var playerController);
        
        animator.SetBool(_keys.animIsMovin, false);       

        playerController.isCrouching = true;

    }  
}
