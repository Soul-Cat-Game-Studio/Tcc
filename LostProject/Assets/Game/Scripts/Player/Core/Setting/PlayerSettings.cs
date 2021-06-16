using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerSettings", menuName = "Player/Player Settings", order = 0)]
public class PlayerSettings : ScriptableObject
{
    public enum velocity
    {
        Walk,
        Run,
        Crouch,
    }



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

    [Range(1, 10)]
    public float mouseSensitivityX;


    [Range(1, 10)]
    public float mouseSensitivityY;

    public Vector2 cameraLimit;



    [Header("altura")]
    public float standUp = 1.73f;
    public float standDown = 0.5f;


    public void Inicialize()
    {
        anormalMove = false;
    }

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
}
