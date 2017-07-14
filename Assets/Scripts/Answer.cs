using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Answer : MonoBehaviour {

	public string nextScene;
	public Image panel;
	private float duration = 3f;

	void Start() {
		StartCoroutine(FadeIn());
	}

	public void LoadNextScene(bool isTheCorrect) {
		if (isTheCorrect) {
			StartCoroutine(FadeAndOut());
			print("Acabou");
		} else {
			//TODO: feedback  for error
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
		for (float i = 0; i < 1; i = i + 0.01f) {
			panel.color = new Color(0f, 0f, 0f, i);
			yield return null;
		}

		SceneManager.LoadScene(nextScene);
		yield return new WaitForSeconds(2f);
	}
}
