using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHint : MonoBehaviour {

	public int difficulty;

	private bool hint = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (difficulty == 1 || difficulty == 2) {
			//StartCoroutine (hintRay ());
		}
	}

//	private IEnumerator hintRay(){
		//yield return WaitForSeconds (60);
		//hint = true;
	//}
}
