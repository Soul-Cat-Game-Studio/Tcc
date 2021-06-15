using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "StateMachineTable", menuName = "Unbound_Master_Piece/StateMachineTable", order = 0)]
public class StateMachineTable : ScriptableObject 
{
    public List<State> states;

    public void StateAwake(StateMachine stateMachine)
    {
        foreach (var item in states)
        {
            item.OnAwakeState(stateMachine);
        }
    }
}