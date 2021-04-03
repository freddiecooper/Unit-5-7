using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Slider MusicVol;
	public Slider SfxVol;
    public Toggle MusicOn;
    void Update()
    {
		if (MusicOn.isOn==false)
		{
			AudioManager.instance.SetVolume("Music",0);
		}
		else
		{
			AudioManager.instance.SetVolume("Music",MusicVol.value);
		}
		
		AudioManager.instance.SetVolume("click",SfxVol.value);
		AudioManager.instance.SetVolume("knock",SfxVol.value);
        print(MusicOn.isOn);
    }
    
}
