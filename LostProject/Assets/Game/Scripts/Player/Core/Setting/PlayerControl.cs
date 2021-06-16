using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerControl", menuName = "Player/Player Control", order = 0)]
public class PlayerControl : ScriptableObject
{
    [Header("Movement")]
    public bool canMove;
    public bool isMoving;

    public bool canRun;
    public bool isRunning;
    public Vector2 moveValue;


    [Header("Crouch")]
    public bool canCrouch;
    public bool isCrouching;

    [Header("Interacion")]
    public bool canInteract;

    public void Inicialization()
    {
        canMove = true;
        canRun = true;
        canCrouch = true;
    }

}