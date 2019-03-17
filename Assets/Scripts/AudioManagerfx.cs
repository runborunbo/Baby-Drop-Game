using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManagerfx : MonoBehaviour
{
    public AudioSource musicfx;
    public Slider volumefx;
    // Start is called before the first frame update
    void Start()
    {
        volumefx.value = PlayerPrefs.GetFloat("MusicfxVolume");
    }

    // Update is called once per frame
    void Update()
    {
        musicfx.volume = volumefx.value;
    }
    public void VolumePrefsfx()
    {
        PlayerPrefs.SetFloat("MusicfxVolume", musicfx.volume);
    }
    public void Mute()
    {
        volumefx.value = 0;
    }

}
