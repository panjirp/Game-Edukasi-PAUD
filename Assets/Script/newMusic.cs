using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class newMusic : MonoBehaviour {
	public Toggle togell;
	public static bool musicx;
	public static AudioSource audiox;

	// Use this for initialization

	 void Start () {
		Toggle togell = GameObject.FindObjectOfType <Toggle>();
		AudioSource audiox = AudioSource.FindObjectOfType<AudioSource> ();
	
	}
	
	// Update is called once per frame
	 void Update () {
		if (togell.isOn == true) {
			musicx = true;
		} else {
			musicx = false;
		}
	}
}
