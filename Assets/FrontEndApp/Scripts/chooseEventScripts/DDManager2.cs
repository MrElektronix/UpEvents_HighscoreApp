using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DDManager2 : MonoBehaviour {

	private Dropdown _dropDown;
	float ddValue;
	private GameObject _go;

	void Start () {
		List <string> dropDownOptions = new List<string> { "Escape room1", "Escape Room 2","Escape Room 3", "Escape Room 4"};

		_dropDown = gameObject.GetComponent<Dropdown> ();
		_dropDown.ClearOptions ();
		_dropDown.AddOptions (dropDownOptions);
	}
	
	void Update(){
		ddValue = _dropDown.value;

		if (ddValue == 0) {
			_go.SetActive (false);
		} else {
			_go.SetActive (true);
		}
	}
}		
