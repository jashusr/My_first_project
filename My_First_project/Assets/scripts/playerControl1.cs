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
        _rb = GetComponent<Rigidbody>();
    }

    void LateUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastVisualise(float.MaxValue);
        }

    }

    private void Update()
    {
        
    }

    private float RaycastVisualise(float maxDistance)
    {
        Vector2 center = new Vector2(Screen.width * 0.5f, Screen.height * 0.5f);

        Vector2 relativeCenter = new Vector2(0.5f, 0.5f);

        Ray rayCaster = new Ray(center, transform.forward);

        rayCaster = Camera.main.ScreenPointToRay(relativeCenter);

        
        RaycastHit hit = new();
        Vector3 postion = Vector3.zero;

        if (Physics.Raycast(rayCaster, out hit))
        {
            Debug.DrawRay(center,hit.point);
        }
        else
        {
            rayCaster.GetPoint(maxDistance);
        }
        float distance = Vector3.Distance(transform.position, postion);
        Debug.Log("Distence is = "+distance);

        return distance;

    }

}