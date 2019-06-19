using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(AudioSource))]
public class CollectableCake : MonoBehaviour
{

    public AudioClip collectableSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            //Increase number of cakes player has eaten
            GetComponent<AudioSource>().PlayOneShot(collectableSound);
            GetComponent<Renderer>().enabled = false;

            //Destroy the game object after the sound has completed
            Destroy(gameObject, collectableSound.length);

            //Destroy this instance of the script to prevent it being called again.
            Destroy(this);
        }
    }
}
