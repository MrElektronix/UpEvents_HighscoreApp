using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePlayerData : MonoBehaviour {

	PlayerInfo _pInfo;

	void Start(){

		_pInfo = GameObject.FindWithTag ("PlayerInfo").GetComponent<PlayerInfo> ();
	}

	public void OnClick(){
		_pInfo.AddPlayerInfo ();
	}


}
