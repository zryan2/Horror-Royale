using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour {

	private ClickItem clickItem;
	public bool doubleClick = false;
	private int counter = 0;



	void Awake(){
		clickItem = GetComponent<ClickItem> ();
	}

	 void Update(){
		//Debug.Log ("NUMBER IS " + clickItem.num);

		ItemBaseClass itemClicked = clickItem.item;

//		doubleClick = clickItem.didDoubleClick;
		if (counter != 1) {
//			Debug.Log ("step 1");
			if (doubleClick) {
				//Debug.Log ("step 2");
				//Debug.Log ("ITEM NAME" + itemClicked.Name);
//				if (itemClicked.Name == "Key") {
//				//	Debug.Log ("step 3");
//				
					openingDoor ();
					counter = 1;
//				}

			}
		}
	}

	public void openingDoor(){
		//if (doubleClick) {
			Debug.Log (doubleClick);
		transform.Rotate(0, -90, 0); 
		//TODO add opening animation 
		
		//}
	}



}
