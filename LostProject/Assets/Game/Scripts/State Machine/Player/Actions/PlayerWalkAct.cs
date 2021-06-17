using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State Machine/ Action/ Player/ Walk", fileName = "Player Walk ACT")]
public class PlayerWalkAct : Action
{
    [SerializeField] private PlayerStateKeys _keys;

    public override void ActUpdate(StateMachine stateMachine)
    {
        var stateData = stateMachine.StateData;

        stateData.GetData<PlayerAnimations>(_keys.animations, out var animations);

        animations.SetFloat(animations.moveSpeed, .5f, .1f);
    }
}