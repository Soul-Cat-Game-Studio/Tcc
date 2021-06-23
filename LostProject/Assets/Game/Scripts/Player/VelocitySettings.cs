using System;
using UnityEngine;

[Serializable]
public class VelocitySettings
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
