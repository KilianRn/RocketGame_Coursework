using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	float moveSpeed = 7f;    //this is the speed of the bullet which is launched.

	Rigidbody2D fireball;

	Playercontroller target;  //the target is the rocket 
	Vector2 moveDirection;		//The move direction is used to follow the rocket when the bullet is launched.

	// Use this for initialization
	void Start () {
		fireball = GetComponent<Rigidbody2D> ();
		if(CountDownTimer.isEndTimer == false)SoundManagerScript.PlaySound("shoot");   //The sound is played when a bullet is launched.
		target = GameObject.FindObjectOfType<Playercontroller>();						//We affect the rocket like target.
		moveDirection = (target.transform.position - transform.position).normalized * moveSpeed; //This is the change of direction, we take the rocket's position and we adapt the new position of the next bullet with the same speed.
		fireball.velocity = new Vector2 (moveDirection.x, moveDirection.y);        //It represents the rate of change of Rigidbody position (x and y axis).
		//Destroy (gameObject, 3f);
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.name.Equals ("Player")) {  //we test if the player has a collision with a bullet.
			//Debug.Log ("Hit!");
			Destroy (this.gameObject);      //If the bullet hit the rocket, the rocket is automatically destroyed.
		}
	}

}
