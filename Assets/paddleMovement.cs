using UnityEngine;
using System.Collections;

public class paddleMovement : MonoBehaviour {
	Vector3 offset;
	// Use this for initialization
	void Start () {
		offset= new Vector3((Input.mousePosition.x - 0) * (10) / Screen.width,Screen.height/2-(Input.mousePosition.y - 0) * (10) / Screen.height + -5,0);
	}

	// Update is called once per frame
	void Update () {
		float x = (Input.mousePosition.x - 0) * (7.2f) / Screen.width + -3;//-offset.x;//subtract a1, multiply range2/range1, add a2
		float y = (Input.mousePosition.y - 0) * (2.8f) / Screen.height ;//-offset.y;
		this.transform.position = new Vector3(x,y,0);
		if (Input.GetKey(KeyCode.A))
				rotateLeft ();
		if (Input.GetKey(KeyCode.D))
			rotateRight ();
	}

	void rotateLeft(){
		print (transform.GetChild(0).rotation.z);
		if (transform.GetChild(0).rotation.z > -.7)
		transform.GetChild(0).Rotate (0,0,-2);
	}
	void rotateRight(){
		print (transform.GetChild(0).rotation.z);
		if (transform.GetChild(0).rotation.z < .025)
		transform.GetChild(0).Rotate (0,0,2);
	}
}
