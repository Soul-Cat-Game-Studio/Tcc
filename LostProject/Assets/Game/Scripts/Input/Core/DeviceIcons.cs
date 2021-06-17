using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct DeviceIcons
{
    [Header("cardinals Buttons")]
    public Sprite buttonSouth;
    public Sprite buttonNorth;
    public Sprite buttonEast;
    public Sprite buttonWest;

    [Space(10)]

    [Header("Option Buttons")]
    public Sprite startButton;
    public Sprite selectButton;

    [Space(10)]

    [Header("Triggers Buttons")]

    public Sprite leftTrigger;
    public Sprite leftShoulder;
    public Sprite rightTrigger;
    public Sprite rightShoulder;

    [Space(10)]

    [Header("Dpads Buttons")]

    public Sprite dpad;
    public Sprite dpadUp;
    public Sprite dpadDown;
    public Sprite dpadLeft;
    public Sprite dpadRight;

    [Space(10)]

    [Header("Sticks Buttons")]

    public Sprite leftStick;
    public Sprite rightStick;
    public Sprite leftStickPress;
    public Sprite rightStickPress;
}