﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasePlayer : MonoBehaviour {


	public Transform player;
	public int distance;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Vector3.Distance(player.position, this.transform.position) < distance){
			Vector3 direction = player.position - this.transform.position;
			direction.y -= 1;
			this.transform.rotation = Quaternion.Slerp (this.transform.rotation,
				Quaternion.LookRotation (direction), 0.1f);
		}
	}
}
