using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaQ : MonoBehaviour {

	Animator anim;
	private int x;
	public Rigidbody Rigidbody;

	public AudioClip brokenSound;
    private AudioSource source;

    void Awake ()
   	{
       source = GetComponent<AudioSource>();
       
    }

	// Use this for initialization
	void Start () {

		anim = gameObject.GetComponent<Animator>();
		x=0;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(x == 1){
			anim.SetBool("touch", true);

		}

		if(x==2){
			Rigidbody.useGravity = true;
		}


	}
	void OnCollisionEnter (Collision col)
    {
        if(col.gameObject.name == "Nêmesis-animada")
        {
          x+=1; 
          source.PlayOneShot(brokenSound,1F);
        }
    }
}
