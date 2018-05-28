using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetTime : MonoBehaviour {
    public InputField minutes;
    public InputField seconds;

    private void Start()
    {
        PlayerPrefs.SetString("Minutes", "");
        PlayerPrefs.SetString("Seconds", "");
    }
    public void CheckTime (int maxMinutes, int maxSeconds)
    {   
        if (minutes.text != "" && seconds.text != "" && int.Parse(minutes.text) <= 60 && int.Parse(seconds.text) <= 60 && int.Parse(minutes.text) >= 0 && int.Parse(seconds.text) >= 0)
        {
            SaveTime();
        }
    }

    private void SaveTime()
    {
        PlayerPrefs.SetString("Minutes", minutes.text);
        PlayerPrefs.SetString("Seconds", seconds.text);
    }


}
