using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static InputReader;

[CreateAssetMenu(fileName = "PlayerSettings", menuName = "Player/Player Settings", order = 0)]
public class PlayerSettings : ScriptableObject
{
    public enum velocity
    {
        Walk,
        Run,
        Crouch,
    }

    public InputReader inputReader;


    [Header("Movement")]

    public bool anormalMove;

    public velocity velocitySelected;

    public float currentVelocity { get { return _currentVelocity; } }
    private float _currentVelocity;


    [Range(1, 10)]
    [SerializeField] private float _walkVelocity;
    [Range(1, 10)]
    [SerializeField] private float _anormalWalkVelocity;

    [Space(10)]

    [Range(1, 10)]
    [SerializeField] private float _crouchVelocity;
    [Range(1, 10)]
    [SerializeField] private float _anormalCrouchVelocity;

    [Space(10)]

    [Range(1, 10)]
    [SerializeField] private float _runVelocity;
    [Range(1, 10)]
    [SerializeField] private float _anormalRunVelocity;

    [Space(10)]

    [Header("Mouse Settings")]

    public bool mouseInvertXAxis;
    [Range(1, 10)]
    public float mouseSensitivityX;

    public bool mouseInvertYAxis;
    [Range(1, 10)]
    public float mouseSensitivityY;

    [Space(10)]

    [Header("Gamepad Settings")]

    public bool gamepadInvertXAxis;
    [Range(1, 200)]
    public float gamepadSensitivityX;

    public bool gamepadInvertYAxis;
    [Range(1,200)]
    public float gamepadSensitivityY;


    public float currentSensitivityX, currentSensitivityY;
    public bool currentInvertXAxis, currentInvertYAxis;

    [Space(10)]

    public Vector2 cameraLimitY;
    public Vector2 cameraLimitX;



    [Header("altura")]
    public float standUp = 1.73f;
    public float standDown = 0.5f;



    private void OnEnable()
    {
        inputReader.ChangeDeviceEvent += ChangeDevice;
    }

    private void OnDisable()
    {
        inputReader.ChangeDeviceEvent -= ChangeDevice;
    }


    public void Inicialize()
    {
        anormalMove = false;
    }

    #region Velocity

    public void changeVelocity(velocity velSpeed)
    {
        if (!anormalMove)
            ChangeToNormalVelocity(velSpeed);
        else
            ChangeToAnormalVelocity(velSpeed);
    }

    private void ChangeToNormalVelocity(velocity velSpeed)
    {
        switch (velSpeed)
        {
            case velocity.Walk:
                _currentVelocity = _walkVelocity;
                break;

            case velocity.Run:
                _currentVelocity = _runVelocity;
                break;

            case velocity.Crouch:
                _currentVelocity = _crouchVelocity;
                break;
        }
    }

    private void ChangeToAnormalVelocity(velocity velSpeed)
    {
        switch (velSpeed)
        {
            case velocity.Walk:
                _currentVelocity = _anormalWalkVelocity;
                break;

            case velocity.Run:
                _currentVelocity = _anormalRunVelocity;
                break;

            case velocity.Crouch:
                _currentVelocity = _anormalCrouchVelocity;
                break;
        }
    }

    #endregion

    private void ChangeDevice(ControlDeviceType controlDeviceType)
    {
        if (controlDeviceType == ControlDeviceType.Keyboard)
        {
            currentSensitivityX = mouseSensitivityX;
            currentSensitivityY = mouseSensitivityY;

            currentInvertXAxis = mouseInvertXAxis;
            currentInvertYAxis = mouseInvertYAxis;
        }
        else
        {
            currentSensitivityX = gamepadSensitivityX;
            currentSensitivityY = gamepadSensitivityY;

            currentInvertXAxis = gamepadInvertXAxis;
            currentInvertYAxis = gamepadInvertYAxis;
        }
    }


}
