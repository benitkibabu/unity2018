using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveScript : MonoBehaviour {

	public float moveFoce = 200;
	public float brakeForce = 100;
	public float steerAmount = 10.0f;
	public WheelCollider[] colliders;
	// Use this for initialization
	void Start () {
		if (colliders == null)
			Debug.Log ("Need wheel collider");
		
	}
	
	// Update is called once per frame
	void Update () {

		float steerInput = Input.GetAxis ("Horizontal");
		colliders [0].steerAngle = steerInput * steerAmount;
		colliders [1].steerAngle = steerInput * steerAmount;


		if(Input.GetKey(KeyCode.UpArrow)){
			foreach (WheelCollider w in colliders) {
				w.motorTorque = moveFoce;
				w.brakeTorque = 0;
			}
		}

		if(Input.GetKey(KeyCode.DownArrow)){
			foreach (WheelCollider w in colliders) {
				w.motorTorque = 0;
				w.brakeTorque = brakeForce;
			}
		}
			
	}
}
