using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Answer : MonoBehaviour {

	public string nextScene;

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
			print(i);
			FadePanel.FadeOut(i);
			yield return null;
		}

		SceneManager.LoadScene(nextScene);
		yield return new WaitForSeconds(3f);
	}
}
