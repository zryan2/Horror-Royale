using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OnCollisionEnter : MonoBehaviour {

	bool scaryFace = false;
	public GameObject jumpImage;

	private float jumpX, jumpY = 3f;
	private bool jumpRotate = true;

	void Start(){

	}
	// Update is called once per frame
	void Update () {

		if (scaryFace) {
			jumpImage.GetComponent<RawImage> ().transform.localScale = new Vector3 (jumpX+6f, jumpY, 0f);
			if (jumpX <= 8f) {
				jumpX += 0.5f;
				jumpY += 0.5f;
				StartCoroutine (rotateScare());
			}
		}
	}

	void OnTriggerEnter(Collider col){
		if (col.name == "Player") {
			//Debug.Log ("MONSTER MONSTER");
			GameObject.Find ("Player").GetComponent<FirstPersonController> ().enabled = false;
			StartCoroutine (ScaryFace());
		}
	}

	IEnumerator ScaryFace(){

		yield return new WaitForSeconds(1);
		//GameObject.Find ("JumpImage").GetComponent<RawImage>().transform.localScale = new Vector3(2,2,2);
		scaryFace = true;
	}

	IEnumerator rotateScare(){
		yield return new WaitForSeconds (0.5f);
		if (jumpRotate) {
			jumpImage.GetComponent<RawImage> ().rectTransform.Rotate (new Vector3 (0, 0, 30f));
			jumpRotate = false;
		} else {
			jumpImage.GetComponent<RawImage> ().rectTransform.Rotate (new Vector3 (0, 0, -30f));
			jumpRotate = true;
		}
		Debug.Log ("PLAY AGAIN");
		StartCoroutine (playAgain ());


	}
	IEnumerator playAgain(){
		yield return new WaitForSeconds (2);
		Application.LoadLevel(Application.loadedLevel);
		Debug.Log ("PLAY AGAIN");
	}

}
