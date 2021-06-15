using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjLookAtCamera : MonoBehaviour
{
    private Camera _cam;

    void Awake()
    {
        _cam = Camera.main;
    }

    void Update()
    {
        transform.rotation = Quaternion.LookRotation(new Vector3(_cam.transform.forward.x, 0, _cam.transform.forward.z));
    }
}
