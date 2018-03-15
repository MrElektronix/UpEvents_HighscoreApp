using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerCountManagerER : MonoBehaviour {
	[SerializeField]private Dropdown _dd;
	float ddValueER;


	void Start(){
		_dd = gameObject.GetComponent<Dropdown> ();
		List <string> _ddOptions = new List<string>{ "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
		_dd.ClearOptions ();
		_dd.AddOptions (_ddOptions);
	}

	void Update(){
		ddValueER = _dd.value;

		PlayerPrefs.SetFloat ("_ddValueER", ddValueER);

	}

}
