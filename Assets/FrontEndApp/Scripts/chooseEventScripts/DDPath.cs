using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DDPath : MonoBehaviour {


	private static int dataValue;

	void Update(){
		dataValue = DDManager1.ddValue;
		//Debug.Log (dataValue);

	}
	public void OnClick(){
		if (dataValue == 0) {
			SceneManager.LoadScene (2);
		}else if(dataValue == 1){
			SceneManager.LoadScene (3);
		}
	}

}
