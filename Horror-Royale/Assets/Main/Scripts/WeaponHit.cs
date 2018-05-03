using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHit : MonoBehaviour {

	public GameObject monster;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
		if (col.name == "Monster") {
			Debug.Log ("HIT HIT");
			monster.GetComponent<ChasePlayer> ().weaponHit = true;
			monster.GetComponent<AudioSource> ().Play ();
			StartCoroutine (monsterHit());
		}
	}


	private IEnumerator monsterHit(){
		yield return new WaitForSeconds (5);
		GameObject.Find ("Monster").GetComponent<ChasePlayer> ().weaponHit = false;
	}
}
