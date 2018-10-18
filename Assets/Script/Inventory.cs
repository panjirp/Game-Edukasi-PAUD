using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Inventory : MonoBehaviour, IHasChanged {
	[SerializeField] Transform DropArea;
	[SerializeField] Text inventoryText;

	public Text winText;
	private int count;
	public Button myButton;
	public Image img;
	public AudioSource audioSource;

	void Start () {
		HasChanged ();
		count = 0;
		winText.text = "";
		benar ();
		img.enabled = false;

	}

	#region IHasChanged implementation
	public void HasChanged() {
		System.Text.StringBuilder builder = new System.Text.StringBuilder ();
		builder.Append (" - ");
		foreach (Transform slotTransform in DropArea) {
			GameObject item = slotTransform.GetComponent<DropArea> ().item;
			count = count + 1; 
			benar ();
			if (item) {
				builder.Append (item.name);
				builder.Append (" - ");
			}

		}
		inventoryText.text = builder.ToString ();

	}
	#endregion


	void benar() {

		if (count >= 15) {
			myButton.interactable = true;
			winText.text = "Benar!";
			img.enabled = true;
			audioSource.Play ();
		}
	}
}

namespace UnityEngine.EventSystems {
	public interface IHasChanged : IEventSystemHandler {
		void HasChanged();
	}
		
}