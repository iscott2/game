using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	public int speed;
	Rigidbody ballRigidBody;

	// Use this for initialization
	void Start () {
		Debug.Log("Hello");
		ballRigidBody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(Input.GetAxis("Horizontal"));

		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");

		Vector3 direction = new Vector3 (horizontal, 0, vertical);

		// This text is ignored by the computer. This is only for us.
		// Now we add the direction as a force to the rigid body

		ballRigidBody.AddForce (direction*speed);
	}
}
