using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, zMin, zMax;
}

public class PlayerMovement : MonoBehaviour {

	private int test;
	Animator anim;
	Camera cam;
	Rigidbody playerRigidbody;
	Vector3 movement;
	public float speed = 6f;
	public Boundary boundary;



	// Use this for initialization
	void Start () {
		playerRigidbody = GetComponent <Rigidbody> ();
		anim = GetComponent <Animator> ();
		cam = Camera.main;
		anim.SetBool ("RunningForward", true);
	}

	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Move (moveHorizontal, moveVertical);
		if (Input.GetButton ("Fire1"))
			slide ();
		else
			Animation (moveHorizontal, moveVertical);
	}

	void Move (float h, float v) {
		
		Vector3 movement = new Vector3 (h, 0.0f, (0.0f + v) );
		playerRigidbody.velocity = (movement * speed);
		// This is supposed to make it so character can't leave boundary, but i can't get it to work properly
		playerRigidbody.position = new Vector3 (
			Mathf.Clamp(playerRigidbody.position.x, boundary.xMin,boundary.xMax),
			0.0f, 
			Mathf.Clamp(playerRigidbody.position.z,(cam.transform.position.z - boundary.zMin),(cam.transform.position.z + boundary.zMax))
		);
		/* Survival Shooter Movement
		movement.Set (h, 0f, v);
		movement = movement.normalized * speed * Time.deltaTime;
		playerRigidbody.MovePosition (transform.position + movement);
		*/

	}

	void Animation(float h, float v) {
		//Very rough animation
		if (h < 0.0f) {
			anim.SetBool ("RunningLeft", true);
			anim.SetBool ("RunningRight", false);
		} else if (h > 0.0f) {
			anim.SetBool ("RunningLeft", false);
			anim.SetBool ("RunningRight", true);
		} else {
			anim.SetBool ("RunningLeft", false);
			anim.SetBool ("RunningRight", false);
		}
	}
	void slide() {
		anim.SetBool ("RunningLeft", false);
		anim.SetBool ("RunningRight", false);
		anim.SetBool ("Slide", true);
	}
}
