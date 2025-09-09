/*
David Huerta
Prototype 1
Adds text for when player falls
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

namespace Prototype1
{
    public class PlayerLoseOnFall : MonoBehaviour
    {
        //public Text textbox;

        // Update is called once per frame
        void Update()
        {
            if (transform.position.y < -1)
            {
                //textbox.text = "You Lose!";
                ScoreManager.gameOver = true;
            }
        }
    }
}
