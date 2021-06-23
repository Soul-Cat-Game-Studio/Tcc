using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static InputReader;

[CreateAssetMenu(fileName = "PlayerSettings", menuName = "Player/Player Settings", order = 0)]
public class PlayerSettings : ScriptableObject
{
    public InputReader inputReader;

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
    [Range(1, 200)]
    public float gamepadSensitivityY;


    public float currentSensitivityX, currentSensitivityY;
    public bool currentInvertXAxis, currentInvertYAxis;

    private void OnEnable()
    {
        inputReader.ChangeDeviceEvent += ChangeDevice;
    }

    private void OnDisable()
    {
        inputReader.ChangeDeviceEvent -= ChangeDevice;
    }

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
