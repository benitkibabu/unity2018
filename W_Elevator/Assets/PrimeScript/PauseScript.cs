using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour {
	public GameObject pauseMenu;
	public Button contBtn, quitBtn;
	bool isPaused = false;
	// Use this for initialization
	void Start () {
		quitBtn.onClick.AddListener (QuitGame);
		contBtn.onClick.AddListener (Continue);
	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.P)) {
			isPaused = !isPaused;
		}
		if (isPaused) {
			Time.timeScale = 0;
			pauseMenu.SetActive (true);
		} else {
			Time.timeScale = 1;
			pauseMenu.SetActive (false);
		}
	}

	void Continue(){
		pauseMenu.SetActive (false);
	}

	void QuitGame(){
		StartCoroutine (LoadScene (0));
	}
	IEnumerator LoadScene(int index){
		AsyncOperation a = SceneManager.LoadSceneAsync (index);
		while (!a.isDone) {
			yield return null;
		}
	}
}
