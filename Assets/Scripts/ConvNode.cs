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
	Response[] responses;
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
		responses = new Response[length];
		//call new Response that many times.
		foreach(XElement xe in crudeResponses){
			responses[i] = new Response(xe);
			i++;
		}
		id = (int)node.Element("id");
		type = (string)node.Attribute ("Type");
	}
}

