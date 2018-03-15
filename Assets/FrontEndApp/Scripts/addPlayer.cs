using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addPlayer : MonoBehaviour {
	
	public GameObject go;
	[SerializeField]
	private int i;
	private int i2;

	Canvas canvas;
	RectTransform _rect;
	RectTransform _rect2;




	[SerializeField]
	List <GameObject> _panels = new List<GameObject>();
	List <GameObject> _panels2 = new List<GameObject>();
	int y = 160;
	[SerializeField]
	private GameObject _canvas;
	
	void Update () {
		/*
		if(Input.GetKeyDown(KeyCode.Space)){
			_panels.Add(Instantiate (go,new Vector3(x, y, z) , Quaternion.identity));
			_rect = _panels[i].GetComponent<RectTransform> ();
			_rect.anchoredPosition = new Vector2 (_rect.anchoredPosition.x, y);
			_panels[i].transform.SetParent(_canvas.transform,false);
			i++;
			y -= 89;
		}
		*/

	}

	public void DeleteInList(){
		if (this.gameObject.tag == "AddTeamButton1") {
			_panels.Remove(go);
			y += 89;
		} else {
			_panels.Remove(go);
			y+=89;
		}
	}
	public void OnClick(){
		
		//		_panels [i].transform.position = ;

		if(this.gameObject.tag == "AddTeamButton1"){
			_panels.Add(Instantiate (go,new Vector3(0, 0, 0) , Quaternion.identity));
			_rect = _panels[i].GetComponent<RectTransform> ();
			_rect.anchoredPosition = new Vector2 (_rect.anchoredPosition.x, y);
			_panels[i].transform.SetParent(_canvas.transform,false);
			i++;
			y -= 89;	
			
		}else if(this.gameObject.tag == "AddTeamButton2"){
			_panels2.Add(Instantiate (go,new Vector3(0, 0, 0) , Quaternion.identity));
			_rect2 = _panels2[i2].GetComponent<RectTransform> ();
			_rect2.anchoredPosition = new Vector2 (652.1443F, y);
			_panels2[i2].transform.SetParent(_canvas.transform,false);
			i2++;
			y -= 89;
		}

		Debug.Log(_panels.Count);

		//_spawn.LocationChange ();

	}

}
