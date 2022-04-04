using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundHandler : MonoBehaviour
{
    public int newA;
    public int newB;
    public int newC;
    public int newD;

    public int i;

   


    public GameObject player, prefab, greenDoor, redPlatform, redPlatform2, purplePlatform, purplePlatform2, toDestroy, toEnable, toDestroy2, toEnable2;
    public GameObject greenParticle, redParticle, purpleParticle, cyanParticle;


    // Start is called before the first frame update
    void Start()
    {
        newA = player.GetComponent<Player>().A;
        newB = player.GetComponent<Player>().B;
        newC = player.GetComponent<Player>().C;
        newD = player.GetComponent<Player>().D;

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    public void Recepteur(int SoundIndex)
    {
       
         

        if (i <= 3)
        {

            if (i == 0)
            {
                i++;
                newA = SoundIndex;
            }
            else
            {

                if (i == 1)
                {
                    i++;
                    newB = SoundIndex;
                }
                else
                {

                    if (i == 2)
                    {
                        i++;
                        newC = SoundIndex;
                        
                    }
                    else
                    {

                        if (i == 3)
                        {
                            i++;
                            newD = SoundIndex;
                            TryCode(newA, newB, newC, newD);
                        }
                    }
                }
            }

        }
        else
        {
            i = 0;
            i++;                              
            newA = SoundIndex;
        }
    }

    public void TryCode(int a, int b, int c, int d)
    {
        if (a == 1 && b == 1 && c == 1 && d ==1  && player.GetComponent<Player>().is1)
        {
          
            greenDoor.GetComponent<GreenDoor>().go = true;
            Instantiate(greenParticle, greenDoor.transform.position, Quaternion.identity);
            

        }


        if (a == 1 && b == 2 && c == 3 && d == 4 && player.GetComponent<Player>().is2 && redPlatform.activeSelf == true)
        {

            redPlatform.GetComponent<Platform>().go = !redPlatform.GetComponent<Platform>().go;
            redPlatform2.GetComponent<Platform>().go = !redPlatform2.GetComponent<Platform>().go;

            Instantiate(redParticle, redPlatform.transform.position, Quaternion.identity);
            Instantiate(redParticle, redPlatform2.transform.position, Quaternion.identity);


        }

        if (a == 3 && b == 2 && c == 4 && d == 1 && player.GetComponent<Player>().is3)
        {

            purplePlatform.GetComponent<Platform>().go = !purplePlatform.GetComponent<Platform>().go;
            purplePlatform2.GetComponent<Platform>().go = !purplePlatform.GetComponent<Platform>().go;

            Instantiate(purpleParticle, purplePlatform.transform.position, Quaternion.identity);
            Instantiate(purpleParticle, purplePlatform2.transform.position, Quaternion.identity);


        }

        if (a == 1 && b == 1 && c == 4 && d == 3 && player.GetComponent<Player>().is4)
        {

            toDestroy.SetActive(false);
            toEnable.SetActive(true);

            Instantiate(cyanParticle, toEnable.transform.position, cyanParticle.transform.rotation);


        }

        if (a == 1 && b == 1 && c == 4 && d == 3 && player.GetComponent<Player>().is5)
        {

            toDestroy2.SetActive(false);
            toEnable2.SetActive(true);

            Instantiate(cyanParticle, toEnable2.transform.position, cyanParticle.transform.rotation);


        }


    }
}
