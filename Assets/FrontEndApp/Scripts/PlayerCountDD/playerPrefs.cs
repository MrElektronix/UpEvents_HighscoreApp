using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPrefs : MonoBehaviour {

	void Update(){
		Debug.Log(PlayerPrefs.GetFloat ("ddValue1"));
		Debug.Log(PlayerPrefs.GetFloat ("ddValue2"));



	}

}
