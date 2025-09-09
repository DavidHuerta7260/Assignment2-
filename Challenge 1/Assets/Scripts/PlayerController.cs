/*
David Huerta
Challenge 1
adds player control to plane
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed = 50f;
    public float verticalInput;
 

    void FixedUpdate()
    {
        
        verticalInput = Input.GetAxis("Vertical");

        
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        
        transform.Rotate(Vector3.right * verticalInput * turnSpeed * Time.deltaTime);

        
    }
}

