using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estalactite1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Destroy (transform.gameObject, 2.0f);
	}
}
