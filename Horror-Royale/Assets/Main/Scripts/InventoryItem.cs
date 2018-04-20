using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class InventoryEventArgs: EventArgs{
	public InventoryEventArgs(ItemBaseClass item){
		Item = item;
	}
	public ItemBaseClass Item;
}

