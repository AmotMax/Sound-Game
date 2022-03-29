using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Partition : MonoBehaviour
{
    // Start is called before the first frame update

    public Slider partition;
    public GameObject soundHandler;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        partition.value = soundHandler.GetComponent<SoundHandler>().i;
    }
}
