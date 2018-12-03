using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {
	public GameObject menu;
	public static bool GameIsPaused = false;

	// Use this for initialization
	void Start () {

		menu.SetActive(false);
		
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)){
			if(GameIsPaused)
			{
				Resume();

			}
			else
			{
				Paused();
			}

		}
	}
	public void Resume(){
		menu.SetActive(false);
		Time.timeScale = 1f;
		GameIsPaused = false;
		

	}
	void Paused(){
		menu.SetActive(true);
		Time.timeScale = 0f;
		GameIsPaused = true;
	}
	public void LoadByIndex(int sceneIndex){
		Time.timeScale = 1f;
		GameIsPaused = false;
		menu.SetActive(false);
		SceneManager.LoadScene (sceneIndex);
	}
	public void Menu(){
		Time.timeScale = 1f;
		GameIsPaused = false;
		menu.SetActive(false);
		SceneManager.LoadScene (0);
	}
}
