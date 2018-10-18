using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class DragBehaviours : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	public static GameObject items;    // i changed itembeigdraged to item.


	Transform startParent;
	Vector3 startPosition;
	bool start = true;
	//Sprite sprite;

	public void OnBeginDrag(PointerEventData eventData)
	{
		items = gameObject;
		startPosition = transform.position;
		startParent = transform.parent;

		GetComponent<CanvasGroup>().blocksRaycasts = false;
		items.GetComponent<LayoutElement>().ignoreLayout = true;
		items.transform.SetParent(items.transform.parent.parent);
	}


	public void OnDrag(PointerEventData eventData)
	{

		transform.position = Input.mousePosition;
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		items = null;

		if(transform.parent == startParent)
		{
			transform.position = startPosition;
		}
		GetComponent<CanvasGroup>().blocksRaycasts = true;

		items.GetComponent<LayoutElement>().ignoreLayout = false;
	}

}