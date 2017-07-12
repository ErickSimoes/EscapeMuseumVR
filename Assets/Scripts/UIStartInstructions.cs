using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStartInstructions : MonoBehaviour {

	private Text welcomeText;
	private Button buttonText;

	private List<string> instructions = new List<string>();
	private int i = 0;

	void Start () {
		welcomeText = GetComponentInChildren<Text>();
		buttonText = GetComponentInChildren<Button>();

		instructions.Add("Enter the museum and\nlearn about great artists");
		instructions.Add("Look at the paintings\nand answer the questions");
		instructions.Add("Good luck\nand enjoy!");
	}

	public void OnClick() {
		if (i < instructions.Count) {
			welcomeText.text = instructions[i++];
		}

		if (i == instructions.Count) {
			buttonText.GetComponentInChildren<Text>().text = "START";
			i++;
		} else if (i > instructions.Count) {
			GetComponentInParent<Canvas>().enabled = false;
		}
	}
}
