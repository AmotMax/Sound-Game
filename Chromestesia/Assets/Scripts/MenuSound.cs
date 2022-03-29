using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSound : MonoBehaviour
{
    public GameObject[] sounds, waves;
    public int randomSound;

    public GameObject spawner;

    public float initialTime = 2;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = initialTime;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;


        if (timer <= 0)
        {
           randomSound = Random.Range(0, sounds.Length);
           Instantiate(sounds[randomSound], transform.position, Quaternion.identity);
           Instantiate(waves[randomSound], spawner.transform.position, Quaternion.identity);

            timer = initialTime;
        }

       
    }
}
