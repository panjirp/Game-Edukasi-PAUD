using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {

	public Toggle togel;
	void Start () { 
		if (newMusic.musicx == true) {
			togel.isOn = true;


		} else if (newMusic.musicx == false) {
			togel.isOn = false;

		}

	}

	void Update () {
		
	}
	// Update is called once per frame

}
