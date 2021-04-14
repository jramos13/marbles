using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameToken : MonoBehaviour
{

    public BallController ballController;
    public AudioSource audioSource;
    public AudioClip collection;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            audioSource.PlayOneShot(collection, .25f);
            // destory gem object
            Destroy(gameObject);
            // reference ball controller to add num tokens
            ballController.addToken();
        }
    }
}
