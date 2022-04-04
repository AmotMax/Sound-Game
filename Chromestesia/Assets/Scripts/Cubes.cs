using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubes : MonoBehaviour
{
   

    public GameObject greenDoor, purplePlatform, toDestroy, toEnable, sound, particle;

    
    // Start is called before the first frame update
    void Start()
    {
        toDestroy.SetActive(true);
        toEnable.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision other)
    {
       
      

        if (other.gameObject.tag == "GreenSphere")
        {
            greenDoor.GetComponent<GreenDoor>().go = true;
            Instantiate(sound, transform.position, transform.rotation);
            Instantiate(particle, transform.position, transform.rotation);
        }

        if (other.gameObject.tag == "PurpleSphere" )
        {
             Instantiate(sound, transform.position, transform.rotation);
            
            purplePlatform.GetComponent<Platform>().go = !purplePlatform.GetComponent<Platform>().go;

           
            Instantiate(particle, transform.position, transform.rotation);q




        }

        if (other.gameObject.tag == "CyanSphere")
        {
            toDestroy.SetActive(false);
            toEnable.SetActive(true);
            Instantiate(sound, transform.position, transform.rotation);
            Instantiate(particle, transform.position, transform.rotation);

        }
    }
}
