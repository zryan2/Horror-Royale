using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note : MonoBehaviour 
{
	public Image noteImage; 

	public AudioClip pickupSound; 

	public AudioClip putAwaySound; 

	// Use this for initialization
	void Start () {

		noteImage.enabled = false; 
	}
	
	public void showNoteImage()
	{
		noteImage.enabled = true; 
		GetComponent<AudioSource> ().PlayOneShot (pickupSound);
	}

	public void hideNoteImage()
	{
		noteImage.enabled = false; 
		GetComponent<AudioSource> ().PlayOneShot (putAwaySound); 
	}
}
