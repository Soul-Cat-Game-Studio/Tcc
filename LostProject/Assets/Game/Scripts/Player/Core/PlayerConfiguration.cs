using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerConfig", menuName = "Game/Player configuration")]
public class PlayerConfiguration : ScriptableObject
{
    // [Range(1, 300)]
    public float mouseSensitivityX;
    
    
    // [Range(1, 300)]
    public float mouseSensitivityY;
    

    [Space(20)]

    [Range(1, 10)]
    public float rotationSpeed;



    public enum velocity { walkVelocity, runVelocity, crouchVelocity }

    [Header("Velocity")]
    public velocity velocitySelected;


    public float currentVelocity { get { return _currentVelocity; } }
    private float _currentVelocity;


    [Range(1, 10)]
    [SerializeField] private float _walkVelocity;

    [Range(1, 10)]
    [SerializeField] private float _crouchVelocity;


    [Range(1, 10)]
    [SerializeField] private float _runVelocity;


    [Header("altura")]
    public float standUp = 1.73f;
    public float standDown = 0.5f;
    public float vaultHeight = 0.325f;

    public void changeVelocity()
    {
        switch (velocitySelected)
        {
            case velocity.walkVelocity:
                _currentVelocity = _walkVelocity;
                break;

            case velocity.runVelocity:
                _currentVelocity = _runVelocity;
                break;

            case velocity.crouchVelocity:
                _currentVelocity = _crouchVelocity;
                break;
        }
    }
}
