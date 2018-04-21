using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour {

	private ClickItem clickItem;
	private int counter = 0;
	public string itemChose;



	void Start(){
		clickItem = GetComponent<ClickItem> ();
	}

	void Update(){
	 itemChose = clickItem.itemName;
		bool didChoose = clickItem.chooseItem;
		Debug.Log ("DID CHOOSE IS " + didChoose);
		if (didChoose) {
			Debug.Log ("DID CHOOSE IS " + didChoose);
			Debug.Log ("ITEM CHOSE IS " + itemChose);
			if (counter != 1) {
				
				if (itemChose == "Key") {
					Debug.Log ("hi");
					openingDoor ();
					counter = 1;
				}
			}
		}
	}

	public void openingDoor(){
		transform.Rotate(0, -90, 0); 
		//TODO add opening animation 

	}



}
