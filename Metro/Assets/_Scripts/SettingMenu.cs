using UnityEngine;
using System.Collections;

public class SettingMenu : MonoBehaviour {

    public float MusicVolume = 0.5f;
    public float SFXVolume = 0.5f;

    void Update()
    {
        AudioControll.Volume = MusicVolume;
    }

    public void Music(float value)
    {
        MusicVolume = value;
    }

    public void SFX(float SFXvolume)
    {
        SFXVolume = SFXvolume;
    }
}
