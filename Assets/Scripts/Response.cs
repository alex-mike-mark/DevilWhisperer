using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Xml.Linq;//let's try it out.
using System.Linq;

//takes in a <response> XElement, resolves the possibilities
public class Response
{
	string text;
	int nextId;

	public Response (XElement response)
	{
		text = (string)response.Element ("response");
		IEnumerable<XElement> possibilities = response.Elements ("possibility");
		nextId = resolvePossibility (possibilities);
	}

	//takes in all of the possibilities for a response and picks one.
	//NOTE: IF WE WANT TO HAVE PLAYER LUCK EFFECT THIS, WE'LL NEED TO PASS IT DOWN SOMEHOW. 
	private int resolvePossibility(IEnumerable<XElement> possibilities){
		//yeah, this one'll get redone.
		//the original idea is you have a weightValue modified by player luck. If that beats a weight, that one doesn't get picked.
		//but the lightest one you don't beat does.
		//if you beat them all, the heaviest gets picked.
		XElement[] parr = possibilities.ToArray();
		System.Random rng = new System.Random ();
		return (int)parr[rng.Next (parr.Count())].Element("next");
	}
}

