using System;

public class Response
{
	string text;
	int weight;
	int nextId;

	public Response (string text, int weight, int nextID)
	{
		this.text = text;
		this.weight = weight;
		this.nextId = nextID;
	}
}

