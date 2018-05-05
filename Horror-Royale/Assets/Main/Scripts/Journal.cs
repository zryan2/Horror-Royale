using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Journal : MonoBehaviour {
	public GameObject journalIcon;
	public GameObject journalPage;
	public Text pageCount;
	public Texture openJournal;
	public Texture closeJournal;

	public static bool clue1Found = false;
	public static bool clue2Found = false;
	public static bool clue3Found = false;
	public static bool clue4Found = false;
	public static bool clue5Found = false;

	public float clickRate = 0.25f;
	private float nextFire;

	private bool journalOpened = false;
	public static int pageNum = 0;
	// Use this for initialization
	void Start () {
		journalPage.GetComponent<RawImage> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Q) && Time.time > nextFire) {
			nextFire = Time.time + clickRate;
			// Open Journal
			if (!journalOpened) {
				journalIcon.GetComponent<RawImage> ().texture = openJournal;
				journalPage.GetComponent<RawImage> ().enabled = true;
				GameObject.Find ("Player").GetComponent<FirstPersonController> ().enabled = false;
				if(clue1Found)
					GameObject.Find ("clue1_text").GetComponent<Text> ().enabled = true;
				if(clue2Found)
					GameObject.Find ("clue2_text").GetComponent<Text> ().enabled = true;
				if(clue3Found)
					GameObject.Find ("clue3_text").GetComponent<Text> ().enabled = true;
				if(clue4Found)
					GameObject.Find ("clue4_text").GetComponent<Text> ().enabled = true;
				if(clue5Found)
					GameObject.Find ("clue5_text").GetComponent<Text> ().enabled = true;
				journalOpened = true;
			} else {
				journalIcon.GetComponent<RawImage>().texture = closeJournal;
				journalPage.GetComponent<RawImage> ().enabled = false;
				GameObject.Find ("Player").GetComponent<FirstPersonController> ().enabled = true;
				GameObject.Find ("clue1_text").GetComponent<Text> ().enabled = false;
				GameObject.Find ("clue2_text").GetComponent<Text> ().enabled = false;
				GameObject.Find ("clue3_text").GetComponent<Text> ().enabled = false;
				GameObject.Find ("clue4_text").GetComponent<Text> ().enabled = false;
				GameObject.Find ("clue5_text").GetComponent<Text> ().enabled = false;
				journalOpened = false;
			}
		}else if(Input.GetKey(KeyCode.Escape)){

		
		}
	}
}
