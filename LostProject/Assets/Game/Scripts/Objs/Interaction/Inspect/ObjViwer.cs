using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjViwer : MonoBehaviour
{
    [SerializeField] private InputReader _input;
    public float vel = 350;

    public bool canRotate = true;

    private GameObject _objToview; 
    private Vector3 _pos;
    private Transform _cam;

    private void OnEnable()
    {
        // _input.InspectRotateObjEvent += Getpos;
    }

    private void OnDisable()
    {
        // _input.InspectRotateObjEvent -= Getpos;
        
        _pos = Vector2.zero;
        _objToview = null;
    }

    private void Awake() { _cam = Camera.main.transform; }

    private void Update()
    {
        if(!canRotate) return;
        
        var axis = _cam.up * _pos.x;
        axis += (_cam.right * -_pos.y);

        _objToview?.transform.Rotate(axis, Time.deltaTime * -vel, Space.World);
    }

    private void Getpos(Vector2 pos) { _pos = pos; }

    
    public void SetInspection(ObjInteractBase objBase)
    {
        _objToview = objBase.gameObject;        
    }    
}