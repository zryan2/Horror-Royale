using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Raycast : MonoBehaviour {

	public float clickRate = 0.50f;
	public float clickRange = 1f;
	private float nextFire;


	GameObject weapon_1;

	void Start(){
		int weapon_1Location = Random.Range (1, 4);
		weapon_1 = GameObject.Find ("weapon_"+ weapon_1Location +"_floor");
		weapon_1.GetComponent<MeshRenderer> ().enabled = true;

	}
	// Update is called once per frame
	void Update () {

		//Debug raycast in the editor
		float theDistance;
		Vector3 forward = transform.TransformDirection (Vector3.forward)*3;
		Debug.DrawRay (transform.position, forward, Color.green);

		//// Clicking with a mouse
		//if (Input.GetButtonDown ("Fire1") && Time.time > nextFire) {
		if (Input.GetKey (KeyCode.E) && Time.time > nextFire) {
			nextFire = Time.time + clickRate;
			RaycastHit hit;

			// Test raycasting
			if (Physics.Raycast (transform.position, (forward), out hit, clickRange)) {
				//TODO: Make a tag for each clue so it can count it 
				if (hit.collider.gameObject.name == "Clue_1") {
					addPage (1);
					print ("Found 1st clue!");

				} else if (hit.collider.gameObject.name == "Clue_2") {
					addPage (2);
					print ("Found 2nd clue!");
				}
				else if (hit.collider.gameObject.tag == "weapon1") {
					weapon_1.SetActive (false);
					GameObject.Find("weapon_1_attached").GetComponent<MeshRenderer> ().enabled = true;
					GameObject.Find ("Right Hand").SetActive (false);
				}
				else {
					theDistance = hit.distance;
					print (theDistance + " " + hit.collider.gameObject.name);
				}
			}
		}
	}

	private void addPage(int clueNum){
		if (Journal.pageNum < 5) {
			Journal.pageNum++;
			GameObject.Find ("PageCount").GetComponent<Text> ().text = Journal.pageNum + "/5";
			switch (clueNum) {
				case(1):
					Journal.clue1Found = true;
					break;
				case(2):
					Journal.clue2Found = true;
					break;
				case(3):
					Journal.clue3Found = true;
					break;
				case(4):
					Journal.clue4Found = true;
					break;
				case(5):
					Journal.clue5Found = true;
					break;
			}
		}
	}
	/*
	private IEnumerator clickPause(){
		yield return WaitForSeconds (clickRate);
	}
	*/
}
