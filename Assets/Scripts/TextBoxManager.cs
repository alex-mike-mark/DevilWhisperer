using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour {

	public TextAsset textFile;
	public string[] textLines;

	public GameObject textBox;
	public Text theText;

	public int currLine;
	public int endAtLine;

	//public PlayerController.

	// Use this for initialization
	void Start () {
		//splits at every new line.
		//not really what I want tbh, but we'll settle for
		//now.

		//Grab your player controller.

		if (textFile != null) {
			textLines = (textFile.text.Split ('\n'));
		}

		if (endAtLine == 0) {
			endAtLine = textLines.Length - 2;//-1 to prevent off by one error and not use the last line.
		}

	}

	void Update(){
		theText.text = textLines[currLine];
		if (Input.GetKeyDown (KeyCode.Space) && currLine <= endAtLine) {
			currLine++;
		}

		if (currLine > endAtLine) {
			textBox.SetActive (false);

		}
	}
}
