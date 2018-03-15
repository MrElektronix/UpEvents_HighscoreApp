using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabletCamera : MonoBehaviour {

	private bool camAvaible; 
	private WebCamTexture backCamera;
	private Texture defaultBackGround;

	public RawImage backGroundImage;
	public AspectRatioFitter fit;



	// Use this for initialization
	void Start () {
		defaultBackGround = backGroundImage.texture;
		WebCamDevice[] devices = WebCamTexture.devices;

		if (devices.Length == 0) {
			Debug.Log ("Geen Camera gedetecteerd");
			camAvaible = false;
			return;

		}

		for (int i = 0; i < devices.Length; i++) {
			if (!devices [i].isFrontFacing) {
				backCamera = new WebCamTexture (devices [i].name, Screen.width, Screen.height);
			}

		}

		if (backCamera == null) {
			Debug.Log ("Back camera hasnt been found");
			return ;
		
		}
		 
		backCamera.Play ();
		backGroundImage.texture = backCamera;
		camAvaible = true;


	}
	
	// Update is called once per frame
	void Update () {
		if (!camAvaible) {
			return;
		}

		float ratio = (float)backCamera.width /  (float)backCamera.height;
		fit.aspectRatio = ratio;

		float scaleY = backCamera.videoVerticallyMirrored ?  -1f: 1f;
		backGroundImage.rectTransform.localScale = new Vector3 (1f, scaleY, 1f);

		int orient = -backCamera.videoRotationAngle;
		backGroundImage.rectTransform.localEulerAngles = new Vector3 (0, 0, orient);

	}
}
