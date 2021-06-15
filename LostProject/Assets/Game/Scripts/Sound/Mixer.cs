using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using FMOD;
using UnityEngine.UI;

public class Mixer : MonoBehaviour
{
    public MixerManager mixerManager;
    FMOD.Studio.Bus masterBus;  
    public Slider masterSlider;

    FMOD.Studio.VCA ambienceVca; 
    public Slider ambienceSlider;

    FMOD.Studio.VCA sfxVca; 
    public Slider sfxSlider;

    FMOD.Studio.VCA voicesVca;   
    public Slider voiceSlider;

    private void Awake()
    {
        masterBus = RuntimeManager.GetBus("bus:/");
        ambienceVca = RuntimeManager.GetVCA("vca:/ambience");
        sfxVca = RuntimeManager.GetVCA("vca:/sfx");
        voicesVca = RuntimeManager.GetVCA("vca:/voices");
    }

    private void Start()
    {
        masterSlider.value = mixerManager.masterVolume;
        ambienceSlider.value = mixerManager.ambienceVolume;
        sfxSlider.value = mixerManager.sfxVolume;
        voiceSlider.value = mixerManager.voicesVolume;
    }

    public void UpdateMasterSound(float i)
    {
        mixerManager.masterVolume = Mathf.Pow(10.0f, i / 20f);
        masterBus.setVolume(mixerManager.masterVolume);
    }

    public void UpdateAmbienceSound(float i)
    {
        mixerManager.ambienceVolume = Mathf.Pow(10.0f, i / 20f);
        ambienceVca.setVolume(mixerManager.ambienceVolume);
    }

    public void UpdateSfxSound(float i)
    {
        mixerManager.sfxVolume = Mathf.Pow(10.0f, i / 20f);
        sfxVca.setVolume(mixerManager.sfxVolume);
    }

    public void UpdateSoundVolume(float i)
    {
        mixerManager.voicesVolume = Mathf.Pow(10.0f, i / 20f);
        voicesVca.setVolume(mixerManager.voicesVolume);
    }
}