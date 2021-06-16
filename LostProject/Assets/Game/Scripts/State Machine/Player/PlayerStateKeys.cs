using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State Machine/ Keys Data/ Player", fileName = "PlayerKeys")]
public class PlayerStateKeys : StateMachineKeys
{

    #region  Components
    public readonly string animator = "Animator";
    public readonly string player = "Player";
    public readonly string characterController = "CharacterController";

    #endregion


    #region  Variables


    #endregion


    #region  Animation
    public readonly string animhorizontal = "Horizontal";
    public readonly string animvertical = "Vertical";
    public readonly string animMoveSpeed = "MoveSpeed";
    public readonly string animIsMovin = "IsMoving";
    public readonly string animIsRunning = "IsRunning";
    public readonly string animIsCrouching = "IsCrouching";

    #endregion




    public override void CreatKeys(StateMachineData stateMachineData)
    {
        var player = stateMachineData.GetComponent<Transform>();
        var animator = stateMachineData.GetComponent<Animator>();
        var characterController = stateMachineData.GetComponent<CharacterController>();        

        stateMachineData.CacheData(this.animator, animator);
        stateMachineData.CacheData(this.player, player);
        stateMachineData.CacheData(this.characterController, characterController);
    }
}