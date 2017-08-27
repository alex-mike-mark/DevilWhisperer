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
		prompt = (string)node.Element ("prompt");
		//count number of response elements
		//create the response array of that size
		//call new Response that many times.
		id = (int)node.Element("id");
		type = (string)node.Attribute ("Type");
	}
}

