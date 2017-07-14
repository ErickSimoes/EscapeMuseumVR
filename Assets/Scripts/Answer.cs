using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Answer : MonoBehaviour {

	public string nextScene;
	public Image panel;
	public AudioSource failSound;
	private float duration = 3f;

	void Start() {
		StartCoroutine(FadeIn());
	}

	public void LoadNextScene(bool isTheCorrect) {
		if (isTheCorrect) {
			StartCoroutine(FadeAndOut());
		} else {
			failSound.Play();
		}
	}

	IEnumerator FadeIn() {
		float startTime = Time.time;
		float step;
		panel.color = Color.black;
		while (panel.color != Color.clear) {
			step = (Time.time - startTime) / duration;
			panel.color = Color.Lerp(Color.black, Color.clear, step);
			yield return null;
		}
	}

	IEnumerator FadeAndOut() {
		float startTime = Time.time;
		float step;
		while (panel.color != Color.black) {
			step = (Time.time - startTime) / (duration / 3);
			panel.color = Color.Lerp(Color.clear, Color.black, step);
			yield return null;
		}
		SceneManager.LoadScene(nextScene);
	}
}
