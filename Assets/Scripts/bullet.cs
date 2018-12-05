using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {

	
	public GameObject bl;


	
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		Destroy(bl, 1.0f);


	
}
void OnTriggerEnter(Collider collider){
		if (collider.tag =="Cubo") {
			Destroy (transform.gameObject);

		}
		if (collider.tag =="Parede2") {
			Destroy (transform.gameObject);

		}
		if (collider.tag =="Cristal") {
			Destroy (transform.gameObject);

		}
	}

}
