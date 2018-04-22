using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasePlayer : MonoBehaviour {

	static Animator anim;

	public Transform player;
	public int distance;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (player.position, this.transform.position) < distance) {
			Vector3 direction = player.position - this.transform.position;
			direction.y -= 1;
			this.transform.rotation = Quaternion.Slerp (this.transform.rotation,
				Quaternion.LookRotation (direction), 0.1f);

			anim.SetBool ("isIdle", false);
			if (direction.magnitude > 5) {
				anim.SetBool ("isChasing", true);
			}

		} else {
			anim.SetBool ("isIdle", true);
			anim.SetBool ("isChasing", false);
		}
	}
}
