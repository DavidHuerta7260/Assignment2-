/*
David Huerta
Challenge 1
adds movement to the plane propeller
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    public float speed = 1000f;

    void Update()
    {
        // spin the propeller around z-axis
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}
