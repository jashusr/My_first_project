using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class mathfMoveto : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        
    }

    private void Move(Vector2 input)
    {
        transform.Translate(new Vector3(input.x, input.y) * 10.0f * Time.deltaTime);
    }

    public void MoveInput(InputAction.CallbackContext context)
    {
        Vector2 moveInput = context.ReadValue<Vector2>();
        Move(moveInput);

    }
}
