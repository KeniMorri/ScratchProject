using UnityEngine;
using System.Collections;

public class SimpleDestroyScript : MonoBehaviour {
	private Event gameController;
	// Use this for initialization
	void Start () {
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		gameController = gameControllerObject.GetComponent<Event> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		gameController.gameover ();
		Destroy (other.gameObject);
		Destroy (this.gameObject);
	}
}
