using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TokenScript : MonoBehaviour
{
    public BallController ballController;

    public Text pointsText;
    public static int numPoints;
    // Start is called before the first frame update
    void Start()
    {
        pointsText = GetComponent<Text>() as Text;
    }

    // Update is called once per frame
    void Update()
    {
        numPoints = ballController.getNumTokens();

        pointsText.text = "Gems Collected: " + numPoints.ToString("00") + "/25";
    }
}
