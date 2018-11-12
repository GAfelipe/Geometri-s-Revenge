using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	public GameObject balaPrefab;
	public Transform nem;

	public float currentTime;
	public GameObject nem2;
	public bool direct;

	public AudioClip shotSound;
    private AudioSource source;
	

	void Awake ()
   	{
       source = GetComponent<AudioSource>();
       
    }


	// Use this for initialization
	void Start () {
	currentTime = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
		currentTime += Time.deltaTime;
		direct = nem2.GetComponent<Nemesis>().direita;

		if (Input.GetAxis("Fire1") > 0 & currentTime > 1){

			GameObject tempPrefab = Instantiate (balaPrefab) as GameObject;

			tempPrefab.transform.position = new Vector3 (transform.position.x,transform.position.y, transform.position.z);

			if(direct == true){
			tempPrefab.GetComponent<Rigidbody>().AddForce(20, 0, 0,ForceMode.Impulse);
			source.PlayOneShot(shotSound,1F);
			}
			if(direct == false){
			tempPrefab.GetComponent<Rigidbody>().AddForce(-20, 0, 0,ForceMode.Impulse);
			source.PlayOneShot(shotSound,1F);
			}
			currentTime = 0;
		}
	}
}

