using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickItem : MonoBehaviour {

	public Inventory inventory;


//	public bool didDoubleClick = false;
//
//	private float lastClickTime = 0f;
	public ItemBaseClass item;
//	float catchTime = 0.25f;
//
//
//	public void onItemClick(){
//		ItemDrag itemDrag = gameObject.transform.Find ("ItemImage").GetComponent<ItemDrag>();
//
//
//	 	item = itemDrag.Item;
//
//		//Debug.Log ("CLICK" + item.Name);
//		//inventory.UseItem (item);
//		//		item.OnUse();
//	}
//
//	public void Update(){
//		if (Input.GetButtonDown (1)) {
//			if (Time.time - lastClickTime < catchTime) {
//				//Debug.Log ("double click");
//				didDoubleClick = true;
//				onItemClick ();
//	
//				//Debug.Log (didDoubleClick);
//				Image image = gameObject.transform.Find ("ItemImage").GetComponent<Image>();
//				image.sprite = null;
//				
//			} 
//			didDoubleClick = false;
//			//Debug.Log (didDoubleClick);
//			lastClickTime = Time.time;
//		}
//	}

	public Transform slot1;
	public Transform slot2;
	public Transform slot3;
	public Transform slot4;
	public Transform slot5;
	public Transform slot6;

	public bool chooseItem = false;

	void Update(){

		// using the keypad to use an item in the inventory

		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			chooseItem = true;
			Transform imageTransform = slot1.GetChild (0).GetChild (0);
			Image image = imageTransform.GetComponent<Image> ();
			image.sprite = null;
		}

		else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			Transform imageTransform = slot2.GetChild (0).GetChild (0);
			Image image = imageTransform.GetComponent<Image> ();
			image.sprite = null;
		}
		else if (Input.GetKeyDown (KeyCode.Alpha3)) {
			Transform imageTransform = slot3.GetChild (0).GetChild (0);
			Image image = imageTransform.GetComponent<Image> ();
			image.sprite = null;
		}
		else if (Input.GetKeyDown (KeyCode.Alpha4)) {
			Transform imageTransform = slot4.GetChild (0).GetChild (0);
			Image image = imageTransform.GetComponent<Image> ();
			image.sprite = null;
		}
		else if (Input.GetKeyDown (KeyCode.Alpha5)) {
			Transform imageTransform = slot5.GetChild (0).GetChild (0);
			Image image = imageTransform.GetComponent<Image> ();
			image.sprite = null;
		}
		else if (Input.GetKeyDown (KeyCode.Alpha6)) {
			Transform imageTransform = slot6.GetChild (0).GetChild (0);
			Image image = imageTransform.GetComponent<Image> ();
			image.sprite = null;
		}
		
	}



}
