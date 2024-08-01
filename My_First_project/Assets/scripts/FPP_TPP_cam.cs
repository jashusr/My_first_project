using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPP_TPP_cam : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    private Camera main_cam;

    private float playerx;
    private float playery;
    private float playerz;

    private float playerrotationx;
    private float playerrotationy;
    private float playerrotationz;
    private float playerrotationw;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        playerx = target.position.x;
        playery = target.position.y+1;
        playerz = target.position.z+0.5f;

        playerrotationx = target.rotation.x;
        playerrotationy = target.rotation.y;
        playerrotationz = target.rotation.z;
        playerrotationw = target.rotation.w;


        transform.position = new Vector3(playerx, playery, playerz);
        transform.rotation = new Quaternion(playerrotationx,playerrotationy,playerrotationz, playerrotationw);

    }


}
