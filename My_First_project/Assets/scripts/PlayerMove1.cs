using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private float horizontalSpeed = 2.0f;
    [SerializeField]
    private float playerspeed = 5f;
    [SerializeField]
    private float playershiftpeed = 5f;
    [SerializeField]
    private float jumphight = 8f;
    [SerializeField]
    private float gravity = 0f;

    private Rigidbody rb;
    private bool isJumping;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        isJumping = false;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }

    private void Update()
    {
        float h = horizontalSpeed * Input.GetAxis("Mouse X");

        transform.Rotate(0 , h , 0);

        transform.Translate(Vector3.down * gravity *  Time.deltaTime);

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * playerspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * playerspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D)) 
        {
            transform.Translate(Vector3.right * playerspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * playerspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            playerspeed = 10f;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            playerspeed = playershiftpeed;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isJumping == false)
        {
            rb.AddForce(Vector2.up * jumphight, ForceMode.Impulse);
            isJumping = true;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        isJumping = false;
    }

}
