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

	private const int SLOTS = 6;
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
		item.pickupItem ();
		//Debug.Log("adding " + item);
		InventorySlot newSlot = FindStackableItem (item);
		if (newSlot == null) {
			newSlot = FindNextEmptySlot();
		
		}
		if (newSlot != null) {
			newSlot.AddItem (item);

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

	public void useInventory(int slotNum){
		for (int i = 0; i < slotNum; i++) {
			if (i == slotNum) {
				mSlots[i] = null;
			}
		}
	}


}