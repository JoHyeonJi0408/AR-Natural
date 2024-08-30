using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WhatMaps : MonoBehaviour
{
    public Text mapName;

    public GameObject tropical;
    public GameObject desert;
    public GameObject antarctica;
    public GameObject fox;
    private Vector3 foxPos;
    private Vector3 foxRot;

    private string whatVideo;

    // playbtn 클릭
    public void whatMaps()
    {
        whatVideo = mapName.text;
        switch (whatVideo)
        {
            case "TropicalRainforestVideo":
                tropical.SetActive(true);
                foxPos = new Vector3(0.2812f, 0.0013f, -0.4628f);
                foxRot = new Vector3(0f, -299.583f, 0f);
                break;
            case "DesertVideo":
                desert.SetActive(true);
                foxPos = new Vector3(0.23f, 0.0013f, -0.3394f);
                foxRot = new Vector3(0.01f, 0.01f, 0.01f);
                break;
            case "AntarcticaVideo":
                antarctica.SetActive(true);
                foxPos = new Vector3(0.2324f, 0.0013f, -0.5894f);
                foxRot = new Vector3(0.0f, -409.9f, 0.0f);
                break;
        }
        fox.transform.position = foxPos;
        fox.transform.rotation = Quaternion.Euler(foxRot);
    }
}
