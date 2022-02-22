using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour               //This script is for the main menu
{
   public void PlayGame(){          

       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); //This line is for the PlayButton, if we click on the PlayButton, the level1 start.
   }

   public void HelpMenu(){
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);//This line is for the HelpButton, if we click on the Helpbutton, the explanations of each level are displayed.
   }

   public void QuitGame(){

       Application.Quit();   ////This line is for the QuitButton, if we click on the QuitButton, the game is quited.
   }
}
