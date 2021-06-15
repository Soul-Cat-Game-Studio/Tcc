using System.Collections;
using System.Collections.Generic;
using FMODUnity;
using UnityEngine;

[CreateAssetMenu(menuName = "State Machine/ Action/ Util/ One Shot Sound", fileName = "One Shot Sound ACT")]
public class PlayOnShotACT : Action
{
    public OneShootSound[] enterSound;

    public OneShootSound[] exitSound;

    public override void ActEnter(StateMachine stateMachine)
    {
        foreach (var item in enterSound)
        {
            if (item.fromState != null)
            {
                if (stateMachine.previousState == item.fromState)
                    item.PlaySound();
            }
            else
                item.PlaySound();
        }
    }

    public override void ActExit(StateMachine stateMachine)
    {
        foreach (var item in exitSound)
        {
            if (item.fromState != null)
            {
                if (stateMachine.previousState == item.fromState)
                    item.PlaySound();
            }
            else
                item.PlaySound();
        }
    }
}
