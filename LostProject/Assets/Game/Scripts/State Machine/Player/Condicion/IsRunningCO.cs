using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State Machine/ Condition/ Player/ Is Running", fileName = "Is Running")]
public class IsRunningCO : Condition
{
    [SerializeField] private PlayerStateKeys _keys;

    public override bool Decide(StateMachine stateMachine)
    {
        var stateData = stateMachine.StateData;

        stateData.GetData<PlayerController>(_keys.playerController, out var playerController);
        
        return playerController.isRunning;
    }
}
