using System.Collections;
using System.Collections.Generic;
using FMODUnity;
using UnityEngine;

[CreateAssetMenu(menuName = "State Machine/ Action/ Util/ Check Footstep Material", fileName = "Check Material FootStep ACT")]
public class CheckMaterialFootStep : Loop3DSoundACT
{
    public float range = 2f;   
    public ParamRef[] updateParams;

    public override void ActFixedUpdate(StateMachine stateMachine)
    {
        if (Physics.Raycast(stateMachine.transform.position, Vector3.down, out var hit, range))
        {
            var materialRef = hit.collider.gameObject.GetComponent<FmodMaterialSetter>();

            if (materialRef == null) return;            

            foreach (var item in sounds)
            {
                item.ChangeParametersByOther(updateParams, materialRef.valorRef);
            }            
        }
    }
}
