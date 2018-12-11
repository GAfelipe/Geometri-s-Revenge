using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour {
	public float currentTime;
	public Rigidbody rb;
	private int etapa;
	public int contador;
	public bool direcao;
	public GameObject plataforma;
	public GameObject plataforma2;
	public bool chave;
	public int vida1;
	public GameObject cristall;
	// Use this for initialization
	void Start () {
		etapa = 1;
		contador =0;
		direcao = true;
		chave = true;
		
	}
	
	// Update is called once per frame
	void Update () {

		vida1 = cristall.GetComponent<Cristal>().vida;

		if(etapa == 1){
			currentTime += Time.deltaTime;
			if (currentTime >= 5){
			rb.AddForce(0, 100, 0, ForceMode.Impulse);
			currentTime = 0.0f;
			}
		}

		if(contador == 4){
			etapa = 1;
         	Destroy (plataforma);
         	Destroy (plataforma2);
		}
		if(chave == true && vida1 == 2){
			etapa =2;
			chave = false;
		}
		if(vida1 == 0){
			Destroy (transform.gameObject);
		}



		if(etapa == 2){
			if(direcao == true){
				currentTime += Time.deltaTime;
				if (currentTime >= 2.5){
					rb.AddForce(-40, 100, 0, ForceMode.Impulse);
					currentTime = 0.0f;
					if(contador>=1){
						
					}
				}
			}
			if(direcao == false){
				currentTime += Time.deltaTime;
				if (currentTime >= 2.5){
					rb.AddForce(40, 100, 0, ForceMode.Impulse);
					currentTime = 0.0f;

					
				}
			}
		}
	}
	void OnTriggerEnter( Collider collider )
 	{
 
		 if( collider.tag =="Parede2" )
 			{
 				 contador += 1;
 				 direcao = true;
 				 
 				 
 			}
 		
 		 if( collider.tag =="Parede" )
 			{
 				 contador += 1;
 				 direcao = false;
 				 
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
