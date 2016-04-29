using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public float CameraPanSpeed = 4f;
	Camera camera;
	Vector3 pan;
	private Rigidbody playerRB;



	// Use this for initialization
	void Start () {
		camera = GetComponent<Camera> ();
		playerRB = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		

	}

	void FixedUpdate() {
		//Vector3 movement = new Vector3 (0.0f, 0.0f, 0.4f );
		//playerRigidbody.velocity = (movement * speed);
	}

	void LateUpdate() {
		pan.Set (0f, 0f, 1f);
		pan = pan.normalized * CameraPanSpeed * Time.deltaTime;
		transform.position = transform.position + pan;
	}
}
