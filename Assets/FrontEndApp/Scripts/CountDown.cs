using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CountDown : MonoBehaviour
{
	float timeLeft;
	float endTime = 0.0f;
	StartTimer _timer;
	public Text text;
	public GameObject photoButton;


	void Start(){
		timeLeft = 10.0f;
		_timer = GameObject.Find ("StartButton").GetComponent<StartTimer> ();
		photoButton.SetActive (false);
	}


	void Update(){
		if (_timer.start == true) {
			timeLeft -= Time.deltaTime;
			text.text = "Tijd Over:" + Mathf.Round (timeLeft);
			endTime = timeLeft;
			if (timeLeft < 0) {
				photoButton.SetActive (true);
				timeLeft = 0;
			}
		} else if (_timer.start == false) {
			
			text.text = "Tijd Over:" + Mathf.Round (endTime);
		}
		
	}
}