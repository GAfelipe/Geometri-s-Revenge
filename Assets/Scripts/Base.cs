using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour {
	public Rigidbody Rigidbody;
	public Collider coll;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//if(coll.isTrigger == true){
		//Rigidbody.useGravity = true;

		}
		 void OnTriggerEnter(Collider coll)
    {
        if (coll.attachedRigidbody)
            Rigidbody.useGravity = true;
    } 
 
	}

