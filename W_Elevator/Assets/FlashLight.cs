using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour {
	public Light flahsLight;
	// Use this for initialization
	void Start () {
		flahsLight.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (flahsLight != null) {
			if (Input.GetKeyDown (KeyCode.Mouse0)) {
				flahsLight.enabled = !flahsLight.enabled;
			}
		}
	}
}
