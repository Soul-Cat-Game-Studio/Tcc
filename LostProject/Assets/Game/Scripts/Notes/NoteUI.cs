using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NoteUI : MonoBehaviour
{
    [SerializeField] private InputReader _input;

    [SerializeField] private NoteManager _noteManager;

    [SerializeField] private TMP_Text _title;
    [SerializeField] private TMP_Text _description;


    [SerializeField] private GameObject _uiButtonInspect;
    [SerializeField] private GameObject _uiButtonRead;
    [SerializeField] private GameObject _carta;

    private ObjViwer _objViwer;

    private ObjInteractBase _base;

    private bool _reading;


    private void OnEnable()
    {
        _title.text = _noteManager.note.title;
        _description.text = _noteManager.note.description;

        _input.InspectPrimaryActionEvent += DropOff;
        _input.InspectSecondActionEvent += Read;
    }

    private void OnDisable()
    {
        _reading = false;
        _uiButtonInspect.SetActive(true);
        _uiButtonRead.SetActive(false);
        _carta.SetActive(false);

        _input.InspectPrimaryActionEvent -= DropOff;
        _input.InspectSecondActionEvent -= Read;
    }


    private void Awake()
    {
        _objViwer = GetComponent<ObjViwer>();
    }


    private void DropOff()
    {
        _base?.DoPrimaryActionBack();
        OffInteraction();
    }

    public void SetInspection(ObjInteractBase objBase)
    {
        _base = objBase;
    }

    private void Read()
    {
        if (!_reading)
        {
            _reading = true;

            _objViwer.canRotate = false;

            _uiButtonInspect.SetActive(false);

            _uiButtonRead.SetActive(true);
            _carta.SetActive(true);
        }
        else
        {
            _reading = false;

            _objViwer.canRotate = true;

            _uiButtonInspect.SetActive(true);

            _uiButtonRead.SetActive(false);
            _carta.SetActive(false);
        }
    }

    public void OffInteraction()
    {
        _base = null;
    }
}
