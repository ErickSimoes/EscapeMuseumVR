using UnityEngine;

public class Door : MonoBehaviour {

	void Start() {
		GetComponent<Animator>().StartPlayback();
	}

	public void OpenDoor() {
		GetComponent<Animator>().StopPlayback();
	}

}
