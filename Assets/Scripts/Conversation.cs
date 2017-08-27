using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Xml.Linq;//let's try it out.
using System.Linq;

//this class is apparently responsible for getting a bunch of XML shit.
public class Conversation : MonoBehaviour
{
	XElement convosheet;
	//IEnumerable<XElement> cnodes;

	void Start(){
		Debug.Log ("It starts");
		convosheet = XElement.Load ("./Assets/Scripts/pers_chad.xml");//currently hardcoded for testing.
		if (convosheet == null) {
			Debug.Log ("It didn't get init.");
		}
		startConversation ();
	}

	void Update(){
	
	}

	public void startConversation(){
		ConvNode root = getConvRoot ();

	}

	private ConvNode getConvRoot(){
		//the idea here is to grab a random root and create a ConvNode for it.
		//the way it's written right now, I am convinced it's pretty bad.

		//grab random root element
		var roots = from rn in convosheet.Elements ("node")
		            where (string)rn.Attribute ("Type") == "root"
		            select rn;
		var rarr = roots.ToArray ();
		System.Random rng = new System.Random ();
		XElement root = rarr[rng.Next (rarr.Count())];

		//create ConvNode from it.
		return new ConvNode(root);
	}
}