using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject soundHandler;
    public GameObject ré, fa, la, ré2;

    public int A;
    public int B;
    public int C;
    public int D;

    public bool is1, is2, is3, is4, is5;

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

    // Start is called before the first frame update
    void Start()
    {
        i = soundHandler.GetComponent<SoundHandler>().i;

        Cursor.visible = false;


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
           
        }

        Move();

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = Vector3.up * jumpForce;

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

        }
        else if (Input.GetKeyUp(KeyCode.Z))
        {
            direction = 0;


        }

        if (Input.GetKey(KeyCode.S))
        {
            direction = -1;

        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            direction = 0;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            crabdirection = -1;
            Debug.Log("ga");

        }
        else if (Input.GetKeyUp(KeyCode.Q))
        {
            crabdirection = 0;
        }


        if (Input.GetKey(KeyCode.D))
        {
            crabdirection = 1;
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            crabdirection = 0;
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

        }

        if (other.gameObject.tag == "2")
        {

            is2 = true;

        }
        if (other.gameObject.tag == "3")
        {

            is3 = true;

        }
        if (other.gameObject.tag == "4")
        {

            is4 = true;

        }

        if (other.gameObject.tag == "5")
        {

            is5 = true;

        }
    }

    void OnTriggerExit(Collider other)
    {


        if (other.gameObject.tag == "1")
        {

            is1 = false;

        }


        if (other.gameObject.tag == "2")
        {

            is2 = false;

        }


        if (other.gameObject.tag == "3")
        {

            is3 = false;

        }


        if (other.gameObject.tag == "4")
        {

            is4 = false;

        }

        if (other.gameObject.tag == "5")
        {

            is5 = false;

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
