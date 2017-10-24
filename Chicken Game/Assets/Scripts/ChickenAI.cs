using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenAI : MonoBehaviour {
	
	public Rigidbody enemy;
	public float movespeed;
	public Transform target;

void OnTriggerStay(Collider other)
{

	if(other.gameObject.name == "FarmerBrown"){
	Debug.Log("FarmerBrown has entered chickens trigger");
	transform.LookAt(target);
	transform.Translate(Vector3.back*movespeed*Time.deltaTime);
	}
  }
}
