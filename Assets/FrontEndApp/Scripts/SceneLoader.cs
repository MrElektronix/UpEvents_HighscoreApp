using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour {
	public int Scene;

	public void OnClick(){
            StartCoroutine(WaitForCertainSeconds(0.4f));
    }

    IEnumerator WaitForCertainSeconds(float secToWait)
    {
        yield return new WaitForSeconds(secToWait);
        SceneManager.LoadScene(Scene);
    }
}
