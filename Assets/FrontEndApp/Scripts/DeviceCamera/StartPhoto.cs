using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPhoto : MonoBehaviour
{
    public TakePhoto userCamera;

    public void OnClick()
    {
        userCamera.Timer();
    }
}
