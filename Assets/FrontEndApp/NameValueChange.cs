using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameValueChange : MonoBehaviour {
	public InputField naamSpeler;
	private string nSpeler;
	PlayerInfo _addInfo;

	public void Start()
	{
		//Adds a listener that invokes the "LockInput" method when the player finishes editing the main input field.
		//Passes the main input field into the method when "LockInput" is invoked
		naamSpeler.onEndEdit.AddListener(delegate {LockInput(naamSpeler); });

	}

	//inputfield naam,email - done
	//functie maken die input toevoegd aan de list 
	//data naar een string list 
	//list naar een playerpref
	//player pref opslaan onder 1 key
	public void OnValueChanged(){
		nSpeler = naamSpeler.text;
	}

	void LockInput(InputField input)
	{
		if (input.text.Length > 0)
		{
			
			Debug.Log ("Locked");
		}

		else if (input.text.Length == 0)
		{
			Debug.Log("Main Input Empty");
		}
	}

	public string NameSpeler {
		get {
			return nSpeler;
		}set {
			nSpeler = value;
		}
	}
	
}