/*
David Huerta
Challenge 1
Allows camera to follow plane
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(30f, 0f, 10f);

    void LateUpdate()
    {
        // camera follows the player with a simple offset
        transform.position = player.transform.position + offset;
    }
}
