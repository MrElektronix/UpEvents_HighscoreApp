using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmailValueChange : MonoBehaviour {
	public InputField emailSpeler;
	private string eSpeler;

	//inputfield naam,email - done
	//functie maken die input toevoegd aan de list 
	//data naar een string list 
	//list naar een playerpref
	//player pref opslaan onder 1 key

	public void OnValueChanged(){
		eSpeler = emailSpeler.text;
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

	public string EmailSpeler {
		get {
			return eSpeler;
		}set {
			eSpeler = value;
		}
	}


}

