using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public float timer=2;
    public int number;

    

    public bool go, isLastLevel;

    public GameObject player, winSound;

    void Start()
    {
        go = false;
    }
    void Update()
    {
        if (isLastLevel)
        {
            Cursor.visible = true;
        }

        if (go) 
        {
            timer -= Time.deltaTime;
        }
       

        if(timer <= 0)
        {
            SceneManager.LoadScene(number);

        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            go = true;
            Instantiate(winSound, transform.position, transform.rotation);
        }
        
    }
}
