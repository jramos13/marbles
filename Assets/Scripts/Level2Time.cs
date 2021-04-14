using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Level2Time : MonoBehaviour
{
    public Text level2Time;

    private string str;

    // Start is called before the first frame update
    void Start()
    {
        level2Time = GetComponent<Text>() as Text;
        level2Time.text = "--:--";
    }

    private void Update()
    {
        str = PlayerPrefs.GetString("level2");
        if (string.IsNullOrEmpty(str) != true)
        {
            level2Time.text = PlayerPrefs.GetString("level2");
        }
    }
}