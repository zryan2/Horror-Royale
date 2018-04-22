using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class OnCollisionEnter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
		if (col.name == "Player") {
			Debug.Log ("MONSTER MONSTER");
			GameObject.Find ("Player").GetComponent<FirstPersonController> ().enabled = false;

		}
	
	}

	IEnumerator ScaryFace(){
		//GameObject.Find ("JumpImage").Get
		
	}

}
