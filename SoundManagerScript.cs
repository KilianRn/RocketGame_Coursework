using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip explosionSound, collectSound, shootSound;   //Declaration of variables
    public static AudioSource audiosrc;

    // Start is called before the first frame update
    void Start()                                                     //Here all the sounds are loaded.
    {
        explosionSound = Resources.Load<AudioClip>("explosion");
        collectSound = Resources.Load<AudioClip>("collect");
        shootSound = Resources.Load<AudioClip>("shoot");
        audiosrc = GetComponent<AudioSource>();                      //We create an AudioSource instance to play each sound afterward.
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip){                    //This is the fonction to play each sound depending the situation in the game.

        switch (clip){
            case "explosion":                                      //if the case is explosion --> play explosion sound.
                audiosrc.PlayOneShot(explosionSound);
                break;
            case "collect":                                         //if the case is collect --> play collect sound.
                audiosrc.PlayOneShot(collectSound);
                break;
            case "shoot":                                           //if the case is shoot --> play shoot sound.
                audiosrc.PlayOneShot(shootSound);
                break;
        }
    }
}
