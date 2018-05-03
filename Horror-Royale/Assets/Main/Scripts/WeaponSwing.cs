using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwing : MonoBehaviour {
	private float nextFire;
	public float clickRate = 0.50f;
	public GameObject weapon1;

	private Collider weaponCollider;
	// Use this for initialization
	void Start () {
		weaponCollider = weapon1.GetComponent<Collider> ();
		weaponCollider.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Mouse1) && Time.time > nextFire) {
			nextFire = Time.time + clickRate;
			// If you have weapon attached
			if (weapon1.GetComponent<MeshRenderer> ().isVisible) {
				weaponCollider.enabled = true;
				// Swing weapon
				weapon1.transform.Rotate(new Vector3(0,0,-45));
				weapon1.GetComponent<AudioSource> ().Play ();
				//weapon1.transform.rotation = Quaternion.Slerp (this.transform.rotation, Quaternion.LookRotation (new Vector3(0,0,-0)),0.01f);
				StartCoroutine (swingReturn ());

			}
		}
	}

	private IEnumerator swingReturn(){
		yield return new WaitForSeconds (0.25f);
		weapon1.transform.Rotate(new Vector3(0,0,45));
		weaponCollider.enabled = false;
	}
}
