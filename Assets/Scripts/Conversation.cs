using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Xml.Linq;//let's try it out.
using System.Linq;

public class Conversation : MonoBehaviour
{
	XElement convosheet;
	//IEnumerable<XElement> cnodes;

	void Start(){
		Debug.Log ("It starts");
		convosheet = XElement.Load ("./Assets/Scripts/pers_chad.xml");//currently hardcoded for testing.
		if (convosheet == null) {
			Debug.Log ("It didn't get init.");
		} else {
			Debug.Log ("It gets init");
		}
		startConversation ();
	}

	void Update(){
	
	}

	public ConvNode startConversation(){
		//the idea here is to grab a random root and create a ConvNode for it.

		//grab random root element
		Debug.Log("start convo called");
		var roots = from rn in convosheet.Elements("node")
			where (string)rn.Attribute("Type") == "root"
			select rn;

	
		
		//create ConvNode from it.
		Debug.Log("Start convo end");
		return null;
	}


}


