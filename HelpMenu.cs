using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpMenu : MonoBehaviour           //This is the menu to show to goal of each level
{
    public void BackMenu(){

       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);        //This line is for the back button, if we click on the back button, we will be redirected to the main menu.
   }
}
