using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State Machine/ Action/ Player/ Run", fileName = "Player Run ACT")]
public class PlayerRunAct : Action
{
    [SerializeField] private PlayerStateKeys _keys;

    public override void ActUpdate(StateMachine stateMachine)
    {
        var stateData = stateMachine.StateData;

        stateData.GetData<PlayerAnimations>(_keys.animations, out var animations);

        animations.SetFloat(animations.moveSpeed, 1, .1f);
    }
}
