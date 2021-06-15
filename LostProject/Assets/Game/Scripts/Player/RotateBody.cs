using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBody : MonoBehaviour
{
    private Transform _cam;

    private void Awake()
    {
        _cam = Camera.main.transform;
    }

    private void LateUpdate()
    {
        UpdateRotation();
    }

    private void UpdateRotation()
    {
        var rotDir = new Vector3(_cam.rotation.eulerAngles.x, _cam.rotation.eulerAngles.y, 0);
        transform.rotation = Quaternion.Euler(rotDir);
    }
}
