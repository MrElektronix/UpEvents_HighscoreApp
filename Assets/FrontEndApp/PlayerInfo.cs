using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour {
    private 
	NameValueChange _name;
	EmailValueChange _email;

	public Dictionary<string,string> playerInfoDict = new Dictionary<string,string>();
    public SaveData saveData;

	void Start(){

        _name = gameObject.GetComponentInChildren<NameValueChange>();
		_email = gameObject.GetComponentInChildren<EmailValueChange>();

        saveData = GetComponent<SaveData>();
	}


    public void AddPlayerInfo()
    {
 
        var temp = GameObject.FindGameObjectsWithTag("Panel");

        for (int i = 0; i < temp.Length; i++)
        {
            playerInfoDict.Add(temp[i].GetComponent<PlayerInfo>()._name.NameSpeler, temp[i].GetComponent<PlayerInfo>()._email.EmailSpeler);

            if (i == (temp.Length - 1))
            {
                SavePlayerInfo();
            }
        }
    }

    private void SavePlayerInfo()
    {
        var saveTag = GameObject.FindGameObjectsWithTag("Save");
        for (int i = 0; i < saveTag.Length; i++)
        {
            foreach (KeyValuePair<string, string> playerinfo in playerInfoDict)
            {
                //saveData.AddERPlayers(playerinfo.Key, playerinfo.Value);
                saveTag[i].GetComponent<SaveData>().AddERPlayers(playerinfo.Key, playerinfo.Value);
            }
        }
    }
}
