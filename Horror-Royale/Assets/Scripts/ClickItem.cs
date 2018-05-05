using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickItem : MonoBehaviour
{
	public Inventory inventory;

	public KeyCode key;

	public ItemBaseClass item;


	private Button button;

	public bool chooseItem;

	void Awake(){
		button = GetComponent<Button>();
	}

	void Update(){
		//Debug.Log (chooseItem);
		if(Input.GetKeyDown(key)){
			chooseItem = true;
			//Debug.Log (chooseItem);

			//FadeToColor(_button.colors.pressedColor);

			// Click the button

			item = itemUsed;
			inventory.RemoveItem (item);
			Debug.Log ("CLICKED " + item);

			button.onClick.Invoke();
		}
		//		else if(Input.GetKeyUp(key))
		//		{
		//			FadeToColor(_button.colors.normalColor);
		//		}
	}

	//	void FadeToColor(Color color)
	//	{
	//		Graphic graphic = GetComponent<Graphic>();
	//		graphic.CrossFadeColor(color, _button.colors.fadeDuration, true, true);
	//	}

	private ItemBaseClass itemUsed
	{
		get
		{
			ItemDrag dragHandler =
				gameObject.transform.Find("ItemImage").GetComponent<ItemDrag>();

			return dragHandler.Item;
		}
	}

	public void OnItemClicked()
	{
		//		 item = itemUsed;
		//		Debug.Log ("CLICKED");
		//		didChoose = true;

		//		if (item != null)
		//		{
		//			inventory.RemoveItem(item);
		//
		//
		//			//item.OnUse();
		//		}
	}

}