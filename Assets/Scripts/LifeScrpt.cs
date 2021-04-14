using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LifeScrpt : MonoBehaviour
{

    public BallController ballController;

    public Text lifeText;
    public int lives;
    // Start is called before the first frame update
    void Start()
    {
        lifeText = GetComponent<Text>() as Text;   
    }

    // Update is called once per frame
    void Update()
    {
        lives = ballController.getLives();
        lifeText.text = "Lives: " + lives.ToString("0");
    }
}
