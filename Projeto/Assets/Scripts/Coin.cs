using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

	public AudioClip coinSound;
    private AudioSource source;
	

	void Awake ()
   	{
       source = GetComponent<AudioSource>();
       
    }


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
        	source.PlayOneShot(coinSound,1F);
            Destroy (transform.gameObject);
        }
    }
}
