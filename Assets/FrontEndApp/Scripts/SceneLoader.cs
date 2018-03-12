﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour {
	public int Scene;
	public void OnClick(){
		LoadScene();
	}
	public void LoadScene(){
		SceneManager.LoadScene (Scene);
	}
}