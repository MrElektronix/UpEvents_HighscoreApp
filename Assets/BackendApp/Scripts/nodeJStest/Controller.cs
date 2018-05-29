﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SocketIO;
using LitJson;

public class Controller : MonoBehaviour
{
    public SocketIOComponent socket;

    private string jsonString;
    private JsonData Alert;


    private Dictionary<string, string> data = new Dictionary<string, string>();
    private int numberone;
    private int numbertwo;
    
 
    private void Start()
    {
        socket.On("catchdata", ShowData);
    }

    public void ShowData(SocketIOEvent e)
    {
        jsonString = e.data.ToString();
        Alert = JsonMapper.ToObject(jsonString);

        Debug.Log(Alert["alert"]);
    }

    public void CreateDay()
    {
        socket.Emit("newDay");
    }

    public void CreateEvent()
    {
        data["EventName"] = PlayerPrefs.GetString("Eventname");
        data["GameMode"] = PlayerPrefs.GetString("GameMode");

        socket.Emit("newEvent", new JSONObject(data));
    }

    public void CreateERTeam()
    {
        data["TeamName"] = PlayerPrefs.GetString("EscapeRoomTeamName");
        socket.Emit("newERTeam", new JSONObject(data));
    }

    public void CreateLGTeam()
    {
        data["TeamNameOne"] = PlayerPrefs.GetString("LaserTagTeamNameOne");
        data["TeamNameTwo"] = PlayerPrefs.GetString("LaserTagTeamNameTwo");

        socket.Emit("newLGTeam", new JSONObject(data));
    }

    public void AddLGPlayers()
    {

    }

    public void AddERPlayers(string name, string email)
    {
        data["PlayerInfo_names"] = name;
        data["PlayerInfo_email"] = email;

        socket.Emit("newERPlayers", new JSONObject(data));
    }

    public void SendEmail()
    {
        socket.Emit("sendMail");
    }

    public void SendTime()
    {
        data["Minutes"] = PlayerPrefs.GetString("Minutes");
        data["Seconds"] = PlayerPrefs.GetString("Seconds");
        //data["TeamName"] = PlayerPrefs.GetString("EscapeRoomTeamName");
        if (int.TryParse(data["Minutes"], out numberone) && int.TryParse(data["Seconds"], out numbertwo) && data["Minutes"] != "" && data["Seconds"] != "")
        {
            socket.Emit("newTime", new JSONObject(data));
        }
    }

    public void DeleteTimes()
    {
        socket.Emit("deleteTime");
    }
}