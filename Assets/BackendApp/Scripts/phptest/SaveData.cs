using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SaveData : MonoBehaviour {

    public PlayerData playerData;
    private WWW www;
    private WWWForm form;


    private void Start()
    {
        //playerData = new PlayerData("Lasergamen",  "Team Deathmatch", "Sterrenteam");

        //form.AddField("Main", "StartMain");
        //form.AddField("MakeRoom", "StartRoom");
        /*
        form.AddField("Event", playerData.eventName);
        form.AddField("TeamName", playerData.teamName);
        form.AddField("GameMode", playerData.gameMode);
        form.AddField("CurrentDate", System.DateTime.Today.ToString("dd/MM/yyyy"));
        form.AddField("CurrentTime", System.DateTime.Now.ToString("HH:mm:ss"));
        */
    }

    private void NewForm(string url, WWWForm form)
    {
        www = new WWW(url, form);
        StartCoroutine(WaitForRequest(www));
    }

    public void CreateDay()
    {
        string url = "http://localhost:3000/newDay";
        form = new WWWForm();

        form.AddField("MakeDay", 1);

        NewForm(url, form);
    }

    public void CreateEvent()
    {
        string url = "http://localhost:3000/newEvent";
        form = new WWWForm();

        form.AddField("EventName", PlayerPrefs.GetString("EventName").ToString());
        form.AddField("GameMode", PlayerPrefs.GetString("GameMode").ToString());

        NewForm(url, form);
    }

    public void CreateERTeam()
    {
        string url = "http://localhost:3000/newERTeam";
        form = new WWWForm();

        form.AddField("TeamName", PlayerPrefs.GetString("EscapeRoomTeamName"));

        NewForm(url, form);
    }

    public void CreateLGTeam()
    {
        string url = "http://localhost:3000/newLGTeam";
        form = new WWWForm();

        form.AddField("TeamNameOne", PlayerPrefs.GetString("LaserTagTeamNameOne"));
        form.AddField("TeamNameTwo", PlayerPrefs.GetString("LaserTagTeamNameTwo"));

        NewForm(url, form);
    }

    public void AddLGPlayers()
    {

    }

    public void AddERPlayers(string name, string email)
    {
        string url = "http://localhost:3000/newERusers";
        form = new WWWForm();

        form.AddField("PlayerInfo_names", name);
        form.AddField("PlayerInfo_email", email);

        NewForm(url, form);
    }

    public void SendEmail()
    {
        string url = "http://localhost:3000/SendMail";
        form = new WWWForm();

        form.AddField("mail", 1);

        NewForm(url, form);
    }

    IEnumerator WaitForRequest(WWW www)
    {
        yield return www;

        // check for errors
        if (www.error == null)
        {
            Debug.Log("WWW Ok!: " + www.text);
        }
        else
        {
            Debug.Log("WWW Error: " + www.error);
        }
    }
    /*
    [HideInInspector]
    public PlayerData playerData;
    private string url;

    void Start()
    {

        string url = "http://milovanpelt.nl/JsonFile/PlayerData.json";

        WWWForm form = new WWWForm();
        form.AddField("var1", "value1");
        form.AddField("var2", "value2");
        WWW www = new WWW(url, form);

        StartCoroutine(WaitForRequest(www));
    }

    IEnumerator WaitForRequest(WWW www)
    {
        yield return www;

         // check for errors
        if (www.error == null)
        {
            Debug.Log("WWW Ok!: " + www.text);
        }
        else
        {
            Debug.Log("WWW Error: " + www.error);
        }
    }

    /*
    private void Start()
    {
        string url = "http://milovanpelt.nl/JsonFile/PlayerData.json";
        WWWForm formDate = new WWWForm();
        //formDate.AddField("komkommers", "lekker");

        WWW www = new WWW(url);

        StartCoroutine(request(www)); 

    }
   
    IEnumerator request(WWW www)
    {
        yield return www;

        Debug.Log(www.text);
    
    }
    /*
    IEnumerator GetText()
    {
        UnityWebRequest www = UnityWebRequest.Get("http://milovanpelt.nl/JsonFile/PlayerData.json");
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            // Show results as text
            Debug.Log(www.downloadHandler.text);

            // Or retrieve results as binary data
            byte[] results = www.downloadHandler.data;
            //StartCoroutine(Upload());
        }
    }
    
    IEnumerator Upload()
    {

        
        string postData = "This is a test that posts this string to a Web server.";
        byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(postData);

        using (UnityWebRequest www = UnityWebRequest.Put("http://milovanpelt.nl/JsonFile/PlayerData.json", byteArray))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log("Upload complete!");
            }
        }

    }
    */
    /*
    void Start()
    {
        url = "http://milovanpelt.nl/JsonFile/PlayerData.json";
        WWW www = new WWW(url, null,);
        StartCoroutine(WaitForRequest(www));
    }

    IEnumerator WaitForRequest(WWW www)
    {
        yield return www;

        // check for errors
        if (www.error == null)
        {
            Debug.Log("WWW Ok!: " + www.text);
        }
        else
        {
            Debug.Log("WWW Error: " + www.error);
        }
    }
    */


}