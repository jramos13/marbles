using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class EndGame : MonoBehaviour
{
    public GameObject endTime;
    public GameObject endGem;
    public GameObject endMenu;
    public AudioSource audioSource;
    public AudioClip checkpoint; 

    private Text endTimeText;
    private Text endGemText;

    private static float min;
    private static float sec;
    private static int gem;

    void Start()
    {
        endTimeText = endTime.GetComponent<Text>() as Text;
        endGemText = endGem.GetComponent<Text>() as Text;
    }

    private void OnTriggerEnter(Collider other)
    {
        // play audio
        audioSource.PlayOneShot(checkpoint, .75f);

        // stop time
        Time.timeScale = 0;

        // get end level time
        min = (int)TimerScript.minutes;
        sec = (int)TimerScript.seconds;

        // get end gem count
        gem = TokenScript.numPoints;

        // set text to level time and gem count
        endTimeText.text = "Time: " + min.ToString("00") + ":" + sec.ToString("00");
        endGemText.text = "Gems Collected: " + gem.ToString("00") + "/25";

        // display end menu
        endMenu.SetActive(true);
        Cursor.visible = true;

        Scene scene = SceneManager.GetActiveScene();
        switch(scene.name)
        {
            case "Level1":
                if (string.IsNullOrEmpty(PlayerPrefs.GetString("level1")) != true)
                {
                    System.TimeSpan time1 = System.TimeSpan.Parse(PlayerPrefs.GetString("level1"));
                    System.TimeSpan time2 = System.TimeSpan.Parse(min.ToString("00") + ":" + sec.ToString("00"));
                    int result = System.TimeSpan.Compare(time1, time2);
                    if (result > 0)
                    {
                        PlayerPrefs.SetString("level1", min.ToString("00") + ":" + sec.ToString("00"));
                    }
                }
                else
                {
                    PlayerPrefs.SetString("level1", min.ToString("00") + ":" + sec.ToString("00"));
                }
                break;
            case "Level2":
                if (string.IsNullOrEmpty(PlayerPrefs.GetString("level2")) != true)
                {
                    System.TimeSpan time3 = System.TimeSpan.Parse(PlayerPrefs.GetString("level2"));
                    System.TimeSpan time4 = System.TimeSpan.Parse(min.ToString("00") + ":" + sec.ToString("00"));
                    int result2 = System.TimeSpan.Compare(time3, time4);
                    if (result2 > 0)
                    {
                        PlayerPrefs.SetString("level2", min.ToString("00") + ":" + sec.ToString("00"));
                    }
                }
                else
                {
                    PlayerPrefs.SetString("level2", min.ToString("00") + ":" + sec.ToString("00"));
                }
                break;
            case "Level3":
                if (string.IsNullOrEmpty(PlayerPrefs.GetString("level3")) != true)
                {
                    System.TimeSpan time5 = System.TimeSpan.Parse(PlayerPrefs.GetString("level3"));
                    System.TimeSpan time6 = System.TimeSpan.Parse(min.ToString("00") + ":" + sec.ToString("00"));
                    int result3 = System.TimeSpan.Compare(time5, time6);
                    if (result3 > 0)
                    {
                        PlayerPrefs.SetString("level3", min.ToString("00") + ":" + sec.ToString("00"));
                    }
                }
                else
                {
                    PlayerPrefs.SetString("level3", min.ToString("00") + ":" + sec.ToString("00"));
                }
                break;
        }
    }
}
