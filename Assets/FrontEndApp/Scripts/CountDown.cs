using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CountDown : MonoBehaviour
{
	float timeLeft = 300.0f;
	float endTime = 0.0f;
	StartTimer _timer;
	public Text text;



	void Start(){
		_timer = GameObject.Find ("StartButton").GetComponent<StartTimer> ();
	}


	void Update(){
		if (_timer.start == true) {
			timeLeft -= Time.deltaTime;
			text.text = "Tijd Over:" + Mathf.Round (timeLeft);
			endTime = timeLeft;
			if (timeLeft < 0) {
				Application.LoadLevel ("gameOver");
			}
		} else if (_timer.start == false) {
			
			text.text = "Tijd Over:" + Mathf.Round (endTime);
		}


	}


}