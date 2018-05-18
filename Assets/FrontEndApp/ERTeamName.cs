using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ERTeamName : MonoBehaviour {

	public InputField TeamNameInput;
	private string _tNameDataEscapeRoom;
	public GameObject button;

	void Start(){
		TeamNameInput = gameObject.GetComponent<InputField> ();
		button.SetActive (false);
	}
	void Update(){
		_tNameDataEscapeRoom = TeamNameInput.text;
		PlayerPrefs.SetString ("EscapeRoomTeamName", _tNameDataEscapeRoom);
		if (TeamNameInput.text == "") {
			button.SetActive (false);
		} else {
			button.SetActive (true);
		}
	}
}
