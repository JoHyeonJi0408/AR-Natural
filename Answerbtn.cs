using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answerbtn : MonoBehaviour
{
    public GameObject obtn;
    public GameObject xbtn;
    public GameObject background;
    public GameObject Rightans;
    public GameObject Wrongans;
    public GameObject Explanation;
    public GameObject Result; // 결과창
    public Text Explanationstr;
    public Text counttxt;
    public Text mapname;
    public Text Finishstr;

    public string answer;
    public string str;

    public bool restart = false;

    private int number = 0; //맞춘 수
    private int count = 0; // 문제 3번 이후 결과창
    // Start is called before the first frame update

    public void obtnClick()
    {
        // 정답
        if (answer == "O")
        {
            number++;
            obtn.SetActive(false);
            xbtn.SetActive(false);
            background.SetActive(true);
            Rightans.SetActive(true);
            Invoke("RightansOff", 1f);
            Invoke("BackgroundOff", 1f);
            if (!restart)
            {
                GameObject.Find("Titletxt").GetComponent<TitleChange>().playTitle();
                counttxt.text = number.ToString();
            }
            else
            {
                switch (mapname.text)
                {
                    case "TropicalRainforestVideo":
                        Invoke("tQuiz", 1f);
                        break;
                    case "DesertVideo":
                        Invoke("dQuiz", 1f);
                        break;
                    case "AntarcticaVideo":
                        Invoke("aQuiz", 1f);
                        break;
                }
            }
        } //오답
        else
        {
            Explanationstr.text = str;
            obtn.SetActive(false);
            xbtn.SetActive(false);
            background.SetActive(true);
            Wrongans.SetActive(true);
            Explanation.SetActive(true);
            Invoke("WrongansOff", 2f);
            Invoke("ExplanationOff", 2f);
            Invoke("BackgroundOff", 2f);
            if (!restart)
            {
                GameObject.Find("Titletxt").GetComponent<TitleChange>().playTitle();
            }
            else
            {
                switch (mapname.text)
                {
                    case "TropicalRainforestVideo":
                        Invoke("tQuiz", 2f);
                        break;
                    case "DesertVideo":
                        Invoke("dQuiz", 2f);
                        break;
                    case "AntarcticaVideo":
                        Invoke("aQuiz", 2f);
                        break;
                }
            }
        }
        count++;
        if (count == 3)
        {
            Invoke("resultWindow", 3f);
        }
    }

    public void xbtnClick()
    {
        // 정답
        if (answer == "X")
        {
            number++;
            obtn.SetActive(false);
            xbtn.SetActive(false);
            background.SetActive(true);
            Rightans.SetActive(true);
            Invoke("RightansOff", 1f);
            Invoke("BackgroundOff", 1f);
            if (!restart)
            {
                GameObject.Find("Titletxt").GetComponent<TitleChange>().playTitle();
                counttxt.text = number.ToString();
            }
            else
            {
                switch (mapname.text)
                {
                    case "TropicalRainforestVideo":
                        Invoke("tQuiz", 1f);
                        break;
                    case "DesertVideo":
                        Invoke("dQuiz", 1f);
                        break;
                    case "AntarcticaVideo":
                        Invoke("aQuiz", 1f);
                        break;
                }
            }
        } //오답
        else
        {
            Explanationstr.text = str;
            obtn.SetActive(false);
            xbtn.SetActive(false);
            background.SetActive(true);
            Wrongans.SetActive(true);
            Explanation.SetActive(true);
            Invoke("WrongansOff", 2f);
            Invoke("ExplanationOff", 2f);
            Invoke("BackgroundOff", 2f);
            if (!restart)
            {
                GameObject.Find("Titletxt").GetComponent<TitleChange>().playTitle();
            }
            else
            {
                switch (mapname.text)
                {
                    case "TropicalRainforestVideo":
                        Invoke("tQuiz", 2f);
                        break;
                    case "DesertVideo":
                        Invoke("dQuiz",2f);
                        break;
                    case "AntarcticaVideo":
                        Invoke("aQuiz", 2f);
                        break;
                }
            }
        }
        count++;
        if (count == 3)
        {
            Invoke("resultWindow", 3f);
        }
    }

    void RightansOff()
    {
        Rightans.SetActive(false);
    }
    void WrongansOff()
    {
        Wrongans.SetActive(false);
    }

    void ExplanationOff()
    {
        Explanation.SetActive(false);
    }

    void BackgroundOff()
    {
        background.SetActive(false);
    }

    void tQuiz()
    {
        GameObject.Find("Fox").GetComponent<Fox>().TropicalQuizing();
    }

    void dQuiz()
    {
        GameObject.Find("Fox").GetComponent<Fox>().DesertQuizing();
    }

    void aQuiz()
    {
        GameObject.Find("Fox").GetComponent<Fox>().AntarcticaQuizing();
    }

    void resultWindow()
    {
        Result.SetActive(true);
        switch (number)
        {
            case 3:
                Finishstr.text = "모든 문제를 맞추셨습니다!";
                break;
            case 2:
                Finishstr.text = "아쉽게 한 문제 틀렸어요~";
                break;
            case 1:
                Finishstr.text = "한 문제라도 맞췄네요^^*";
                break;
            case 0:
                Finishstr.text = "하나도 못 맞췄어요!!!분발해요~";
                break;
        }
    }
}
