using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cristal : MonoBehaviour {

	public Rigidbody rigidbody;
	public Rigidbody rigidbody2;
	public int vida;
	public Slider slide;
	public GameObject bandeiraPrefab;
	public GameObject menu;

	// Use this for initialization
	void Start () {
		vida = 10;
		menu.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		slide.value = vida;
		 if (vida == 2){
            rigidbody.useGravity = true;
            rigidbody2.useGravity = true;
        }

		if(vida==0){
			menu.SetActive(true);
			
			Destroy (transform.gameObject);
		}
	}
	void OnTriggerEnter( Collider collider )
 	{
 
		 if( collider.tag == "Bala" )
 			{
 				 vida-=1;
 			}
 		}
}
