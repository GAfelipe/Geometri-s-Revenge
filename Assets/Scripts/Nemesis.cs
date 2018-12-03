using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


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

    

    public int pontosGR;

    public static int pontos1;
    public static int pontos2;
    public static int pontos3;
    public static int pontos4;
    public static int pontos5;
    public static int pontos6;
    public static int pontos7;
    public static int pontos8;
    public static int pontos9;
    public static int pontos10;

    public Text Pontos;

    public int NumeroCena;


    public AudioClip jumpSound;
    private AudioSource source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;

    private GameObject tempPrefab;


    
   
    void Awake () {

		source = GetComponent<AudioSource>();
	}
	// Use this for initialization
	void Start () {
		IsGrounded = true;
		currentTime = 1.5f;
		direita = true;
		pontosGR = 0;

	
	}
	
	// Update is called once per frame
	void Update () {

		
		

		currentTime += Time.deltaTime;
		Pontos.text = pontosGR.ToString();
		

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
		

		//-------------------------------------------------------------------------------------

		if (collider.tag =="Bandeira") {
			

		}
	}
	void OnCollisionEnter (Collision col)
    {
        if(col.gameObject.name == "Coin")
        {
        	pontosGR+=1;
        	if(NumeroCena == 1){
				pontos1 += 1;
			}
			

			if(NumeroCena == 2){
				pontos2 += 1;
			}

			if(NumeroCena == 3){
				pontos3 += 1;
			}

			if(NumeroCena == 4){
				pontos4 += 1;
			}

			if(NumeroCena == 5){
				pontos5 += 1;
			}

			if(NumeroCena == 6){
				pontos6 += 1;
			}

			if(NumeroCena == 7){
				pontos7 += 1;
			}

			if(NumeroCena == 8){
				pontos8 += 1;
			}

			if(NumeroCena == 9){
				pontos9 += 1;
			}
			if(NumeroCena == 10){
				pontos9 += 1;
			}
        }
        if(col.gameObject.name == "bandeira"){
        	if(NumeroCena == 1){
				if(PlayerPrefs.GetInt("current1")<pontos1){
					PlayerPrefs.SetInt("current1", pontos1);
				}
			}

			if(NumeroCena == 2){
				if(PlayerPrefs.GetInt("current2")<pontos2){
					PlayerPrefs.SetInt("current2", pontos2);
				}
			}

			if(NumeroCena == 3){
				if(PlayerPrefs.GetInt("current3")<pontos3){
					PlayerPrefs.SetInt("current3", pontos3);
				}
			}

			if(NumeroCena == 4){
				if(PlayerPrefs.GetInt("current4")<pontos4){
					PlayerPrefs.SetInt("current4", pontos4);
				}
			}

			if(NumeroCena == 5){
				if(PlayerPrefs.GetInt("current5")<pontos5){
					PlayerPrefs.SetInt("current5", pontos5);
				}
			}

			if(NumeroCena == 6){
				if(PlayerPrefs.GetInt("current6")<pontos6){
					PlayerPrefs.SetInt("current6", pontos6);
				}
			}

			if(NumeroCena == 7){
				if(PlayerPrefs.GetInt("current7")<pontos7){
					PlayerPrefs.SetInt("current7", pontos7);
				}
			}

			if(NumeroCena == 8){
				if(PlayerPrefs.GetInt("current8")<pontos8){
					PlayerPrefs.SetInt("current8", pontos8);
				}
			}

			if(NumeroCena == 9){
				if(PlayerPrefs.GetInt("current9")<pontos9){
					PlayerPrefs.SetInt("current9", pontos9);
				}
			}
			if(NumeroCena == 10){
				if(PlayerPrefs.GetInt("current10")<pontos10){
					PlayerPrefs.SetInt("current10", pontos10);
				}
			}
        }

    }

	

   
}
