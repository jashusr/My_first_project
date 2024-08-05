using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Device;

public class FPP_TPP_cam : MonoBehaviour
{
    [SerializeField]
    Transform mainCam, playerBody;

    float Rotationx = 0f;

    public float senstivity = 100;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            Cursor.lockState ^= CursorLockMode.Confined;
        }
    }

    void FixedUpdate()
    {
        float MouseX = Input.GetAxis("Mouse X") * senstivity * Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y") * senstivity * Time.deltaTime;

        playerBody.Rotate(Vector3.up * MouseX);

        Rotationx -= MouseY;
        Rotationx = Mathf.Clamp(Rotationx, -90f, 90f);

        mainCam.localRotation = Quaternion.Euler(Rotationx, 0f, 0f);
    }



}
