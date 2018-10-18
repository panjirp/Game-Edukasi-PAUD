using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuBack : MonoBehaviour {

	Ray ray;
	RaycastHit hit;

	GameObject canvas;
	Animator anim;

	public Text textInfo;

	public GameObject[] objek;
	public string[] info;

	void Awake(){
		canvas = GameObject.Find ("Canvas");
		anim = canvas.GetComponent<Animator>();
	}
	// Update is called once per frame
	void Update () {
		if (Application.platform == RuntimePlatform.Android)

		{

			if (Input.GetKey(KeyCode.Escape) & Input.GetKey(KeyCode.Menu))

			{

				ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

				if(Physics.Raycast(ray, out hit, Mathf.Infinity)){

					for(int i = 0; i < objek.Length; i++){
						if(hit.collider.gameObject == objek[i]){
							textInfo.text = info[i];  
							anim.SetTrigger("PopUpMuncul");
						}
					}

				}


			}}
	}

	public void popUp_OFF(){
		anim.SetTrigger ("PopUpKeluar");
}
}
