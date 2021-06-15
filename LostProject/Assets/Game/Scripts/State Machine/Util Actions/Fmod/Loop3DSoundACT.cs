using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

[CreateAssetMenu(menuName = "State Machine/ Action/ Util/ Loop 3D Sound", fileName = "Loop -- Sound ACT")]
public class Loop3DSoundACT : Action
{
    public SampleSound[] sounds;

   
    public override void ActEnter(StateMachine stateMachine)
    {
        foreach (var item in sounds)
        {
            item.InicializeSound();
        }
    }

    public override void ActUpdate(StateMachine stateMachine)
    {
        foreach (var item in sounds)
        {
            item.Update3DSound(stateMachine);
        }
    }

    public override void ActExit(StateMachine stateMachine)
    {
        foreach (var item in sounds)
        {
            item.FinishSound();
        }
    }
}
