using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LTTeamName : MonoBehaviour {

	public InputField TeamNameOneInput;
	public InputField TeamNameTwoInput;

	private string _tNameOneDataLT;
	private string _tNameTwoDataLT;

	void Update(){
		_tNameOneDataLT = TeamNameOneInput.text;
		_tNameTwoDataLT = TeamNameTwoInput.text;

		PlayerPrefs.SetString ("LaserTagTeamNameOne", _tNameOneDataLT);
		PlayerPrefs.SetString ("LaserTagTeamNameTwo", _tNameTwoDataLT);


	}

}
