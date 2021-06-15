using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State Machine/ Action/ Player/ Velocity/ Player_Set_Run", fileName = "Player_Set_Run_ACT")]
public class Player_Set_Run : Action
{
    [SerializeField] private PlayerConfiguration _config;
    [SerializeField] private PlayerStateKeys _keys;

    public override void ActEnter(StateMachine stateMachine)
    {      
       var stateData = stateMachine.StateData;

        stateData.GetData<Animator>(_keys.animator, out var animator);
        
        animator.SetBool(_keys.animIsMovin, true);
        animator.SetBool(_keys.animIsRunning, true);
    }

    public override void ActExit(StateMachine stateMachine)
    {
        var stateData = stateMachine.StateData;

        stateData.GetData<Animator>(_keys.animator, out var animator);
        animator.SetBool(_keys.animIsMovin, false);
        animator.SetBool(_keys.animIsRunning, false);
    }
}
