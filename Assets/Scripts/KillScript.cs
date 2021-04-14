using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillScript : MonoBehaviour
{

    public BallController ballController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ballController.death();
        }
    }
}
