using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AutoScreenChanger : MonoBehaviour {

	public int scene;

	// Use this for initialization
	void Start () {
		StartCoroutine (ExecuteOverTime ());
	}
	
	IEnumerator ExecuteOverTime (){
		yield return new WaitForSeconds (5);

		SceneManager.LoadScene (scene);
	}
}