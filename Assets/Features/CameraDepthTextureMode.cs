using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDepthTextureMode : MonoBehaviour
{
    public DepthTextureMode mode;
    public Camera cameraMain;


    private void OnValidate()
    {
        SetCameraDepthTextureMode();
    }

    private void Awake()
    {
        SetCameraDepthTextureMode();
    }
    private void SetCameraDepthTextureMode()
    {
       cameraMain.depthTextureMode = mode;
    }
}
