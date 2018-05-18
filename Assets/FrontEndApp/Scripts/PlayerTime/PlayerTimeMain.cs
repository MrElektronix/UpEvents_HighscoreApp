using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTimeMain : MonoBehaviour {
    public GetTime getTime;
    //public Button saveTime;

    public void StartMain()
    {
        getTime.CheckTime(60, 60);
    }

}
