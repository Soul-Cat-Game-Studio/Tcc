using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Cinemachine;

public class FpsCamera : MonoBehaviour
{
    [SerializeField] private InputReader _input;
    [SerializeField] private PlayerControl _playerControl;
    public PlayerSettings settings;

    [Space(20)]

    [SerializeField] private Transform _camHolder;

    private Vector2 _look;

    private Vector2 _camRot;
    private Vector2 _playerRot;


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
        _playerRot = transform.localRotation.eulerAngles;
        _camRot = transform.localRotation.eulerAngles;

    }

    private void Update()
    {
        UpdateBodyRotation();
        UpdateLook();
    }

    private void UpdateBodyRotation()
    {
        if (!_playerControl.canMove) return;

        //Rotate Left & Right
        _playerRot.y += settings.currentSensitivityX * (settings.currentInvertXAxis ? -_look.x : _look.x) * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(_playerRot);
    }

    private void UpdateLook()
    {
        //Look Up & Down
        _camRot.x += settings.currentSensitivityY * (settings.currentInvertYAxis ? _look.y : -_look.y) * Time.deltaTime;
        _camRot.x = Mathf.Clamp(_camRot.x, settings.cameraLimitY.x, settings.cameraLimitY.y);


        // Look Left & Right

        if (!_playerControl.canMove)
        {
            _camRot.y += settings.currentSensitivityX * (settings.currentInvertXAxis ? -_look.x : _look.x) * Time.deltaTime;
            _camRot.y = Mathf.Clamp(_camRot.y, settings.cameraLimitX.x, settings.cameraLimitX.y);
        }



        _camHolder.localRotation = Quaternion.Euler(_camRot);
    }


    private void UpdateLookInput(Vector2 pos)
    {
        _look = pos;
    }
}
