using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfAI : MonoBehaviour {

public float movespeed;
public Transform target;
public int damage;




void OnTriggerStay(Collider other)
{

	if(other.gameObject.name == "FarmerBrown"){
	transform.LookAt(target);
	transform.Translate(Vector3.forward*movespeed*Time.deltaTime);
	}
}
	void OnCollisionEnter(Collision other)
	{
			print("wolf is attacking");
			var hit = other.gameObject;
		    var health = hit.GetComponent<playerHealth>();
			if(health !=null)
				health.TakeDamage(damage);
		}	
    }
	


