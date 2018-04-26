using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerLight : MonoBehaviour {

	public Light lt;
	public float minWaitTime;
	public float maxWaitTime;

	void Start () {
		lt = GetComponent<Light>();
		StartCoroutine(Flicker());
	}

	IEnumerator Flicker ()
	{
		while (true)
		{
			yield return new WaitForSeconds(Random.Range(minWaitTime,maxWaitTime));
			lt.enabled = ! lt.enabled;

		}
	}

}