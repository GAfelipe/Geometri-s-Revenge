using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour {

	public void LoadByIndex(int sceneIndex){

		PlayerPrefs.SetInt("CheckPoint", 1);
		PlayerPrefs.SetInt("current1", 0);
		PlayerPrefs.SetInt("current2", 0);
		PlayerPrefs.SetInt("current3", 0);
		PlayerPrefs.SetInt("current4", 0);
		PlayerPrefs.SetInt("current5", 0);
		PlayerPrefs.SetInt("current6", 0);
		PlayerPrefs.SetInt("current7", 0);
		PlayerPrefs.SetInt("current8", 0);
		PlayerPrefs.SetInt("current9", 0);

		SceneManager.LoadScene (sceneIndex);

	}
	public void Update(){
		if (Input.GetKeyDown(KeyCode.O)){
			PlayerPrefs.SetInt("CheckPoint", 11);
	}
	}
}
