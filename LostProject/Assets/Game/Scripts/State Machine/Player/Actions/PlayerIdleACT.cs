using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State Machine/ Action/ Player/ Idle", fileName = "Player Idle ACT")]
public class PlayerIdleACT : Action
{  
    [SerializeField] private PlayerStateKeys _keys; 
    
    public override void ActUpdate(StateMachine stateMachine)
    {
        var stateData = stateMachine.StateData; 

        // stateData.GetData<Animator>(_keys.animator, out var animator);

        // animator.SetFloat(_keys.animhorizontal, 0, 0.1f, Time.deltaTime);
        // animator.SetFloat(_keys.animvertical, 0, 0.1f, Time.deltaTime);
    }   
}
