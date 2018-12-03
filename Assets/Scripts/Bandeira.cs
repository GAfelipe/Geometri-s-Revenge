using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Bandeira : MonoBehaviour {


	public int cenaNumero;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		void OnCollisionEnter (Collision col)
    {
        if(col.gameObject.name == "Nêmesis-animada")
        {
        	if(cenaNumero > PlayerPrefs.GetInt("CheckPoint")){
        		 PlayerPrefs.SetInt("CheckPoint", cenaNumero);
       	   }
           SceneManager.LoadScene (cenaNumero);
           
        }
    }

	
}
