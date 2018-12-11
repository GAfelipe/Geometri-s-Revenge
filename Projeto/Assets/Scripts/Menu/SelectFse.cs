using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectFse : MonoBehaviour {
		public Text fase1;
		public int cenaNumero;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(cenaNumero>PlayerPrefs.GetInt("CheckPoint")){

		fase1.color= Color.red;	
		}
		else{
			fase1.color= Color.white;
		}

		

	}
	public void LoadByIndex(int sceneIndex){
		if(sceneIndex>PlayerPrefs.GetInt("CheckPoint")){
			
		}
		else{
			SceneManager.LoadScene (sceneIndex);
		}
}
}
