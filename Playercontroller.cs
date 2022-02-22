using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public Rigidbody2D rb;
    public float movespeed = 5;                     //This the speed of the rocket
    public int score = 0;                           //Score of stars collected by the rocket

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveDirection = Input.GetAxisRaw("Vertical");   
        rb.velocity = new Vector2(0, moveDirection * movespeed); //The rocket can only move along the Y axis, just go up and go down. That's why there is a 0 on x coordonate.
    }

    void OnTriggerEnter2D(Collider2D other)     //This fonction will detect if the player has a collison, if the player hit something in the game.
    {
        if(other.gameObject.CompareTag("Obstacle"))    //Here we compare the rocket with the objects which have the Obstacle's tag. It shows if the rocket hit an obstacle.
        {
            SoundManagerScript.PlaySound("explosion");  //Here we launch the sound of explosion. It's important to note thant the sound is free and has no copyright.
            PlayerManager.isGameOver = true;            //We instantiate the gameover variable has true, it enables to show the GameOveScreen with the restart button.
            Destroy(gameObject);                        //Here the rocket is destroyed because it hit an obstacle.
        }

        if(other.gameObject.CompareTag("Star"))         //Here we compare the rocket with the stars, if the player catch stars or not
        {
            SoundManagerScript.PlaySound("collect");    //Here we launch the collect sound. It's important to note thant the sound is free and has no copyright.
            score += 1;                                 //The score of stars collected is incremented.
            Destroy(other.gameObject);                  //Here we destroy the star collected, because of star can't be collected twice.
        }

        if(score == 2){                                 //This is the end condition of the level1
            //Debug.Log("You Won !");
            Destroy(gameObject);                        //The rocket is detroyed because the level1 is finished.
            PlayerManager.isEndGame = true;             //We instantiate the end variable has true, it enables to show the EndGameScreen with the next level button.
        }

    }
}
