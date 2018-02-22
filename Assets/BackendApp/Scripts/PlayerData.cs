using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData {
    public string eventName;
    public string teamName;

    public PlayerData(string EventName, string TeamName){
        this.eventName = EventName;
        this.teamName = TeamName;
    }
}
