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

    private void Start()
    {
        inicialPos = transform.localPosition;
    }

    private void Update()
    {
        var moveX = playerControl.
    }
}
