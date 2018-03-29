using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveEventData : MonoBehaviour {
    public Text Event;
    public Text Gamemode;


    // Update is called once per frame
    void Update () {
        PlayerPrefs.SetString("EventName", Event.text);
        PlayerPrefs.SetString("GameMode", Gamemode.text);
	}
}
