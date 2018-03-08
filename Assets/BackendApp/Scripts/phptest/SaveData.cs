using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;
using UnityEngine.Networking;

public class SaveData : MonoBehaviour {

    public PlayerData playerData;

    void Start()
    {
        playerData = new PlayerData("Lasergamen", "Komkommers");

        string url = "http://milovanpelt.nl/Json/WriteData.php";
        WWWForm form = new WWWForm();
        form.AddField("Main", "StartMain");

        //form.AddField("MakeRoom", "StartRoom");
        //form.AddField("Event", playerData.eventName);
        //form.AddField("TeamName", playerData.teamName);
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