using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nemesis : MonoBehaviour {

    public Rigidbody rb;
    public float Speed;
    public float Pulo;
    public Transform NemeT;
    public Animator NemeA;
    private bool jumped;
    public bool isGrounded;
    public Transform GroundCheck;
    public LayerMask whatIsGround;



    
   



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(transform.position.y <= 0){
			Application.LoadLevel("Morte");
		}

        if (Input.GetButton("Jump"))
        {
            NemeA.SetTrigger("jump");
            transform.Translate(0, Pulo * Time.deltaTime, 0);
            
        } 

        if (Input.GetAxis("Horizontal")> 0)
        {
            transform.Translate(0, 0, Speed * Time.deltaTime);
            transform.eulerAngles = new Vector3(0, 90, 0);
            NemeA.SetBool ("Andar", true);

         

            
            }
        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.Translate(0, 0, Speed * Time.deltaTime);
            transform.eulerAngles = new Vector3(0, 270, 0);
            NemeA.SetBool("Andar", true);


            
        }
        if (Input.GetAxis("Horizontal") == 0)
        {
            
            NemeA.SetBool("Andar", false);

        }

      
	}

   
}
