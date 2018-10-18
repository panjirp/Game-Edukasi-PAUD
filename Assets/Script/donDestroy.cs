using UnityEngine;
using System.Collections;

public class donDestroy : MonoBehaviour {

	// Use this for initialization
	public void Awake () {

		DontDestroyOnLoad (gameObject);

		if (this.gameObject.name != "CanvasPopUp") {
			Destroy (this.gameObject);
		}

		if (FindObjectsOfType (GetType ()).Length > 1) {
			Destroy (gameObject); 
		}
	}
}