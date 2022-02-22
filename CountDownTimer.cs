using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour        //This script create a countdowntimer and stop it when 20 seconds have passed.
{
    float currentTime = 0f;                         //Here we are the variable to know the current time after each step.
    float startingTime = 20f;                       //Here we instante the duration of the timer, we want just 20 seconds.
    public static bool isEndTimer;                  //Varible to know if the timer is ended or not.
    public Rigidbody2D rb;
    public Rigidbody2D rb2;

    [SerializeField] Text countdowntext;

    public void Awake()
    {
        isEndTimer = false;                         //The condition of end is instanciated at false.
    }

    void Start()
    {
        currentTime = startingTime;                 //We associate the current time at the starting time because at the beginning of the level2, the timer start a 20 seconds.
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;          //The countdowntimer is launched, it decremented by 1 second at each update.
        //print(currentTime);
        countdowntext.text = currentTime.ToString("0"); //Here this line is important to just have the seconds at the screen and not the milliseconds.

        if(currentTime <= 0){                           //This conditions enables at the timer to not have negatives values.

            isEndTimer = true;                          //If the timer is equal to 0, the level is finished and we instanciate the value isEndTimer at true.
            //Debug.Log("You Won !");
            currentTime = 0;                            //We affect 0 to the currenttime
            rb.constraints = RigidbodyConstraints2D.FreezePosition; //This line enables to freeze the rocket , it is not necessary because the rocket is destroyed.
            rb2.constraints = RigidbodyConstraints2D.FreezePosition; //This line enables to freeze the bullets, no more bullets are launched because the game is ended.
            PlayerManager.isEndGame = true;             //Here we show the endgame Menu with the button to return at the main menu.
        }
    }
}
