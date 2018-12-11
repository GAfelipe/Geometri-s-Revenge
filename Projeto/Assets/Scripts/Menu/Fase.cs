using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fase : MonoBehaviour {
	public GameObject menu;
	public float currentTime;

	// Use this for initialization
	void Start () {
		currentTime = 0f;
		
	}
	
	// Update is called once per frame
	void Update () {
		currentTime += Time.deltaTime;
		if(currentTime > 2)
		menu.SetActive(false);
		
	}
}
