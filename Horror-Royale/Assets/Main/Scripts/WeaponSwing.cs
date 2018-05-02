using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwing : MonoBehaviour {
	private float nextFire;
	public float clickRate = 0.50f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Mouse1) && Time.time > nextFire) {
			nextFire = Time.time + clickRate;

			Debug.Log ("Swing swing");
		}
	}
}
