using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CinemachinePovExtantion : CinemachineExtension
{
    public PlayerStateKeys key;
    public StateMachineData stateMachineData;
    private Vector3 _startRot;

    protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
    {
        if (vcam.Follow)
        {
            if (stage == CinemachineCore.Stage.Aim)
            {
                if(_startRot == null) _startRot = transform.localRotation.eulerAngles;

                // stateMachineData.GetData<PlayerController>(key.playerController, out var player);

                // var deltaInput =  player.moveValue;
                var deltaInput =  Vector2.zero;

                _startRot.x += deltaInput.x * 10 * Time.deltaTime;
                _startRot.y += deltaInput.y * 10 * Time.deltaTime;

                _startRot.y = Mathf.Clamp(_startRot.y, -70f, 70f);

                state.RawOrientation = Quaternion.Euler(_startRot.y, _startRot.x, 0f);



            }
        }
    }
}
