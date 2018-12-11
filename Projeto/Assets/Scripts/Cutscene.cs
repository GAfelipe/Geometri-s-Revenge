using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene : MonoBehaviour {

	// Use this for initialization
	void Start () {}
		
	public float timeLeft = 10.0f;
     
     void Update()
     {
         timeLeft -= Time.deltaTime;
         if(timeLeft < 0)
         {
             Application.LoadLevel("SampleScene");
         }
     }
 }