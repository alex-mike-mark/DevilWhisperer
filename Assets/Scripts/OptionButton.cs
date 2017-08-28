using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionButton : MonoBehaviour {

	public Button button;
	public string response;
	//ConvNode node

	private Option opt;
	private ConversationManager cm;

	// Use this for initialization
	void Start () {
		
	}

	public void Setup(Option opt, ConversationManager cm){
		this.opt = opt;
		response = opt.getResponse ();
		this.cm = cm;
	}
}