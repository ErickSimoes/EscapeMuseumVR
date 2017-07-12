using UnityEngine;
using UnityEngine.SceneManagement;

public class Answer : MonoBehaviour {

	public string nextScene;

	public void LoadNextScene(bool isTheCorrect) {
		if (isTheCorrect) {
			SceneManager.LoadScene(nextScene);
		} else {
			//TODO: feedback  for error
		}
	}
}
