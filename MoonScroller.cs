using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonScroller : MonoBehaviour              //This script is used to scroll the background 
{

    float scrollSpeed = -4f;                            //We want the backgroung move on the left to have an speed impression with the rocket. We fix the speed at -4;
    Vector2 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;                  //We affect transform.position to the startPos because is the only way to get the value to locate the background.
        
    }

    // Update is called once per frame
    void Update()
    {
        float newPos = Mathf.Repeat (Time.time * scrollSpeed,60);     //This line affect the newposition of the background, 
        transform.position = startPos + Vector2.right * newPos;        //The new position of the background is : the startPos + the offset of the background position with the code line juste above.
    
    }
}
