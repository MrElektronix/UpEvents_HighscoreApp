using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPanelER : MonoBehaviour {

	private float _playerCountTeam1;
	private float curPlayers = 0;
	private List<float> Players = new List<float> ();
	private float addList = 1;  
	public GameObject playerPanel;
	[SerializeField]
	private GameObject _parentObj;


	void Start(){
		_playerCountTeam1 = PlayerPrefs.GetFloat ("_ddValueER");
	}

	void Update ()
	{
		if (curPlayers <= _playerCountTeam1) {
			curPlayers++;
			GameObject GO = Instantiate (playerPanel, transform.position, Quaternion.identity);
			GO.transform.SetParent (_parentObj.transform, false);
		}

		//Debug.Log (Players.Count);
	}


}
	