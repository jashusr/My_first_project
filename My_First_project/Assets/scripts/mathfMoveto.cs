using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mathfMoveto : MonoBehaviour
{
    float value;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (true) 
        {
            value = Mathf.MoveTowards(value, 0, Time.deltaTime);
        }
        else
        {
            value = Mathf.MoveTowards(value, 1, Time.deltaTime);
        }
    }
    private void FixedUpdate()
    {
        
    }
}
