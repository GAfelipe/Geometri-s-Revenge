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

	// Use this for initialization
	void Start () {
		vida = 10;
	}
	
	// Update is called once per frame
	void Update () {
		slide.value = vida;
		 if (vida == 2){
            rigidbody.useGravity = true;
            rigidbody2.useGravity = true;
        }

		if(vida==0){
			GameObject tempPrefab = Instantiate (bandeiraPrefab) as GameObject;

			tempPrefab.transform.position = new Vector3 (transform.position.x,transform.position.y, transform.position.z);
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
