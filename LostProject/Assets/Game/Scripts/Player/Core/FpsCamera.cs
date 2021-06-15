using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Cinemachine;

public class FpsCamera : MonoBehaviour
{
    [SerializeField] private InputReader _input;
    [SerializeField] private PlayerConfiguration _config;

    [Space(20)]

    [SerializeField] private Transform _camHolder;
    [SerializeField] private Vector2 limitCam;
    public float smoothY = 2f;
    public float smoothX = 2f;


    private Vector2 _look;
    private float _camPitch;
    private float rx;

    private Vector2 _camRot;
    private Vector2 _playerRot;


    private void OnEnable()
    {
        _input.GameplayLookEvent += UpdateLookInput;

    }

    private void OnDisable()
    {
        _input.GameplayLookEvent -= UpdateLookInput;
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
        _playerRot.y += _config.mouseSensitivityX * _look.x * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(_playerRot);

        _camRot.x += _config.mouseSensitivityY * _look.y * Time.deltaTime;
        _camRot.x = Mathf.Clamp(_camRot.x, limitCam.x, limitCam.y);

        _camHolder.localRotation = Quaternion.Euler(_camRot);






        // _camPitch -= _look.y * _config.mouseSensitivityY;

        // _camPitch = Mathf.Clamp(_camPitch, limitCam.x, limitCam.y);

        // var rot = new Vector2(_camPitch,  _look.x * _config.mouseSensitivityX);

        // transform.localEulerAngles = rot;      
    }


    private void UpdateLookInput(Vector2 pos)
    {
        _look = pos;
    }


}
