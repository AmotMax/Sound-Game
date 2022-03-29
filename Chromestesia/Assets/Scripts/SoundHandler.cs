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

   


    public GameObject player, prefab, greenDoor, redPlatform,purplePlatform, toDestroy, toEnable;

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
        }
        

        if (a == 1 && b == 2 && c == 3 && d == 4 && player.GetComponent<Player>().is2)
        {

            redPlatform.GetComponent<Platform>().go = !redPlatform.GetComponent<Platform>().go;
            
        }

        if (a == 3 && b == 2 && c == 4 && d == 1 && player.GetComponent<Player>().is3)
        {

            purplePlatform.GetComponent<Platform>().go = !purplePlatform.GetComponent<Platform>().go;

        }

        if (a == 1 && b == 1 && c == 4 && d == 3 && player.GetComponent<Player>().is4)
        {

            toDestroy.SetActive(false);
            toEnable.SetActive(true);

        }
    }
}
