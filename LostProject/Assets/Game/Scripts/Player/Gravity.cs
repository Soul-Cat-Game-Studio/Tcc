using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public float gravity = -13.0f;

    public float velY;

    public CharacterController controller;



    private void Update()
    {
        if (controller.isGrounded)
            velY = 0;

        velY += gravity * Time.deltaTime;

        controller.Move(velY * Vector3.up * Time.deltaTime);
    }


}
