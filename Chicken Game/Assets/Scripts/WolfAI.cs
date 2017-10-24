using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfAI : MonoBehaviour {

	public Rigidbody enemy;
	public float movespeed;
	public Transform target;

void OnTriggerStay(Collider other)
{

	if(other.gameObject.name == "FarmerBrown"){
	Debug.Log("FarmerBrown has entered Wolfy trigger");
	transform.LookAt(target);
	transform.Translate(Vector3.forward*movespeed*Time.deltaTime);
	}
  }
}

