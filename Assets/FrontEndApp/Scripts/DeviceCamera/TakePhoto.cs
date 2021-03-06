﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;



public class TakePhoto : MonoBehaviour
{

    WebCamTexture _webCamTexture;
    public string screenShotFileName;
    private string _originPath;
    private string _filePath;
    private int screenShotCount;
    public GameObject takePicture;
    public GameObject retakePicture;
    public GameObject sendPicture;
    private byte[] bytesFile;
    private Texture2D tex;
    private bool shotTaken = false;
    public Image _sr;


    private void Awake()
    {
        DeletePhoto();
    }

    void Start()
    {
        _sr.enabled = false;
        screenShotCount = 0;
        sendPicture.SetActive(false);
        retakePicture.SetActive(false);
        _webCamTexture = new WebCamTexture();
        if (!Directory.Exists(Application.persistentDataPath + "/" + "Media"))
        {
            Debug.Log("Create Dir 1");
            DirectoryInfo info = Directory.CreateDirectory(Application.persistentDataPath + "/" + "Media");
        }
        if (!Directory.Exists(Application.persistentDataPath + "/" + "Media/Pictures"))
        {
            Debug.Log("Create Dir 2");
            DirectoryInfo info = Directory.CreateDirectory(Application.persistentDataPath + "/" + "Media/Pictures");
        }
    }

    public void Timer()
    {
        StartCoroutine(TakeSnapShot());
    }

    IEnumerator TakeSnapShot()
    {

        screenShotCount++;
        Debug.Log("Button Deactivated");
        takePicture.SetActive(false);
        //FileName Declareren 
        screenShotFileName = "Screenshot__" + screenShotCount + System.DateTime.Now.ToString("__yyyy-MM-dd") + ".png";
       
        //Screenshot maken
        ScreenCapture.CaptureScreenshot(screenShotFileName);
        yield return new WaitForSeconds(2);
        shotTaken = true;
        //Button weer naar active


        SavePhoto();
    }

    void SavePhoto()
    {
        //Move To folder
        if (shotTaken == true)
        {
            _originPath = System.IO.Path.Combine(Application.persistentDataPath, screenShotFileName);
            Debug.Log(_originPath + "Werkt");
            _filePath = Application.persistentDataPath + "/Media/Pictures/" + screenShotFileName;
            if (System.IO.File.Exists(_originPath))
            {
                System.IO.File.Move(_originPath, _filePath);
                Debug.Log("Werkt wel, Foto opgeslagen onder" + _filePath);
                DisplayPicture();
            }
            else
            {
                Debug.Log("Werkt Niet");
                shotTaken = false;
            }
        }
    }

    void DisplayPicture()
    {

        //display picture 
        _sr.enabled = true;
        Debug.Log("Foto Genomen");
        bytesFile = File.ReadAllBytes(_filePath);
        tex = new Texture2D(Screen.width, Screen.height, TextureFormat.Alpha8, false);
        tex.LoadImage(bytesFile);
        tex.Apply();

        if (tex != null)
        {
            _sr.sprite = Sprite.Create(tex, new Rect(0, 0, Screen.width, Screen.height), new Vector2(.5f, .5f));
        }
        sendPicture.SetActive(true);
        retakePicture.SetActive(true);

        byte[] toBytes = System.IO.File.ReadAllBytes(Application.persistentDataPath + "/Media/Pictures/" + screenShotFileName);
        string base64Tex = System.Convert.ToBase64String(toBytes);
        System.IO.File.WriteAllText(Application.persistentDataPath + "/Media/Pictures/p.txt", base64Tex);
        //PlayerPrefs.SetString("byteFile", base64Tex);
        //string base64Tex = System.Convert.ToBase64String(screenShotFileName);
        //PlayerPrefs.SetString("byteFile", base64Tex);

    }

    public void DeletePhoto()
    {
        if (!File.Exists(_filePath))
        {
            Debug.Log("Bestand bestaat niet.");
        }
        else
        {
            File.Delete(_filePath);
            screenShotCount = 0;
            _sr.enabled = false;
            sendPicture.SetActive(false);
            retakePicture.SetActive(false);
            takePicture.SetActive(true);
        }
    }

    public void SendPhoto()
    {
        File.Delete(_filePath);
    }
}