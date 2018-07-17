using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour {
	public int Scene;

	public void OnClick(){
        if(PlayerPrefs.GetString("wrongTeamName") == "used")
        {
            Scene = 2;
            StartCoroutine(WaitForCertainSeconds(0.1f));
        }
        else
        {
            StartCoroutine(WaitForCertainSeconds(0.1f));
        }
        
    }

    IEnumerator WaitForCertainSeconds(float secToWait)
    {
        yield return new WaitForSeconds(secToWait);
        SceneManager.LoadScene(Scene);
    }

    /*
	public void LoadScene(){
		SceneManager.LoadScene (Scene);
	}
    */
}
