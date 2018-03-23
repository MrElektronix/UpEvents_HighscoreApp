using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaserTagTeamName : MonoBehaviour {

	public Text _tName1;
	public Text _tName2;

	string _teamName1;
	string _teamName2;

	// Use this for initialization
	void Start () {
		_teamName1 = PlayerPrefs.GetString ("LaserTagTeamNameOne");
		_teamName2 = PlayerPrefs.GetString ("LaserTagTeamNameTwo");
	}
	
	// Update is called once per frame
	void Update () {
		_tName1.text = _teamName1;
		_tName2.text = _teamName2;
	}
}
