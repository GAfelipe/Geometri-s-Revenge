using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBoss : MonoBehaviour {

	public GameObject balaPrefab;
	public Transform nem;

	public float currentTime;

	



	// Use this for initialization
	void Start () {
	currentTime = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
		currentTime += Time.deltaTime;

		if (currentTime > 3){

			GameObject tempPrefab = Instantiate (balaPrefab) as GameObject;

			tempPrefab.transform.position = new Vector3 (transform.position.x,transform.position.y, transform.position.z);

			tempPrefab.GetComponent<Rigidbody>().AddForce(-20, 0, 0,ForceMode.Impulse);
			currentTime = 0;
		}
	}
}
