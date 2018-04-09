using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class TakePhoto : MonoBehaviour {

	WebCamTexture _webCamTexture;
	public string screenShotFileName;
	private string _originPath;
	private string _filePath;
	private int screenShotCount = 0;
	public GameObject button;
	private byte[] bytesFile;
	private Texture2D texture;
	private bool shotTaken = false;

	void Start(){
		_webCamTexture = new WebCamTexture ();
	}
	public void Timer(){
		StartCoroutine (TakeSnapShot());
	}
	IEnumerator TakeSnapShot(){
		screenShotCount++;
		Debug.Log ("Button Deactivated");
		button.SetActive (false);
		//FileName Declareren 
		screenShotFileName = "Screenshot__" + screenShotCount + System.DateTime.Now.ToString ("__yyyy-MM-dd") + ".png";
		//Screenshot maken
		ScreenCapture.CaptureScreenshot (screenShotFileName);
		yield return new WaitForSeconds (2);
		shotTaken = true;
		//Button weer naar active
		button.SetActive (true);
	}

	void Update(){
		//Move To folder
		if (shotTaken == true) {	
				




				_originPath = System.IO.Path.Combine(Application.persistentDataPath,screenShotFileName);
				Debug.Log (_originPath);
				_filePath = "/Users/noah/Library/Application Support/UpEvents/HighScoreApp/Media/GroupPictures/" + screenShotFileName;
				Debug.Log (_filePath);
					if (System.IO.File.Exists (_originPath)) {
						System.IO.File.Move (_originPath, _filePath);
						shotTaken = false;
					} else {
						Debug.Log ("Werkt Niet");
							
					}
			}
		}
	}
	