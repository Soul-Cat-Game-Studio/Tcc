using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadarObj : MonoBehaviour
{
    private void OnTriggerEnter(Collider hit)
    {       
        var obj = hit.gameObject.GetComponent<ObjInteractBase>();

        if (obj != null) obj.EnterProximity();
    }

    private void OnTriggerExit(Collider hit)
    {
        // if (!hit.CompareTag("Interactable")) return;

        var obj = hit.gameObject.GetComponent<ObjInteractBase>();

        if (obj != null) obj.ExitProximity();
    }
}
