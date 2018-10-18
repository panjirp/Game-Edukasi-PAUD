using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MyButton : MonoBehaviour {

	public Button myButton;
	void Start () {
		myButton.interactable = false;
	}

}
