using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems; 
using UnityEngine;

public class OpenDoor : MonoBehaviour {

	private ClickItem clickItem;
	private int counter = 0;
	//public string itemChose;
	public string keyItem;
	public int angle;
	public bool didChoose;
	public ItemBaseClass itemChose;



	void Start(){
		GameObject inventoryPanel = GameObject.Find("InventoryPanel");
		clickItem = inventoryPanel.GetComponent<ClickItem> ();
	}

	void Update(){
		didChoose = clickItem.chooseItem;
		Debug.Log ("DID CHOOSE IS " + didChoose);
//		Debug.Log ("ITEM CHOSE IS " + itemChose);
		//if (didChoose) {
		if (didChoose) {
//			Debug.Log ("DID CHOOSE IS " + didChoose);
			itemChose = clickItem.item;
			Debug.Log ("ITEM CHOSE IS " + itemChose);
			if (counter != 1) {
				if (itemChose.name== keyItem) {
					openingDoor ();
				
//					Debug.Log ("THE ITEM IS " + item);
					counter = 1;
				}
			}
		}
	}

	public void openingDoor(){
		transform.Rotate(0, angle, 0); 
		//TODO add opening animation 

	}



}
