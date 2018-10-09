using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {

	public float speed;
	public float x;
	public Transform bala;
	public GameObject bl;
	

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		x = bala.position.x;
		x += speed * Time.deltaTime;
		bala.position = new Vector3 (x, bala.position.y, bala.position.z);
		Destroy(bl, 2.0f);


	
}
void OnTriggerEnter(Collider collider){
		if (collider.tag =="Cubo") {
			Destroy (transform.gameObject);

		}
	}

}
