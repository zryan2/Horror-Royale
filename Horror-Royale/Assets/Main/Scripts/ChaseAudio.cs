using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseAudio : MonoBehaviour {


	public AudioClip monsterClose;

	private AudioSource audioSource;
	private bool inCollider = false;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();	
	}

	// Update is called once per frame
	void Update () {
		if (!inCollider)
			audioSource.Stop ();
	}

	void OnTriggerEnter(Collider col){
		if (col.name == "Player") {
			audioSource.PlayOneShot (monsterClose);
			inCollider = true;
		}
	}

	void OnTriggerExit(Collider col){
		inCollider = false;
	}
}
