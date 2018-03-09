using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTimer : MonoBehaviour {

	CountDown _cd;

	public bool start = false;

	void Start(){
		_cd = GameObject.Find ("Timer").GetComponent<CountDown> ();
	}


	public void OnClick(){
		start = true;
	}

}
