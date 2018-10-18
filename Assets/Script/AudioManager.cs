using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AudioManager : MonoBehaviour {
	
	// Use this for initialization
	public void Awake () {
		
		DontDestroyOnLoad (gameObject);

		if (this.gameObject.name != "BackSound") {
			Destroy (this.gameObject);
		}
	
}

	}

