using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleButton : MonoBehaviour {


    public GameObject toggleObject;
    public GameObject button;

	// Use this for initialization
	void Start () {
        button.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (toggleObject.GetComponent<Toggle>().isOn == true)
        {
            button.SetActive(true);
        }
        else
        {
            button.SetActive(false);
        }
    }
}
