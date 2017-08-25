using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextImporter : MonoBehaviour {

	public TextAsset textFile;
	public string[] textLines;

	// Use this for initialization
	void Start () {
		//splits at every new line.
		//not really what I want tbh, but we'll settle for
		//now.
		if (textFile != null) {
			textLines = (textFile.text.Split('\n'));
		}
	}
}
