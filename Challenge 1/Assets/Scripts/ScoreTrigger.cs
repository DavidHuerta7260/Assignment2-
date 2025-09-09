/*
David Huerta
Challenge 1
Triggers score point after planes goes through trigger zone
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    public int points = 1;
    bool used = false;

    void OnTriggerEnter(Collider other)
    {
        if (used) return;

       
        if (other.CompareTag("Player"))
        {
            ScoreManager gm = FindObjectOfType<ScoreManager>();
            if (gm != null) gm.AddScore(points);

            used = true;                 
            gameObject.SetActive(false); 
        }
    }
}

