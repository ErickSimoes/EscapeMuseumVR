using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Answer : MonoBehaviour {

	public string nextScene;
	public Image panel;

	public void LoadNextScene(bool isTheCorrect) {
		if (isTheCorrect) {
			StartCoroutine(FadeAndOut());
			print("Acabou");
		} else {
			//TODO: feedback  for error
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
