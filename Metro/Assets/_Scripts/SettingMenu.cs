using UnityEngine;
using System.Collections;

public class SettingMenu : MonoBehaviour {

    public static float MusicVolume = 0.5f;
    public static float SFXVolume = 0.5f;

    void Update()
    {
        GetComponent<AudioSource>().volume = MusicVolume;
    }

    public void Music(float volume)
    {
        MusicVolume = volume;
    }

    public void SFX(float SFXvolume)
    {
        SFXVolume = SFXvolume;
    }
}
