using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portel : MonoBehaviour
{
    private GameObject collide;
    public GameObject portelTo;

    private float portelx;
    private float portely;
    private float portelz;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            collide = col.gameObject;

            portelx = portelTo.transform.position.x;
            portely = portelTo.transform.position.y;
            portelz = portelTo.transform.position.z;

            collide.transform.position = new Vector3(portelx, portely, portelz);

        }
    }
}
