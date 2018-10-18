using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class True : MonoBehaviour {

	public Button myButton;
	public Image img;
	// Use this for initialization
	void Start () {
		img.enabled = false;
	}
	
	// Update is called once per frame
	public void Win () {
		img.enabled = true;
		myButton.interactable = true;
	}
}
