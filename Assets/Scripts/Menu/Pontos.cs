using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontos : MonoBehaviour {

	public Text fase1;
    public Text fase2;
    public Text fase3;
    public Text fase4;
    public Text fase5;
    public Text fase6;
    public Text fase7;
    public Text fase8;
    public Text fase9;
    
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		fase1.text = PlayerPrefs.GetInt("current1").ToString();
		fase2.text = PlayerPrefs.GetInt("current2").ToString();
		fase3.text = PlayerPrefs.GetInt("current3").ToString();
		fase4.text = PlayerPrefs.GetInt("current4").ToString();
		fase5.text = PlayerPrefs.GetInt("current5").ToString();
		fase6.text = PlayerPrefs.GetInt("current6").ToString();
		fase7.text = PlayerPrefs.GetInt("current7").ToString();
		fase8.text = PlayerPrefs.GetInt("current8").ToString();
		fase9.text = PlayerPrefs.GetInt("current9").ToString();
	}
}
