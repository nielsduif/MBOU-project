using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour {

	Toggle checkbox;
	void Start(){
		checkbox = GameObject.FindObjectOfType<Toggle> ();
		string mute = PlayerPrefs.GetString ("Mute");
		if (mute == "true") {
			checkbox.isOn = false;//als mute aan is gaat de checkbox uit
		} else {
			checkbox.isOn = true;//als de mute niet aan is gaat de checkbox aan
		}
	}
	public void Mute (){
		
		if (checkbox.isOn) {
			PlayerPrefs.SetString ("Mute", "false");
			AudioListener.pause = false;
		} else {
			PlayerPrefs.SetString ("Mute", "true");
			AudioListener.pause = true;
		}
	}
}
