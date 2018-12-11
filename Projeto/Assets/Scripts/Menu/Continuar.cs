using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Continuar : MonoBehaviour {

	public GameObject menu;

	public void Start(){
		menu.SetActive(false);
	}

	// Use this for initialization
	public void Acao()
    {
        //Output this to console when Button1 or Button3 is clicked
      // SceneManager.LoadScene (PlayerPrefs.GetInt("CheckPoint"));

       menu.SetActive(true);
    }

}
