using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sway : MonoBehaviour
{
    public PlayerControl playerControl;

    public float amount;
    public float maxAmount;
    public float smoothAmount;

    private Vector3 inicialPos;

    private Quaternion cameraRotate;
    private Quaternion currentRotate;

    public Vector2 swayLimitX;
    public Vector2 swayLimitY;

    public float velocity;
    public float smooth;

    private Transform cam;

    private void Start()
    {
        cam = Camera.main.transform;
        currentRotate = cam.rotation;
    }

    private void Update()
    {
        currentRotate = Quaternion.Lerp(currentRotate, cam.rotation, Time.deltaTime * velocity);


        var localRotate = Quaternion.Inverse(transform.rotation) * currentRotate;
        var currentEuler = localRotate.eulerAngles;

        localRotate = Quaternion.Euler(ClampSway(currentEuler.x, swayLimitX), ClampSway(currentEuler.y, swayLimitY), 0);



        transform.localRotation = Quaternion.Lerp(transform.localRotation, localRotate, Time.deltaTime * smooth);







    // transform.rotation = currentRotate;

        // var currentEuler = transform.localRotation.eulerAngles;
        // Debug.Log(currentEuler);



        // currentEuler.x = ClampSway(currentEuler.x, swayLimitX.x, swayLimitX.y);
        // currentEuler.y = ClampSway(currentEuler.y, swayLimitY.x, swayLimitY.y);
        // currentEuler.z = 0;

        // Debug.Log(currentEuler);
        // transform.localEulerAngles = currentEuler;

        // transform.localEulerAngles = Vector3.Lerp(transform.localEulerAngles, currentEuler, Time.deltaTime * smooth);



        //         var finalPos = new Vector3(moveX, moveY, 0);
        // transform.localRotation = Quaternion.Lerp(transform.localRotation, cameraRotate + currentRotate, Time.deltaTime * smoothAmount);
    }

    private bool CheckLimit(float currentEuler, Vector2 swayLimit)
    {
        if (currentEuler > 180)
            currentEuler -= 360;    
        return currentEuler <= swayLimit.x || currentEuler >= swayLimit.y;
    }


    private float ClampSway(float value, Vector2 limit)
    {
        if (value > 180)
            value -= 360;

        return Mathf.Clamp(value, limit.x, limit.y);
    }



}
