using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Generic : MonoBehaviour {
	//position
	// public float posX;
	// public float posY = 0.5f;
	// public float posZ;
	public Vector3 pos;
	//Rotate
	// public float rotX;
	// public float rotY;
	// public float rotZ;
	// public float rotW; 
	public Quaternion rot;
	//scale
	// public float X = 1f;
	// public float Y = 1f;
	// public float Z = 1f;
	public Vector3 scale;


	// Use this for initialization
	void Start () {
		scale = transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
		// transform.position = new Vector3(posX,posY,posZ);
		// transform.rotation = new Quaternion(rotX,rotY,rotZ,rotW);
		// transform.localScale = new Vector3(X,Y,Z);

		transform.position = pos;
		transform.rotation = rot;
		scale = Vector3.one;
		
	}
}
