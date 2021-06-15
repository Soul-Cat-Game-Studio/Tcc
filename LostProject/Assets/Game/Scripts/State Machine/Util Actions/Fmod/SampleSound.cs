using System.Collections;
using System.Collections.Generic;
using FMODUnity;
using UnityEngine;

[System.Serializable]
public class SampleSound
{
    [FMODUnity.EventRef]
    public string sound;

    public ParamRef[] enterParams;
    public ParamRef[] exitParams;

    private FMOD.Studio.EventInstance _fmodInstance;


    public void SoundAwake()
    {
        _fmodInstance = FMODUnity.RuntimeManager.CreateInstance(sound);
    }    

    public void InicializeSound()
    {
        _fmodInstance = FMODUnity.RuntimeManager.CreateInstance(sound);

        PlayStartSound();

        ChangeParameters(enterParams);

    }

    public void Update3DSound(StateMachine stateMachine)
    {
        _fmodInstance.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(stateMachine.gameObject));
    }

    public void FinishSound()
    {
        ChangeParameters(exitParams);

        StopExitSound();
    }

    public void ChangeParametersByOther(ParamRef[] paramRefs, float i)
    {
        if (paramRefs.Length == 0) return;

        foreach (var item in paramRefs)
        {
            _fmodInstance.setParameterByName(item.Name, i);
        }
    }

    private void ChangeParameters(ParamRef[] paramRefs)
    {
        if (paramRefs.Length == 0) return;

        foreach (var item in paramRefs)
        {
            _fmodInstance.setParameterByName(item.Name, item.Value);
        }
    }
   
    private void PlayStartSound()
    {
        _fmodInstance.start();
    }

    private void StopExitSound()
    {
        _fmodInstance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        // _fmodInstance.release();
    }
}
