﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ItemDrag : MonoBehaviour, IDragHandler, IEndDragHandler {

	public ItemBaseClass Item{ get; set; }

	public void OnDrag(PointerEventData eventData){
	//	transform.position = Input.mousePosition;
	}

	public void OnEndDrag(PointerEventData eventData){
	//	transform.localPosition = Vector3.zero;
	}
	

}
