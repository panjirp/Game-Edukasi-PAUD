using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class benar : MonoBehaviour {
	public Image img;
	public InputField answer;
	public Button next;
	public string jawaban;
	void Start () {
		img.enabled = false;
		GetComponent<UnityEngine.UI.Button>().onClick.AddListener(() => jwbBenar());
		next.interactable = false;
	}
		

	// Update is called once per frame
	public void jwbBenar () {
		if (answer.text.Contains(jawaban)){
			img.enabled=true;
			next.interactable = true;
		}
	}
}
