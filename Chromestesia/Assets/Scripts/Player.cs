using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;



public class Player : MonoBehaviour
{
    public GameObject soundHandler;
    public GameObject ré, fa, la, ré2, resetSound, instruction;
    

    public int A;
    public int B;
    public int C;
    public int D;

    public bool is1, is2, is3, is4, is5;
    public GameObject greenPP, redPP, purplePP, cyanPP;

    public int i;

    public float speed;
    public float direction = 0;
    public float crabdirection = 0;
    public Rigidbody rb;
    public float jumpForce;

    
    public bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    public GameObject soundJump, soundWalk;


   
    



    // Start is called before the first frame update
    void Start()
    {
        i = soundHandler.GetComponent<SoundHandler>().i;

        Cursor.visible = false;
        
        
         soundWalk.SetActive(false);
        

    }

    // Update is called once per frame
    void Update()
    {
        

        i = soundHandler.GetComponent<SoundHandler>().i;

        if (Input.GetKeyDown(KeyCode.J))
        {
            Instantiate(ré, transform.position, Quaternion.identity);
            EmetteurUn();
            
            
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            
            Instantiate(fa, transform.position, Quaternion.identity);
            EmetteurDeux();

        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            
            Instantiate(la, transform.position, Quaternion.identity);
            EmetteurTrois();

        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            Instantiate(ré2, transform.position, Quaternion.identity);
            EmetteurQuatre();
            

        }

        if ( Input.GetKeyDown(KeyCode.O))
        {
            soundHandler.GetComponent<SoundHandler>().i = 0;
            Instantiate(resetSound, transform.position, Quaternion.identity);
        }

        Move();
        

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = Vector3.up * jumpForce;
            Instantiate(soundJump, transform.position, transform.rotation); 
            

        }

        if(!isGrounded)
        {
            soundWalk.SetActive(false);
        }
    }

    void FixedUpdate()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, checkRadius, whatIsGround);
    }

    private void Move()
    {

        if (direction <= 0.1f)
        {
            direction = 0;
        }

        if (Input.GetKey(KeyCode.Z))
        {
            direction = 1;
           
            if (isGrounded)
            {
                soundWalk.SetActive(true);
            }

        }
        else if (Input.GetKeyUp(KeyCode.Z))
        {
            direction = 0;
            soundWalk.SetActive(false);


        }

        if (Input.GetKey(KeyCode.S))
        {
            direction = -1;
            if (isGrounded)
            {
                soundWalk.SetActive(true);
            }

        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            direction = 0;
            soundWalk.SetActive(false);

        }

        if (Input.GetKey(KeyCode.Q))
        {
            crabdirection = -1;
            Debug.Log("ga");
            if (isGrounded)
            {
                soundWalk.SetActive(true);
            }

        }
        else if (Input.GetKeyUp(KeyCode.Q))
        {
            crabdirection = 0;
            soundWalk.SetActive(false);
        }


        if (Input.GetKey(KeyCode.D))
        {
            crabdirection = 1;
            if (isGrounded)
            {
                soundWalk.SetActive(true);
            }
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            crabdirection = 0;
            soundWalk.SetActive(false);
        }

        Vector3 movement = transform.forward * speed * direction * Time.deltaTime;
        transform.position = transform.position + movement;

        Vector3 crabmovement = transform.right * speed * crabdirection * Time.deltaTime;
        transform.position = transform.position + crabmovement;
    }

    
    void OnTriggerStay(Collider other)
    {


        if (other.gameObject.tag == "1")
        {

            is1 = true;
            greenPP.SetActive(true);

        }

        if (other.gameObject.tag == "2")
        {

            is2 = true;
            redPP.SetActive(true);
        }
        if (other.gameObject.tag == "3")
        {

            is3 = true;
            purplePP.SetActive(true);
        }
        if (other.gameObject.tag == "4")
        {

            is4 = true;
            cyanPP.SetActive(true);
        }

        if (other.gameObject.tag == "5")
        {

            is5 = true;
            cyanPP.SetActive(true);
        }

        if (other.gameObject.tag == "instruction")
        {

            instruction.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {


        if (other.gameObject.tag == "1")
        {

            is1 = false;
            greenPP.SetActive(false);
        }


        if (other.gameObject.tag == "2")
        {

            is2 = false;
            redPP.SetActive(false);
        }


        if (other.gameObject.tag == "3")
        {

            is3 = false;
            purplePP.SetActive(false);
        }


        if (other.gameObject.tag == "4")
        {

            is4 = false;
            cyanPP.SetActive(false);
        }

        if (other.gameObject.tag == "5")
        {

            is5 = false;
            cyanPP.SetActive(false);
        }

        if (other.gameObject.tag == "instruction")
        {

            instruction.SetActive(false);
        }

    }







    // Script Diff Emeteur (ex Player) ===============================================================
    private void EmetteurUn()
    {
        int Sound = 1;
        soundHandler.GetComponent<SoundHandler>().Recepteur(Sound);

    }

    private void EmetteurDeux()
    {
        int Sound = 2;
        soundHandler.GetComponent<SoundHandler>().Recepteur(Sound);

    }

    private void EmetteurTrois()
    {
        int Sound = 3;
        soundHandler.GetComponent<SoundHandler>().Recepteur(Sound);

    }

    private void EmetteurQuatre()
    {
        int Sound = 4;
        soundHandler.GetComponent<SoundHandler>().Recepteur(Sound);

    }

}
