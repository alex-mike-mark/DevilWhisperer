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

	public bool isActive;
	public bool StopMovement;

	public PlayerController player;

	//public PlayerController.

	// Use this for initialization
	void Start () {
		//splits at every new line.
		//not really what I want tbh, but we'll settle for
		//now.

		//Grab your player controller.
		player = FindObjectOfType<PlayerController>();
		if (textFile != null) {
			textLines = (textFile.text.Split ('\n'));
		}

		if (endAtLine == 0) {
			endAtLine = textLines.Length - 2;//-1 to prevent off by one error and not use the last line.
		}

		if (isActive) {
			EnableTextBox ();
		} else {
			DisableTextBox ();
		}

	}

	void Update(){
		if (!isActive) {
			return;
		}
		theText.text = textLines[currLine];
		if (Input.GetKeyDown (KeyCode.Space) && currLine <= endAtLine) {
			currLine++;
		}

		if (currLine > endAtLine) {
			DisableTextBox ();
		}
	}

	public void EnableTextBox(){
		textBox.SetActive (true);
		isActive = true;
		if (StopMovement) {
			player.canMove = false;
		}
	}

	public void DisableTextBox(){
		textBox.SetActive (false);
		player.canMove = true;
		isActive = false;
	}

	public void ReloadScript(TextAsset newText){
		if (newText != null) {
			textLines = new string[1];
			textLines = (newText.text.Split ('\n'));
		}
		if (endAtLine == 0) {
			endAtLine = textLines.Length-1;
		}
	}
}
