using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class TakePhoto : MonoBehaviour {

	WebCamTexture _webCamTexture;
	public string path = "";
	public string filename = "Snapshots";

	void Start(){
		_webCamTexture = new WebCamTexture ();
	}


	public void OnClick(){
		TakeSnapShot ();
	}



	void TakeSnapShot(){
		/*
		Texture2D snap = new Texture2D (_webCamTexture.width, _webCamTexture.height);
		snap.SetPixels (_webCamTexture.GetPixels(1, 1,_webCamTexture.height,_webCamTexture.width));
		snap.Apply ();
		byte[] bytes = snap.EncodeToPNG ();
		path = Application.persistentDataPath 
		*/
		ScreenCapture.CaptureScreenshot(filename);


	}
}
