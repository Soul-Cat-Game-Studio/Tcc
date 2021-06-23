using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerControl", menuName = "Player/Player Control", order = 0)]
public class PlayerControl : ScriptableObject
{
    [Header("Camera")]
    public Vector2 camMoveValue;

    [Header("Movement")]
    public bool canMove;
    public bool isMoving;

    public bool canRun;
    public bool isRunning;
    public Vector2 moveValue;
    public VelocitySettings velocitySettings;  

    [Space(10)]



    [Header("Crouch")]
    public bool canCrouch;
    public bool isCrouching;

    [Header("Interacion")]
    public bool canInteract;

    public Vector2 cameraLimitY;
    public Vector2 cameraLimitX;



    [Header("altura")]
    public float standUp = 1.73f;
    public float standDown = 0.5f;



    public void Inicialization()
    {
        canMove = true;
        canRun = true;
        canCrouch = true;
        canInteract = true;

        velocitySettings.anormalMove = false;

        moveValue = Vector2.zero;
        isMoving = false;
        isRunning = false;
        isCrouching = false;
    }

    #region Velocity

  

    #endregion



}