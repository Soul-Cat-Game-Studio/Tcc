using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State Machine/ Condition/ Player/ Is Running", fileName = "Is Running")]
public class IsRunningCO : Condition
{
    [SerializeField] private PlayerControl control;

    public override bool Decide(StateMachine stateMachine)
    {      
        return control.isRunning;
    }
}
