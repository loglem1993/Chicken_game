using UnityEngine;
using System.Collections.Generic;
using UnityEngine.AI;

public class WolfAI : MonoBehaviour {

public float movespeed;

public Transform target;

public int damage;

public GameObject pclHealth;



void OnTriggerStay(Collider other)
{

	if(other.gameObject.name == "FarmerBrown"){
	Debug.Log("FarmerBrown has entered Wolfy trigger");
	transform.LookAt(target);
	transform.Translate(Vector3.forward*movespeed*Time.deltaTime);
	}
}
	void OnCollisionEnter(Collision other)
	{
	
		if(other.gameObject.name == "FarmerBrown"){
		var hit = other.gameObject;
		var health = hit.GetComponent<playerHealth>();
		
		if(pclHealth != null){
			print("wolf is attacking");
			// pclHealth.TakeDamage(damage);
			other.gameObject.GetComponent<playerHealth>().TakeDamage(damage);
		}	
    }
	}
}

