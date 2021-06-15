using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotView : MonoBehaviour
{
    [Range(0, 360)]
    [SerializeField] private float coneAngle = 25f;

    [Range(0, 10)]
    public float range;

    public bool ConeView(Vector3 fromPoint, Vector3 inputPoint)
    {
        var conAngle = Vector3.Dot((inputPoint - fromPoint).normalized,
            fromPoint + Vector3.forward);

        var angle = Mathf.Acos(conAngle) * Mathf.Rad2Deg;

        Debug.Log("Angle: " + angle);
        Debug.Log("Cone Angle: " + coneAngle);

        return angle < coneAngle;
    }
}
