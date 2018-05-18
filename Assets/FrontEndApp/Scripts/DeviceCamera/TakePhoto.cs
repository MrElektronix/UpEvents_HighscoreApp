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
	private Texture2D tex;
	private bool shotTaken = false;
	public SpriteRenderer _sr;
	
	

	void Start(){
		_sr = gameObject.GetComponent<SpriteRenderer>() as SpriteRenderer;
		_webCamTexture = new WebCamTexture ();
		if (!Directory.Exists (Application.persistentDataPath + "/" + "Media")) {
			Debug.Log ("Create Dir 1");
			DirectoryInfo info = Directory.CreateDirectory (Application.persistentDataPath + "/" + "Media");
		}
		if (!Directory.Exists (Application.persistentDataPath + "/" + "Media/Pictures")) {
			Debug.Log ("Create Dir 2");
			DirectoryInfo info = Directory.CreateDirectory (Application.persistentDataPath + "/" + "Media/Pictures");
		}
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
		ScreenCapture.CaptureScreenshot(screenShotFileName);
		yield return new WaitForSeconds (2);
		shotTaken = true;
		//Button weer naar active
		button.SetActive (true);
		SavePhoto();
	}

	void SavePhoto(){
		//Move To folder
		if (shotTaken == true) {
			_originPath = System.IO.Path.Combine(Application.persistentDataPath , screenShotFileName);
			Debug.Log (_originPath + "Werkt");
			_filePath =   Application.persistentDataPath + "/Media/Pictures/" + screenShotFileName;
			if (System.IO.File.Exists (_originPath)) {
				System.IO.File.Move (_originPath, _filePath);
				Debug.Log ("Werkt wel, Foto opgeslagen onder" + _filePath);
				DisplayPicture ();

			} else {
				Debug.Log ("Werkt Niet");
			}

		}

				


		}
	void DisplayPicture(){
			
				//display picture 
				Debug.Log("Foto Genomen");
				bytesFile = System.IO.File.ReadAllBytes(_filePath);
				Debug.Log (bytesFile);
                 tex = new Texture2D(0, 0, TextureFormat.Alpha8, false);
                 tex.LoadImage(bytesFile);
					tex.Apply ();
				  if(tex != null){
					_sr.sprite = Sprite.Create(tex, new Rect(0,0,Screen.width,Screen.height), new Vector2(.5f, .5f));
					
						
        		 //draw texture
				//enable button om door te gaan
				//enable button om opnieuw een foto te maken
				//Zodra de foto oke is en naar de volgende scene wodt genavigeerd,delete genomen fotos 
				//Zet screenshotcount terug naar 0
			}
		}

	}
	