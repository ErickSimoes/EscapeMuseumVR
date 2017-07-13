using UnityEngine;
using UnityEngine.UI;

public class FadePanel : MonoBehaviour {

	private static Image image;
	private static float a = 0;

	void Start() {
		image = GetComponent<Image>();
	}

	void Update() {
		image.color = new Color(0f, 0f, 0f, a);
	}

	public static void FadeOut(float alpha) {
		a = alpha;
	}
}
