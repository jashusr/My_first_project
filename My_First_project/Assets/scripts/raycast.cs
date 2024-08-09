using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{
    [SerializeField] private List<Transform> firePoint;
    [SerializeField] private float maxDistence;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastFromGun();
    }

    private void RaycastFromGun()
    {
        Ray headRay = new Ray(firePoint[0].position, firePoint[0].forward);

        if (Physics.Raycast(headRay, out RaycastHit hit, maxDistence))
        {
            Debug.Log("Distance = "+ hit.distance);
            Debug.DrawLine(firePoint[0].position, hit.point,Color.blue);
        }

        Ray cameraRay = Camera.main.ViewportPointToRay(new Vector2(0.5f, 0.5f));

        if (Physics.Raycast(cameraRay, out RaycastHit cameraHit, maxDistence))
        {
            Debug.DrawLine(Camera.main.transform.position, cameraHit.point, Color.red);
        }

        Ray gunRay = new Ray(firePoint[1].position,hit.point - firePoint[1].position);

        if (Physics.Raycast(gunRay, out RaycastHit gunHit, maxDistence))
        {
            Debug.DrawLine(firePoint[1].position, gunHit.point, Color.magenta);
        }

    }

}
