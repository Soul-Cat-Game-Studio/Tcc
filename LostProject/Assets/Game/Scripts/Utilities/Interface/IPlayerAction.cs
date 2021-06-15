using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerAction
{
    public StateMachineData stateData {get; set;}
    public PlayerStateKeys keys {get; set;}
    public InputReader input {get; set;}
}
