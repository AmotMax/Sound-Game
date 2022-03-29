using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenDoor : MonoBehaviour
{
    public bool go;
    public Transform target;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(go)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed* Time.deltaTime);
        }
    }
}
