using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State Machine/ Condition/ Player/ Is Crouching", fileName = "Is Crouching")]
public class IsCrouchingCO : Condition
{
    [SerializeField] private PlayerStateKeys _keys;      
    [SerializeField] private PlayerControl control;


    public override bool Decide(StateMachine stateMachine)
    {       
        return control.isCrouching;
    }
}
