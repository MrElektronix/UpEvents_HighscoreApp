using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DDManager1 : MonoBehaviour {

	private Dropdown _dropDown;
	public static int ddValue;
	[SerializeField]private GameObject _go;

	void Start () {
		
		List <string> dropDownOptions = new List<string> { "Laser Gamen", "Escape Room" };

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
