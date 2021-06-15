using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeView : MonoBehaviour
{

    [Range(0, 10)]
    public float range;
    public Transform originPoint;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawWireSphere(originPoint.position, range);
    }
}
