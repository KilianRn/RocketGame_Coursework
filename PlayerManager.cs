using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;    //declaration of the variable to know if the game is over or not.
    public static bool isEndGame;     //declaration of the variable to know if the game is finished or not.
    public GameObject gameOverScreen; //declaration of the gameoverscreen, displayed when the rocket hit an obstacle or when a bullet hit the rocket
    public GameObject gameEndScreen;   //declaration of the gameendscreen, displayed when the player finished the level1 and the level2.

    private void Awake()
    {
        isGameOver = false;         //instanciate the gameover value as false when the game start.
        isEndGame = false;          //instanciate the endgame value as false when the game start.
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver)
        {
            gameOverScreen.SetActive(true);   //if the game is over (let's see in the Playercontroller script), the gameoverscreen is active with the restart button.
        }

        if(isEndGame)
        {
            gameEndScreen.SetActive(true);      //if the game is over (let's see in the Playercontroller and CountDownTimer scripts), the gameendscreen is active with the next level and main menu buttons.
        }
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  //Here we reload the game at the actual position when the rocket hit something. 
    }

    public void ReplayMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  //Here we reload the main menu screen.
    }

    public void ReplayMenu1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); //Here we reload the main menu screen but on another scene, due to the build settings and the index attached. The order are not the same to switch between scenes.
    }


    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2); //Here we load the Level2 when the level1 is finished.
    }
}
