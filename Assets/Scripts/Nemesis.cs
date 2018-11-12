using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nemesis : MonoBehaviour {

    public Rigidbody rb;
    public float Speed;
    public float Pulo;
    public Transform NemeT;
    public Animator NemeA;
    public float currentTime;
	public Collider gatilho;
    private bool IsGrounded;
    public bool direita;

    public AudioClip jumpSound;
    private AudioSource source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;


    
   
    void Awake () {

		source = GetComponent<AudioSource>();
	}
	// Use this for initialization
	void Start () {
		IsGrounded = true;
		currentTime = 1.5f;
		direita = true;
	}
	
	// Update is called once per frame
	void Update () {

		currentTime += Time.deltaTime;

		if(transform.position.y <= 0){
			Application.LoadLevel("Morte");
		}

        if (Input.GetButton("Jump") && IsGrounded == true && currentTime >= 1.0f)
        {
            source.PlayOneShot(jumpSound,0.5F);
            NemeA.SetTrigger("jump");
            rb.AddForce(0, Pulo, 0, ForceMode.Impulse);
            IsGrounded = false;
            currentTime = 0;
            
        } 

        if (Input.GetAxis("Horizontal")> 0)
        {
            transform.Translate(0, 0, Speed * Time.deltaTime);
            transform.eulerAngles = new Vector3(0, 90, 0);
            NemeA.SetBool ("Andar", true);
            direita = true;

         

            
            }
        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.Translate(0, 0, Speed * Time.deltaTime);
            transform.eulerAngles = new Vector3(0, 270, 0);
            NemeA.SetBool("Andar", true);
            direita = false;


            
        }
        if (Input.GetAxis("Horizontal") == 0)
        {
            
            NemeA.SetBool("Andar", false);

        }



      
	}
	void OnTriggerEnter(Collider collider){
		if (collider.tag =="Ground") {
			IsGrounded = true;

		}
		if (collider.tag =="estalactite") {
			Application.LoadLevel("Morte");

		}
	}
	

   
}
