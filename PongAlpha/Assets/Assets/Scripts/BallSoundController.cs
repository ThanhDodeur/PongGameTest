using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSoundController : MonoBehaviour {

    public AudioSource wallSound;
    public AudioSource raquetteSound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "P1Raquette" || collision.gameObject.name == "P2Raquette")
        {
            this.raquetteSound.Play();
        }
        else
        {
            this.wallSound.Play();
        }
            
    }
}
