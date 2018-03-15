using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCountDDManager : MonoBehaviour {
	[SerializeField]private Dropdown _dd1;
	[SerializeField]private Dropdown _dd2;

	private float _dd1Value;
	private float _dd2Value;



	void Start(){
		if (gameObject.tag == "PlayerCount1") {
			List <string> dropDownOptions1 = new List<string> {
				"1",
				"2",
				"3",
				"4",
				"5",
				"6",
				"7",
				"8",
				"9",
				"10",
				"11",
				"12",
				"13",
				"14",
				"15"
			};
			_dd1 = gameObject.GetComponent<Dropdown> ();
			_dd1.ClearOptions ();
			_dd1.AddOptions (dropDownOptions1);
		}
		if (gameObject.tag == "PlayerCount2") {

			List <string> dropDownOptions2 = new List<string> {
				"1",
				"2",
				"3",
				"4",
				"5",
				"6",
				"7",
				"8",
				"9",
				"10",
				"11",
				"12",
				"13",
				"14",
				"15"
			};
			_dd2 = gameObject.GetComponent<Dropdown> ();
			_dd2.ClearOptions ();
			_dd2.AddOptions (dropDownOptions2);
		}
	}

	void Update(){
		_dd1Value = _dd1.value;
		_dd2Value = _dd2.value;

		PlayerPrefs.SetFloat ("ddValue1", _dd1Value);
		PlayerPrefs.SetFloat ("ddValue2", _dd2Value);


	}



}
