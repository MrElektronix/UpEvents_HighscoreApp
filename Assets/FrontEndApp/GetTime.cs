using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetTime : MonoBehaviour {
    public InputField minutes;
    public InputField seconds;

    public void SaveTime ()
    {
        PlayerPrefs.SetString("Minutes", minutes.text);
        PlayerPrefs.SetString("Seconds", seconds.text);
    }


}
