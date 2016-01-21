using UnityEngine;
using System.Collections;

public class AudioControll : MonoBehaviour {

    public static float Volume = 0.5f;

    private static AudioControll instance = null;
    public static AudioControll Instance
    {
        get { return instance; }
    }
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
    void Update()
    {
        GetComponent<AudioSource>().volume = Volume;
    }
}
