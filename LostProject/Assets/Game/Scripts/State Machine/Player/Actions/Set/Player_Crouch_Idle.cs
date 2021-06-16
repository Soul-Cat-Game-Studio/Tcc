using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State Machine/ Action/ Player/ Idle Crouch", fileName = "Player_IdleCroucht ACT")]
public class Player_Crouch_Idle : Action
{
    [SerializeField] private PlayerControl control;
    [SerializeField] private PlayerStateKeys _keys;

    public override void ActEnter(StateMachine stateMachine)
    {      
    //    var stateData = stateMachine.StateData;

    //     stateData.GetData<Animator>(_keys.animator, out var animator);
        
        
    //     animator.SetBool(_keys.animIsMovin, false);       

        control.isCrouching = true;

    }  
}
