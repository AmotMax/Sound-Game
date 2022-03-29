using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionLevier : MonoBehaviour
{
    public GameObject sphere, spawn;
    public Animation anim;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void  Spawner()
    {
        Instantiate(sphere, spawn.transform.position, Quaternion.identity);
        anim.Play();
    }
}
