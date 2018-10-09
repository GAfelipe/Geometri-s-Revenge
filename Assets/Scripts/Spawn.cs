using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	public GameObject balaPrefab;

	public float currentTime;


	// Use this for initialization
	void Start () {
	currentTime = 0;
	}
	
	// Update is called once per frame
	void Update () {
		currentTime += Time.deltaTime;

		if (Input.GetAxis("Fire1") > 0 & currentTime > 1){

			GameObject tempPrefab = Instantiate (balaPrefab) as GameObject;

			tempPrefab.transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z);

			currentTime = 0;
		}
	}
}

