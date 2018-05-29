using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour {

	public TakePhoto userCamera;
	public int Scene;
	public void OnClick(){
		userCamera.DeletePhoto ();
		LoadScene();

	}
	public void LoadScene(){
		SceneManager.LoadScene (Scene);
	}
}
