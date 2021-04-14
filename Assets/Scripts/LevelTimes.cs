using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LevelTimes : MonoBehaviour
{
    public Text easy;
    public Text medium;
    public Text hard;
    public Text gems;

    // Start is called before the first frame update
    void Start()
    {
        easy = GetComponent<Text>() as Text;
        medium = GetComponent<Text>() as Text;
        hard = GetComponent<Text>() as Text;
        gems = GetComponent<Text>() as Text;
    }

    public void setEasy (string timer)
    {
        easy.text = timer;
    }

    public void setMedium (string timer)
    {
        easy.text = timer;
    }

    public void setHard (string timer)
    {
        easy.text = timer;
    }
}
