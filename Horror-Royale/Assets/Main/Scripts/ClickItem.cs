using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickItem : MonoBehaviour {

	public Inventory inventory;

	private float lastClickTime = 0f;

	float catchTime = 0.25f;


	public void onItemClick(){
		ItemDrag itemDrag = gameObject.transform.Find ("ItemImage").GetComponent<ItemDrag>();


		ItemBaseClass item = itemDrag.Item;

		Debug.Log ("CLICK" + item);
		inventory.UseItem (item);
		//		item.OnUse();
	}

	public void Update(){
		if (Input.GetButtonDown ("Fire1")) {
			if (Time.time - lastClickTime < catchTime) {
				Debug.Log ("double click");
				Image image = gameObject.transform.Find ("ItemImage").GetComponent<Image>();
				image.sprite = null;
				
			} 
			lastClickTime = Time.time;
		}
	}
}
