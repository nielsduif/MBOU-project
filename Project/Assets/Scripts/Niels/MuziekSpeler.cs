using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuziekSpeler : MonoBehaviour
{
	public float musicVolume = 1f;

    static MuziekSpeler instance = null;

    void Start()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);//als er al een nummer afspeelt wordt het niet verwijderd
        }

    }

    void update()
    {
		AudioListener.volume = musicVolume;
    }

    void Awake()
    {
        string mute = PlayerPrefs.GetString("Mute");
        if (mute == "true")
        {
            AudioListener.pause = true;//geluid uit
        }
        else
        {
            AudioListener.pause = false;//geluid aan
        }
    }

    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }
}
