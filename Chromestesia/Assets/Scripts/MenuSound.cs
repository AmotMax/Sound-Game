using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSound : MonoBehaviour
{
    public GameObject[] sounds, backsound,  waves;
    public int randomSound, randomColor;

    public GameObject spawner;

    public float initialTime = 2;
    public float timer, timer1, delay;

    // Start is called before the first frame update
    void Start()
    {
        timer = 1;
        timer1 = 1 + delay;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timer1 -= Time.deltaTime;



        if (timer <= 0)
        {
           randomSound = Random.Range(0, sounds.Length);
           randomColor = Random.Range(0, sounds.Length);

            Instantiate(sounds[randomSound], transform.position, Quaternion.identity);
           



            Instantiate(waves[randomColor], new Vector3 (Random.Range(-5, 5), Random.Range(-5, 5), 0), Quaternion.identity);

            timer = initialTime;
        }

        if (timer1 <= 0)
        {
             Instantiate(backsound[randomSound], transform.position, Quaternion.identity);

            timer1 = initialTime;
        }
    }
}
