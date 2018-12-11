using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour {

	private int vida;
	public float Speed;
	public float currentTime;

	public float v1;
	public float v2;
		

	void Start () {
		vida =3;
		currentTime = 0;
		}
     
     void Update()
     {
     	 currentTime += Time.deltaTime;

     	 if(currentTime < v1){
         	transform.Translate(-(Speed * Time.deltaTime), 0, 0);
     	 }

     	 if(currentTime > v1 & currentTime < v2){
         	transform.Translate(Speed * Time.deltaTime, 0, 0);
     	 }

     	 if(currentTime > v2){
         	currentTime = 0;
     	 }

         if(vida == 0){
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
 	void OnCollisionEnter (Collision col)
    {
        if(col.gameObject.name == "Nêmesis-animada")
        {
            Application.LoadLevel("Morte");
        }
    }
    }

