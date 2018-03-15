using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPanel : MonoBehaviour {

	private float _playerCountTeam1;
	private float _playerCountTeam2;



	private float curPlayers = 0;
	private float curPlayers2 = 0;

	public GameObject playerPanel;
	[SerializeField]
	private GameObject _parentObj;
	[SerializeField]
	private GameObject _parentObj2;




	void Start(){
		_playerCountTeam1 = PlayerPrefs.GetFloat ("ddValue1");
		_playerCountTeam2 = PlayerPrefs.GetFloat ("ddValue2");

	}

	void Update(){
		
		if (_parentObj.tag == "ParentObj1") {
			if (curPlayers <= _playerCountTeam1 - 1f) {
				curPlayers++;
				GameObject GO = Instantiate (playerPanel, transform.position, Quaternion.identity);
				GO.transform.SetParent (_parentObj.transform, false);
			}
		} 
		if (_parentObj2.tag == "ParentObj2") {
			if (curPlayers2 <= _playerCountTeam2 - 1f) {
				curPlayers2++;
				GameObject GO2 = Instantiate (playerPanel, transform.position, Quaternion.identity);
				GO2.transform.SetParent (_parentObj2.transform, false);
			}
		}

	}



}
