using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EscapeRoomTeamName : MonoBehaviour {
	Text _text;
	string _teamName;

	void Start(){
		_text = gameObject.GetComponent<Text> ();
		_teamName = PlayerPrefs.GetString ("EscapeRoomTeamName");
	}

	void Update(){
		_text.text = _teamName;

	}


}
