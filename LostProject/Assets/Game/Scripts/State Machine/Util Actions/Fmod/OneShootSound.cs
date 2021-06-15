using System;
using FMODUnity;
using UnityEngine;

[Serializable]
public class OneShootSound
{
    public State fromState;

    [FMODUnity.EventRef]
    public string sound;

    public ParamRef parameter;

    public void PlaySound()
    {
        if (parameter.Name == "")
            FMODUnity.RuntimeManager.PlayOneShot(sound);
        else
            FMODUnity.RuntimeManager.PlayOneShot(sound, parameter.Name, parameter.Value);
    }
}
