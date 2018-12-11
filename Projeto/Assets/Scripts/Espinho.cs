using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espinho : MonoBehaviour {

	public float currentTime;
	private Animator animE;
	public Transform colisor;

	private Vector3 inicio;
	private Vector3 fim;
	
	

	// Use this for initialization
	void Start () {
		currentTime = 0;
		animE = gameObject.GetComponent<Animator>();
		inicio = new Vector3(colisor.position.x, colisor.position.y, colisor.position.z);
		fim = new Vector3(colisor.position.x, colisor.position.y+0.9f, colisor.position.z);
	}
	
	// Update is called once per frame
	void Update () {

		currentTime += Time.deltaTime;

		if(currentTime > 3 && currentTime <5){
			animE.SetBool("sobe",true);
			animE.SetBool("desce",false);
		}


		if(currentTime > 3.2f && currentTime <4.5){
			colisor.position = fim;
		}

		if(currentTime > 8 && currentTime <9){
			animE.SetBool("sobe",false);
			animE.SetBool("desce",true);
		}
		if(currentTime > 7.9f && currentTime <8.5f){
			colisor.position = inicio;
		}
		
		if(currentTime >10){
			currentTime = 0;
			

		}


	}

}
