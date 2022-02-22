using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroyed : MonoBehaviour                    //This script is only for the level2. It enables to destroy the rocket when the time is ended.
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(CountDownTimer.isEndTimer == true){                //Here we test if the timer is finished or not. If the "isEndTimer" value is true , the timer is finished.
            //Destroy(gameObject);
            gameObject.SetActive(false);                        //The rocket disappears in the game.
        }
    }
}
