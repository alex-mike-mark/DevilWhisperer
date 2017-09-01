using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Xml.Linq;//let's try it out.
using System.Linq;

//responsible for converting a <node> into an object we can use
public class ConvNode
{
	string prompt;
	Option[] options;
	int id; //lots of redundency with this. kinda gross.
	string type; //make into an enum later.

	public ConvNode (XElement node)
	{
		int i = 0;
		prompt = (string)node.Element ("prompt");
		//count number of response elements
		IEnumerable<XElement> crudeResponses = node.Elements("option");
		//create the response array of that size
		int length = crudeResponses.Count();
		options = new Option[length];
		//call new Response that many times.
		foreach(XElement xe in crudeResponses){
			options[i] = new Option(xe);
			i++;
		}
		id = (int)node.Element("id");
		type = (string)node.Attribute ("Type");
	}

	public Option[] getOptions(){
		return options;
	}
}

