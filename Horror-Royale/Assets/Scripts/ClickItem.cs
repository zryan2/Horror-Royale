using UnityEngine;
using UnityEngine.UI;

public class ClickItem : MonoBehaviour {

	public Inventory inventory;
	public InventorySlot islot;
	public ItemBaseClass item;
	public Transform slot1;
	public Transform slot2;
	public Transform slot3;
	public Transform slot4;
	public Transform slot5;
	public Transform slot6;
	public string itemName;

	public bool chooseItem = false;

	//	public ItemBaseClass Item{ get; set; }

	private Transform imageTransform;
	private Transform nameTransform;

	void Update(){
		// using the keypad to use an item in the inventory

		// TODO for each until we get to the slot we want
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			chooseItem = true;
			imageTransform = slot1.GetChild (0).GetChild (0);
			nameTransform = slot1.GetChild (0).GetChild (2);
			//			ItemDrag dragHandler = imageTransform.GetComponent<ItemDrag>();
			//			item = dragHandler.Item;
			//			Debug.Log ("CLICKED " + item);

			//	islot.printSlot ();

			ItemDrag dragHandler = imageTransform.GetComponent<ItemDrag>();
			item = dragHandler.Item;
			Debug.Log ("CLICKED " + item);
			inventory.RemoveItem (item);





		} else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			chooseItem = true;
			imageTransform = slot2.GetChild (0).GetChild (0);
			nameTransform = slot2.GetChild (0).GetChild (2);

			ItemDrag dragHandler = imageTransform.GetComponent<ItemDrag>();
			item = dragHandler.Item;
			Debug.Log ("CLICKED " + item);
			inventory.RemoveItem (item);
		} else if (Input.GetKeyDown (KeyCode.Alpha3)) {
			chooseItem = true;
			imageTransform = slot3.GetChild (0).GetChild (0);
			nameTransform = slot3.GetChild (0).GetChild (2);
		}
		else if (Input.GetKeyDown (KeyCode.Alpha4)) {
			chooseItem = true;
			imageTransform = slot4.GetChild (0).GetChild (0);
			nameTransform = slot4.GetChild (0).GetChild (2);
		}
		else if (Input.GetKeyDown (KeyCode.Alpha5)) {
			chooseItem = true;
			imageTransform = slot5.GetChild (0).GetChild (0);
			nameTransform = slot5.GetChild (0).GetChild (2);
		}
		else if (Input.GetKeyDown (KeyCode.Alpha6)) {
			chooseItem = true;
			imageTransform = slot6.GetChild (0).GetChild (0);
			nameTransform = slot6.GetChild (0).GetChild (2);
		}

		Image image = imageTransform.GetComponent<Image> ();
		Text name = nameTransform.GetComponent<Text> ();


	}

}