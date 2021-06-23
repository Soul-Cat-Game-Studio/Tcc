using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Cinemachine;

public class FpsCamera : MonoBehaviour
{
    [SerializeField] private InputReader _input;
    [SerializeField] private PlayerControl _control;
    public PlayerSettings settings;

    [Space(20)]

    [SerializeField] private Transform _camHolder;

    private Vector2 _look;

    private Vector2 _camRot;
    


    private void OnEnable()
    {
        _input.LookEvent += UpdateLookInput;
    }

    private void OnDisable()
    {
        _input.LookEvent -= UpdateLookInput;
    }

    private void Start()
    {
        _camRot = transform.localRotation.eulerAngles;
    }

    private void Update()
    {
        UpdateBodyRotation();
        UpdateLook();
    }

    private void UpdateBodyRotation()
    {
        if (!_control.canMove) return;

        //Rotate Left & Right
        var rotY = settings.currentSensitivityX * (settings.currentInvertXAxis ? -_look.x : _look.x) * Time.deltaTime;
        transform.Rotate(0, rotY, 0, Space.World);

    }

    private void UpdateLook()
    {
        //Look Up & Down
        _camRot.x += settings.currentSensitivityY * (settings.currentInvertYAxis ? _look.y : -_look.y) * Time.deltaTime;
        _camRot.x = Mathf.Clamp(_camRot.x, _control.cameraLimitY.x, _control.cameraLimitY.y);


        // Look Left & Right

        if (!_control.canMove)
        {
            _camRot.y += settings.currentSensitivityX * (settings.currentInvertXAxis ? -_look.x : _look.x) * Time.deltaTime;
            _camRot.y = Mathf.Clamp(_camRot.y, _control.cameraLimitX.x, _control.cameraLimitX.y);
        }



        _camHolder.localRotation = Quaternion.Euler(_camRot);
    }


    private void UpdateLookInput(Vector2 pos)
    {
        _look = pos;
        _control.camMoveValue = pos;
    }
}
