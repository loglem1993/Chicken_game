using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenAI : MonoBehaviour {
	
	public float moveSpeed;
	public Transform FarmerBrown;
	public Transform chickenPen;
	public Transform Wolfy;
	public int points = 10; 

void OnTriggerStay(Collider other)
{

	if(other.gameObject.name == "FarmerBrown")
	{
	Debug.Log("FarmerBrown has entered wolfs trigger");
	transform.LookAt(FarmerBrown);
	transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);
	}
	else if(other.gameObject.name =="Wolfy")
	{
	Debug.Log("Wolf has entered Chicken's trigger");
	transform.LookAt(Wolfy);
	transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);
	}
}
	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.name == "Player"){
			scoreManager.Addpoints(points);
			transform.position = chickenPen.position;
			transform.rotation = chickenPen.rotation;
		
		
	
	}
  }
}

