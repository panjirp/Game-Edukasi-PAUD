using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class popUp : MonoBehaviour {

	// Use this for initialization
	public GameObject Canvas;
	bool Paused = false;


	void Start () {
		Canvas.gameObject.SetActive (false);
	}

	public void Membuka () {
		
			if (Paused == true) {
				Canvas.gameObject.SetActive (false);
				Paused = false;
			} else {
				Canvas.gameObject.SetActive (true);
				Paused = true;
			}


	}

	public void Update () {
		if (Input.GetKey (KeyCode.Escape)) {
			if (Paused == true) {
				Canvas.gameObject.SetActive (false);
				Paused = false;
			}else {
				Canvas.gameObject.SetActive (true);
				Paused = true;
			}
		}
	}
}