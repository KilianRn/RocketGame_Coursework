using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spacecraft : MonoBehaviour {

	[SerializeField]
	GameObject bullet;   //We create a GameObject named : bullet

	float fireRate;	     //this variable is the time between two bullets. 
	float nextFire;		//this variable control the new bullet shooted after the last one.

	// Use this for initialization
	void Start () {
		fireRate = 1f;			//We instanciate the variable at 1 to have some challenge, if the fireRate is too high, the game is very simple.
		nextFire = Time.time;	//This line enables to catch the time for the next fire and to use it after to launch another one with the offset.
	}
	
	// Update is called once per frame
	void Update () {
		LaunchBullet ();		//We call the fonction to launch a new bullet
	}

	void LaunchBullet()
	{
		if (Time.time > nextFire) {           //In this fonction we test if is the the moment to launch another bullet or not.
			Instantiate (bullet, transform.position, Quaternion.identity);  //Here we instanciate the new bullet to launch
			nextFire = Time.time + fireRate;		//We update the nextfire variable, we add the fireRate offset.
		}
		
	}

}
