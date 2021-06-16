using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Cinemachine;

public class FpsCamera : MonoBehaviour
{
    [SerializeField] private InputReader _input;
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
        UpdateLook();
    }

    private void UpdateLook()
    {
        _playerRot.y += settings.mouseSensitivityX * _look.x * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(_playerRot);

        _camRot.x += settings.mouseSensitivityY * _look.y * Time.deltaTime;
        _camRot.x = Mathf.Clamp(_camRot.x, settings.cameraLimit.x, settings.cameraLimit.y);

        _camHolder.localRotation = Quaternion.Euler(_camRot);
    }


    private void UpdateLookInput(Vector2 pos)
    {
        _look = pos;
    }
}
