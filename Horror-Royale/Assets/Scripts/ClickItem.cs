using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickItem : MonoBehaviour {

	public Inventory inventory;
	public ItemBaseClass item;
	public Transform slot1;
	public GameObject slot_1;
	public Transform slot2;
	public Transform slot3;
	public Transform slot4;
	public Transform slot5;
	public Transform slot6;
	public string itemName;
//	public int num = 0;

	public bool chooseItem = false;

	void Update(){
		// using the keypad to use an item in the inventory

		// TODO for each until we get to the slot we want
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			Debug.Log ("Pressed 1");
			chooseItem = true;
			Transform imageTransform = slot1.GetChild (0).GetChild (0);
			Transform nameTransform = slot1.GetChild (0).GetChild (2);
			Image image = imageTransform.GetComponent<Image> ();
			Text name = nameTransform.GetComponent<Text> ();


			itemName = name.text;
			int num = 1;
		

			image.sprite = null;
			//chooseItem = false;
			//name.text = null;

		}

//		else if (Input.GetKeyDown (KeyCode.Alpha2)) {
//			chooseItem = true;
//			Transform imageTransform = slot2.GetChild (0).GetChild (0);
//			Transform nameTransform = slot2.GetChild (0).GetChild (2);
//			Image image = imageTransform.GetComponent<Image> ();
//			Text name = nameTransform.GetComponent<Text> ();
//
//			itemName = name.text;
//			//Debug.Log ("THE ITEM NAME IS " + itemName);
//			image.sprite = null;
//			//name.text = null;
//		}
//		else if (Input.GetKeyDown (KeyCode.Alpha3)) {
//			chooseItem = true;
//			Transform imageTransform = slot3.GetChild (0).GetChild (0);
//			Transform nameTransform = slot3.GetChild (0).GetChild (2);
//			Image image = imageTransform.GetComponent<Image> ();
//			Text name = nameTransform.GetComponent<Text> ();
//
//			itemName = name.text;
//			//Debug.Log ("THE ITEM NAME IS " + itemName);
//			image.sprite = null;
//			//name.text = null;
//		}
//		else if (Input.GetKeyDown (KeyCode.Alpha4)) {
//			chooseItem = true;
//			Transform imageTransform = slot4.GetChild (0).GetChild (0);
//			Transform nameTransform = slot4.GetChild (0).GetChild (2);
//			Image image = imageTransform.GetComponent<Image> ();
//			Text name = nameTransform.GetComponent<Text> ();
//
//			itemName = name.text;
//			//Debug.Log ("THE ITEM NAME IS " + itemName);
//			image.sprite = null;
//			//name.text = null;
//		}
//		else if (Input.GetKeyDown (KeyCode.Alpha5)) {
//			chooseItem = true;
//			Transform imageTransform = slot5.GetChild (0).GetChild (0);
//			Transform nameTransform = slot5.GetChild (0).GetChild (2);
//			Image image = imageTransform.GetComponent<Image> ();
//			Text name = nameTransform.GetComponent<Text> ();
//
//			itemName = name.text;
//			//Debug.Log ("THE ITEM NAME IS " + itemName);
//			image.sprite = null;
//			//name.text = null;
//		}
//		else if (Input.GetKeyDown (KeyCode.Alpha6)) {
//			chooseItem = true;
//			Transform imageTransform = slot6.GetChild (0).GetChild (0);
//			Transform nameTransform = slot6.GetChild (0).GetChild (2);
//			Image image = imageTransform.GetComponent<Image> ();
//			Text name = nameTransform.GetComponent<Text> ();
//
//			itemName = name.text;
//			//Debug.Log ("THE ITEM NAME IS " + itemName);
//			image.sprite = null;
//			//name.text = null;
//		}
		//chooseItem = false;
		//Debug.Log ("THE ITEM NAME IS " + itemName);
	}



}
