using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ERTeamName : MonoBehaviour {

	public InputField TeamNameInput;
	private string _tNameDataEscapeRoom;


	void Start(){
		TeamNameInput = gameObject.GetComponent<InputField> ();

	}

	void Update(){
		_tNameDataEscapeRoom = TeamNameInput.text;
		PlayerPrefs.SetString ("EscapeRoomTeamName", _tNameDataEscapeRoom);
	}



}
