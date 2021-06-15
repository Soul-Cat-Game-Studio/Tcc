using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CinemachineInput : CinemachineInputProvider
{
    [Space(20)]
    public InputReader input;
    public bool canMove = false;

    private void OnEnable()
    {
        input.CanLookEvent += EnableLook;
        input.CantLookEvent += DisableLook;
    }

    private void OnDisable()
    {
        input.CanLookEvent -= EnableLook;
        input.CantLookEvent -= DisableLook;
    }


    private void EnableLook() { canMove = true; }

    private void DisableLook() { canMove = false; }


    public override float GetAxisValue(int axis)
    {
        if (!canMove) return 0;
        return base.GetAxisValue(axis);
    }
}