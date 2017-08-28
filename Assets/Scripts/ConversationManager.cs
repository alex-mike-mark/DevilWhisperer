using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//
public class ConversationManager : MonoBehaviour {

	private bool isActive;
	ConvNode currNode;
	public Conversation conv;
	//public GameObject panel;
	public Transform contentPanel;
	public SimpleObjectPool bop;

	// Use this for initialization
	void Start () {
		
		initPanel ();
		refreshDisplay ();	
	}

	public void refreshDisplay(){
		addButtons ();
	}

	public void initPanel(){
		conv = new Conversation ();
		currNode = conv.getCurr ();
	}

	private void addButtons(){
		//figure out how many options are in ConvNode
		//
		Option[] opts = currNode.getOptions();
		foreach (Option opt in opts) {
			GameObject newButton = bop.GetObject ();
			newButton.transform.SetParent (contentPanel);

			OptionButton newOB = newButton.GetComponent<OptionButton> ();
			newOB.Setup (opt, this);
		}
	}
}
