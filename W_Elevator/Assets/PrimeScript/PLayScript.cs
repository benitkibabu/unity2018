using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PLayScript : MonoBehaviour {
	public Transform buttonPanel;
	public Button playButton, quitButton;
	public Slider loadSlider;
	private float progress;

	// Use this for initialization
	void Start () {

		loadSlider.gameObject.SetActive (false);
		buttonPanel.gameObject.SetActive (true);
		playButton.onClick.AddListener (Play);
		quitButton.onClick.AddListener (QuitGame);
	}


	public void Play(){
		StartCoroutine (LoadScene (1));
	}

	IEnumerator LoadScene(int index){
		loadSlider.gameObject.SetActive (true);
		buttonPanel.gameObject.SetActive (false);
		AsyncOperation sceneLoad =  SceneManager.LoadSceneAsync (index);
		while (!sceneLoad.isDone) {
			progress = Mathf.Clamp01(sceneLoad.progress);
			loadSlider.value = progress;

			yield return null;
		}
	}

	public void QuitGame(){
		Application.Quit ();
	}
}
