using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Level3Time : MonoBehaviour
{
    public Text level3Time;

    private string str;

    // Start is called before the first frame update
    void Start()
    {
        level3Time = GetComponent<Text>() as Text;
        level3Time.text = "--:--";
    }

    private void Update()
    {
        str = PlayerPrefs.GetString("level3");
        if (string.IsNullOrEmpty(str) != true)
        {
            level3Time.text = PlayerPrefs.GetString("level3");
        }
    }
}