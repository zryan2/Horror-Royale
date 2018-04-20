using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Inventory : MonoBehaviour {



	public event EventHandler<InventoryEventArgs> ItemAdded;
	public event EventHandler<InventoryEventArgs> ItemRemoved;
	public event EventHandler<InventoryEventArgs> ItemUsed;
	//public GameObject inventory; 
	public bool isActive;

	private const int SLOTS = 9;
	private bool isInventoryOpen = false;
	private IList<InventorySlot> mSlots = new List<InventorySlot> ();

	public Inventory(){
		for (int i = 0; i < SLOTS; i++) {
			mSlots.Add (new InventorySlot(i));
		}
	}


	void Update(){
				
	}

	private InventorySlot FindStackableItem(ItemBaseClass item){
		foreach (InventorySlot slot in mSlots) {
			if (slot.IsStackable (item))
			//	Debug.Log ("HELP " + slot);
				return slot;
		}
		//Debug.Log ("HELP NULL");
		return null;
	}

	private InventorySlot FindNextEmptySlot(){
		foreach (InventorySlot slot in mSlots) {
			
			if (slot.IsEmpty) {
				//Debug.Log ("IM HERE: " + slot);
				return slot; 
			}
		}
		return null;
	}

	public void AddItem(ItemBaseClass item){
		//Debug.Log ("ADDDDDD");
		item.pickupItem ();
		InventorySlot newSlot = FindStackableItem (item);
		if (newSlot == null) {
			newSlot = FindNextEmptySlot();
			//Debug.Log ("AddItem----newSlot: NULL"+ newSlot);
		}
		if (newSlot != null) {
			newSlot.AddItem (item);
			//Debug.Log ("AddItem to slot");

			if (ItemAdded != null) {
				ItemAdded (this, new InventoryEventArgs (item));
			}
		}
	}

	public void RemoveItem(ItemBaseClass item){
		foreach (InventorySlot slot in mSlots) {
			if (slot.Remove (item)) {
				if (ItemRemoved != null) {
					ItemRemoved (this, new InventoryEventArgs (item));
				}
				break;
			}
		}

	}

	public void UseItem(ItemBaseClass item){
		if (ItemUsed != null) {
			ItemUsed (this, new InventoryEventArgs (item));
		}
	}
}

//
//=======
//﻿using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//
//public class Inventory : MonoBehaviour {
//    List<Item> items;
//	// Use this for initialization
//	void Start () {
//        items = new List<Item>();
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		
//	}
//    public Item Use() {
//        Item result = null;
//        return result;
//    }
//    public void get(Item item)
//    {
//        items.Add(item);
//    }
//    
//}
//
//public class Item
//{
//    string name;
//    int count;
//    public Item() { }
//    public Item(string _name, int _count)
//    {
//        name = _name;
//        count = _count;
//    }
//>>>>>>> upstream/Inventory
//}
