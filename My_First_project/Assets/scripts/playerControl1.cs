using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class playerControl1 : MonoBehaviour
{
    [SerializeField, Range(1, 100)] private float _moveSpeed;
    [SerializeField] private Vector3 _move;
    [SerializeField] private Vector2 _moveInput;
    private Rigidbody _rb;

    private void Awake()
    {
        //get rb reference
        _rb = GetComponent<Rigidbody>();
    }

    void LateUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastVisualise(float.MaxValue);
        }

        //RaycastVisualise(float.MaxValue);
    }

    private void FixedUpdate()
    {
        MovePlayer(GetPlayerInput());
    }

    private Vector3 GetPlayerInput()
    {
        _moveInput.x = Input.GetAxisRaw("Horizontal");
        _moveInput.y = Input.GetAxisRaw("Vertical");

        Vector3 move = new Vector3(_moveInput.x, 0, _moveInput.y);
        return move;
    }

    private void MovePlayer(Vector3 move)
    {
        if (_moveInput != Vector2.zero)
        {
            _rb.AddForce(_moveSpeed * Time.fixedDeltaTime * move, ForceMode.Impulse);
        }

        return;
    }

    private float RaycastVisualise(float maxDistance)
    {
        //find screen center
        Vector2 center = new Vector2(Screen.width * 0.5f, Screen.height * 0.5f);
        //use view for ray
        Vector2 relativeCenter = new Vector2(0.5f, 0.5f);

        Ray rayCaster = new Ray(center, transform.forward);

        rayCaster = Camera.main.ScreenPointToRay(relativeCenter);

        //shoot reaycast on button press, Infinite distance
        
        RaycastHit hit = new();
        Vector3 postion = Vector3.zero;

        if (Physics.Raycast(rayCaster, out hit))
        {
            Debug.DrawRay(center,hit.point);
        }
        else
        {
            //get false postion at a distance
            rayCaster.GetPoint(maxDistance);
        }
        //check the distance between own postion and hit postion
        float distance = Vector3.Distance(transform.position, postion);
        Debug.Log("Distence is = "+distance);

        return distance;


    }

}