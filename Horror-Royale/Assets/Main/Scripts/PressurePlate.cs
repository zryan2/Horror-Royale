using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour {

	public GameObject plate;
	public GameObject tombstoneClosed;
	public GameObject tombstoneOpened;
	public AudioSource stoneMove;

	private bool playOnce = true;
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
		if (col.name == "Player" && playOnce) {
			playOnce = false;
			tombstoneClosed.GetComponent<MeshRenderer> ().enabled = false;
			tombstoneClosed.GetComponent<Collider> ().enabled = false;
			tombstoneOpened.GetComponent<MeshRenderer> ().enabled = true;
			tombstoneOpened.GetComponent<Collider> ().enabled = true;
			this.gameObject.GetComponent<AudioSource> ().Play ();
			StartCoroutine (playStoneAudio ());
		}
	}

	IEnumerator playStoneAudio(){
		yield return new WaitForSeconds (1f);
		stoneMove.Play ();
		yield return new WaitForSeconds (3.5f);
		stoneMove.Stop ();
	}
}
