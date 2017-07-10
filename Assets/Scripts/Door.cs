using UnityEngine;

public class Door : MonoBehaviour {

	private Animator doorAnimatior;

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
	}

	public void OpenDoor() {
		DoorAnimatior.StopPlayback();
	}

}
