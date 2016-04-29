using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Event : MonoBehaviour {
	private bool GameOver = false;
	private bool restart = false;
	public Text gameOverText;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (restart) {
			if (Input.GetKeyDown (KeyCode.R)) {
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
			}
		}
	}
	public void gameover() {
		gameOverText.text = "Game Over! \n Press R to restart";
		restart = true;
	}
}
