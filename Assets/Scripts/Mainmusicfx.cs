using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainmusicfx : MonoBehaviour
{
    public AudioSource musicfx;
    // Start is called before the first frame update
    void Start()
    {
        musicfx.volume = PlayerPrefs.GetFloat("MusicfxVolume");
    }

  
}
