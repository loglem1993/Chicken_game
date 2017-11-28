using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenAI : MonoBehaviour {
	
	public float moveSpeed;
	public Transform FarmerBrown;
	public Transform chickenPen;
	public Transform target;
	public int points = 10; 

 void Start()
{
	
}
void OnTriggerStay(Collider other)
{

	if(other.gameObject.name == "FarmerBrown")
	{
	Debug.Log("FarmerBrown has entered wolfys trigger");
	transform.LookAt(FarmerBrown);
	transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);
	}
}
	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.name == "FarmerBrown"){
			scoreManager.Addpoints(points);
			transform.position = chickenPen.position;
			transform.rotation = chickenPen.rotation;
		
		
	
	}
  }
}

