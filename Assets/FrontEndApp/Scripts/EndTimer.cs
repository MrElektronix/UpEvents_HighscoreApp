using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTimer : MonoBehaviour {

	StartTimer _bool;
	public GameObject photoButton;


	void Start(){
		_bool = GameObject.Find ("StartButton").GetComponent<StartTimer> ();


	
	}

	public void OnClick(){
		_bool.start = false;

		photoButton.SetActive (true);

	}


}
