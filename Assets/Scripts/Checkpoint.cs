using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public BallController ballController;
    public AudioSource audioSource;
    public AudioClip checkpoint;
    public GameObject particleSys;
    public bool checkpointReached;

    void Start()
    {
        checkpointReached = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && checkpointReached == false)
        {
            ballController.setCheckpoint();
            checkpointReached = true;
            audioSource.PlayOneShot(checkpoint, .75f);
            Destroy(particleSys);
        }
    }
}
