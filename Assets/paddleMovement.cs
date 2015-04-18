using UnityEngine;
using System.Collections;

using LockingPolicy = Thalmic.Myo.LockingPolicy;
using Pose = Thalmic.Myo.Pose;
using UnlockType = Thalmic.Myo.UnlockType;
using VibrationType = Thalmic.Myo.VibrationType;

public class paddleMovement : MonoBehaviour {
	Vector3 offset;
	public GameObject myo = null;
	// Use this for initialization
	void Start () {
		offset= new Vector3((Input.mousePosition.x - 0) * (10) / Screen.width,Screen.height/2-(Input.mousePosition.y - 0) * (10) / Screen.height + -5,0);
	}

	// Update is called once per frame
	void Update () {
		ThalmicMyo thalmicMyo = myo.GetComponent<ThalmicMyo> ();
		float x = (thalmicMyo.accelerometer.x - 0) * (7.2f) / Screen.width + -3;//-offset.x;//subtract a1, multiply range2/range1, add a2
		float y = (thalmicMyo.accelerometer.y - 0) * (2.8f) / Screen.height ;//-offset.y;
		this.transform.position = new Vector3(x,y,0);
		if (thalmicMyo.pose == Pose.WaveIn) 
				rotateLeft ();
		if (thalmicMyo.pose == Pose.WaveOut)
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