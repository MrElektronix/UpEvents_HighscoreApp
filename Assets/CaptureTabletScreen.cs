using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;




public class CaptureTabletScreen : MonoBehaviour {
	
	string imageName = "screenshot.png";




	public void OnClick(){
				ScreenCapture.CaptureScreenshot (imageName);
				Debug.Log ("Foto Genomen");
			
				
	
		}


}



