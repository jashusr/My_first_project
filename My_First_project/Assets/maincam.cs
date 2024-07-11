using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class maincam : MonoBehaviour
{
    [SerializeField]
    private Camera main_Camera;
    [SerializeField]
    private Transform target;
    [SerializeField]
    private float camposx;
    [SerializeField]
    private float camposy = 2;
    [SerializeField]
    private float camposz = 4;

    private void Update()
    {
        main_Camera.transform.LookAt(target);

        Vector3 targetPos = target.position;

        float horizontalInput = targetPos.x - camposx;
        float verticalInput = targetPos.y + camposy;
        float depthInput = targetPos.z - camposz;

        transform.position = new Vector3(horizontalInput, verticalInput, depthInput);


    }
}
