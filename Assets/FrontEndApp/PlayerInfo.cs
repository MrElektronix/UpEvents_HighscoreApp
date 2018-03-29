using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour {

	NameValueChange _name;
	EmailValueChange _email;



	public Dictionary<string,string> playerInfoDict = new Dictionary<string,string>();

	void Start(){
        _name = gameObject.GetComponentInChildren<NameValueChange>();
		_email = gameObject.GetComponentInChildren<EmailValueChange>();
	}


    public void AddPlayerInfo()
    {
        playerInfoDict.Add(_name.NameSpeler, _email.EmailSpeler);
        
        foreach(KeyValuePair<string, string> playerinfo in playerInfoDict)
        {
            Debug.Log(playerinfo.Key);
            Debug.Log(playerinfo.Value);
        }
        
    }
}
