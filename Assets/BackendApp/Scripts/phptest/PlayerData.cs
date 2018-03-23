using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData {
    public string eventName;
    public string gameMode;
    public string teamName;
    public string currentTime;

    public PlayerData(string EventName, string GameMode, string TeamName){
        this.eventName = EventName;
        this.gameMode = GameMode;
        this.teamName = TeamName;
    }
}
