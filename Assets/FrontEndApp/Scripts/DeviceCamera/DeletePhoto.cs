using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePhoto : MonoBehaviour
{
    public TakePhoto userCamera;

    public void OnClick()
    {
        userCamera.DeletePhoto();
    }
}
