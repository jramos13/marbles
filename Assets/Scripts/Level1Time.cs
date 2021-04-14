using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Level1Time : MonoBehaviour
{
    public Text level1Time;

    private string str;

    // Start is called before the first frame update
    void Start()
    {
        level1Time = GetComponent<Text>() as Text;
        level1Time.text = "--:--";
    }

    private void Update()
    {
        str = PlayerPrefs.GetString("level1");
        if (string.IsNullOrEmpty(str) != true)
        {
            level1Time.text = PlayerPrefs.GetString("level1");
        }
    }
}
