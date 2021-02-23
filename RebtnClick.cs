using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RebtnClick : MonoBehaviour
{
    public GameObject Result;
    public GameObject Count1;
    public GameObject Count2;
    public GameObject endbtn;
    public Text mapname;

    public void reStart()
    {
        Result.SetActive(false); // 결과창 닫고
        Count1.SetActive(false);
        Count2.SetActive(false);
        GameObject.Find("Grading").GetComponent<Answerbtn>().restart = true;
        // 문제 시작
        endbtn.SetActive(true);
        switch (mapname.text)
        {
            case "TropicalRainforestVideo":
                GameObject.Find("Fox").GetComponent<Fox>().TropicalQuizing(); // 퀴즈 종류 바꾸기
                break;
            case "DesertVideo":
                GameObject.Find("Fox").GetComponent<Fox>().DesertQuizing();
                break;
            case "AntarcticaVideo":
                GameObject.Find("Fox").GetComponent<Fox>().AntarcticaQuizing();
                break;
        }
    }

    public void endApplication()
    {
        Application.Quit();
    }
}
