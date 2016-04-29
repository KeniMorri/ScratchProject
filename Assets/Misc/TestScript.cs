using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour {

	private int test;
	Animator anim;
	Camera cam;
	Rigidbody playerRigidbody;
	Vector3 movement;
	public float speed = 6f;


	// Use this for initialization
	void Start () {
		playerRigidbody = GetComponent <Rigidbody> ();
		test = 0;
		anim = GetComponent <Animator> ();
		cam = GetComponent <Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
		/*
		movement.Set (0f, 0f, 1f);
		//Debug.Log (movement);
		// Normalise the movement vector and make it proportional to the speed per second.
		movement = movement.normalized * speed * Time.deltaTime;

		// Move the player to it's current position plus the movement.
		playerRigidbody.MovePosition (transform.position + movement); */
		test++;
		if ((test % 400) == 0) {
			anim.SetBool ("Next", true);
		} 
		else {
			anim.SetBool ("Next", false);
		}
	}
}
