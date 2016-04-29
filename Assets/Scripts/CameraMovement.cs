using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public float CameraPanSpeed = 4f;
	Camera camera;
	Vector3 pan;


	// Use this for initialization
	void Start () {
		camera = GetComponent<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
		

	}

	void LateUpdate() {
		pan.Set (0f, 0f, 1f);
		pan = pan.normalized * CameraPanSpeed * Time.deltaTime;
		transform.position = transform.position + pan;
	}
}
