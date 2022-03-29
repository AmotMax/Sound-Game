using UnityEngine;

public class Levier : MonoBehaviour
{
    public float range = 100f;

    public Camera cam;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
            {
                ActionLevier target = hit.transform.GetComponent<ActionLevier>();

                if (target != null)
                {
                    target.Spawner();
                }
            }

        }
    }
}
