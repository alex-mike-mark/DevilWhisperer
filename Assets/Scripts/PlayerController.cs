using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	//Movement stuff unashamededly stolen from robertbu's suggestion in stackoverflow question
	//<http://answers.unity3d.com/questions/611343/movement-2d-in-a-grid.html>
	private float speed = 2.0f;
	private Vector3 pos;
	private Transform tr;

	public bool canMove;

	void Start() {
		canMove = true;
		tr = GetComponent<Transform> ();
		pos = tr.position;
	}

	void Update() {
		//movement shit
		//the "pace" is too long. Somehow gotta have it move over 40px exactly.
		if(canMove){
			if (Input.GetAxis("Horizontal")>0 && tr.position == pos) {
				pos += Vector3.right;
			}
			else if (Input.GetAxis("Horizontal")<0 && tr.position == pos) {
				pos += Vector3.left;
			}
			else if (Input.GetAxis("Vertical")>0 && tr.position == pos) {
			pos += Vector3.up;
			}
			else if (Input.GetAxis("Vertical")<0  && tr.position == pos) {
				pos += Vector3.down;
			}
		
			transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed); 
		//movement shit
		}
	}
}
