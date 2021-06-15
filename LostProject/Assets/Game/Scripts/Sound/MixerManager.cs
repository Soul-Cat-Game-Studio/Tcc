
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "MixerManager", menuName = "Unbound_Master_Piece/MixerManager", order = 0)]
public class MixerManager : ScriptableObject
{
    [Range(-80f, 10f)]
    public float masterVolume;

    [Range(-80f, 10f)]
    public float ambienceVolume;

    [Range(-80f, 10f)]
    public float sfxVolume;

    [Range(-80f, 10f)]
    public float voicesVolume;
}
