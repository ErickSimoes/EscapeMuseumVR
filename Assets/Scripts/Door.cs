using UnityEngine;

public class Door : MonoBehaviour {

	private Animator doorAnimatior;
	private AudioSource audioSource;

	private Animator DoorAnimatior {
		get {
			if (!doorAnimatior) {
				doorAnimatior = GetComponent<Animator>();
			}
			return doorAnimatior;
		}
	}

	void Start() {
		DoorAnimatior.StartPlayback();
		audioSource = GetComponent<AudioSource>();
	}

	public void OpenDoor() {
		audioSource.Play();
		DoorAnimatior.StopPlayback();
		GetComponent<BoxCollider>().enabled = false;
	}

}
