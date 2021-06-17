using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State Machine/ Keys Data/ Player", fileName = "PlayerKeys")]
public class PlayerStateKeys : StateMachineKeys
{
    public readonly string animations = "Animations";
    public readonly string playerTransform = "PlayerTransform";
    public readonly string characterController = "CharacterController";


    public override void CreatKeys(StateMachineData stateMachineData)
    {
        var playerTransform = stateMachineData.GetComponent<Transform>();
        var animations = stateMachineData.GetComponent<PlayerAnimations>();
        var characterController = stateMachineData.GetComponent<CharacterController>();

        stateMachineData.CacheData(this.animations, animations);
        stateMachineData.CacheData(this.playerTransform, playerTransform);
        stateMachineData.CacheData(this.characterController, characterController);
    }
}