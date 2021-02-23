using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fox : MonoBehaviour
{
    public Text Title;
    public Text mapName;
    public GameObject obtn;
    public GameObject xbtn;
    public bool restart = false;

    private int t_number = 0;
    private int d_number = 0;
    private int a_number = 0;
   
    // 사막 추가 퀴즈 
    public void DesertQuizing()
    {
        if(d_number < 2)
        {

            Title.text = DesertQuiz(d_number);
            obtn.SetActive(true); // o,x 버튼 활성화
            xbtn.SetActive(true);
            GameObject.Find("Grading").GetComponent<Answerbtn>().answer = DesertAnswer(d_number);
            GameObject.Find("Grading").GetComponent<Answerbtn>().str = DesertExplanation(d_number);
            d_number++;
        }
        else
        {
            GameObject.Find("Titletxt").GetComponent<TitleChange>().endTitle();
        }
    }

    // 열대우림 추가 퀴즈

    public void TropicalQuizing()
    {
        if (t_number < 3)
        {

            Title.text = TropicalQuiz(t_number);
            obtn.SetActive(true); // o,x 버튼 활성화
            xbtn.SetActive(true);
            GameObject.Find("Grading").GetComponent<Answerbtn>().answer = TropicalAnswer(t_number);
            GameObject.Find("Grading").GetComponent<Answerbtn>().str = TropicalExplanation(t_number);
            t_number++;
        }
        else
        {
            GameObject.Find("Titletxt").GetComponent<TitleChange>().endTitle();
        }
    }

    // 남극 추가 퀴즈
    public void AntarcticaQuizing()
    {
        if (a_number < 3)
        {

            Title.text = AntarcticaQuiz(a_number);
            obtn.SetActive(true); // o,x 버튼 활성화
            xbtn.SetActive(true);
            GameObject.Find("Grading").GetComponent<Answerbtn>().answer = AntarcticaAnswer(a_number); 
            GameObject.Find("Grading").GetComponent<Answerbtn>().str = AntarcticaExplanation(a_number);
            a_number++;
        }
        else
        {
            GameObject.Find("Titletxt").GetComponent<TitleChange>().endTitle();
        }
    }

    // 맵에 숨겨진 문제
    private void OnTriggerEnter(Collider c)
    {
        if(c.tag == "DesertQ1")
        {
            Title.text = "건조 기후는 비가 안 온다";
            obtn.SetActive(true);
            xbtn.SetActive(true);
            GameObject.Find("Grading").GetComponent<Answerbtn>().answer = "X";
            GameObject.Find("Grading").GetComponent<Answerbtn>().str = "사막기후는 비가 거의 안 오지만 스텝기후는 조금이라도 온다";
            Destroy(c.gameObject);
        }

        if (c.tag == "DesertQ2")
        {
            Title.text = "사막은 덥기 때문에 짧고 얇은 옷을 입는다";
            obtn.SetActive(true);
            xbtn.SetActive(true);
            GameObject.Find("Grading").GetComponent<Answerbtn>().answer = "X";
            GameObject.Find("Grading").GetComponent<Answerbtn>().str = "햇빛이 뜨거워 길고 얇은 옷을 입는다";
            Destroy(c.gameObject);
        }

        if (c.tag == "DesertQ3")
        {
            Title.text = "사막에서 밀과 목화 농사를 짓는다";
            obtn.SetActive(true);
            xbtn.SetActive(true);
            GameObject.Find("Grading").GetComponent<Answerbtn>().answer = "O";
            GameObject.Find("Grading").GetComponent<Answerbtn>().str = "";
            Destroy(c.gameObject);
        }

        if (c.tag == "TropicalQ1")
        {
            Title.text = "열대 우림은 적도 주변에 있다";
            obtn.SetActive(true);
            xbtn.SetActive(true);
            GameObject.Find("Grading").GetComponent<Answerbtn>().answer = "O";
            GameObject.Find("Grading").GetComponent<Answerbtn>().str = "";
            Destroy(c.gameObject);
        }

        if (c.tag == "TropicalQ2")
        {
            Title.text = "열대 기후는 1년 내내 기온 30도를 넘는다";
            obtn.SetActive(true);
            xbtn.SetActive(true);
            GameObject.Find("Grading").GetComponent<Answerbtn>().answer = "O";
            GameObject.Find("Grading").GetComponent<Answerbtn>().str = "";
            Destroy(c.gameObject);
        }

        if (c.tag == "TropicalQ3")
        {
            Title.text = "열대 기후는 여름에만 집중적으로 비가 온다";
            obtn.SetActive(true);
            xbtn.SetActive(true);
            GameObject.Find("Grading").GetComponent<Answerbtn>().answer = "X";
            GameObject.Find("Grading").GetComponent<Answerbtn>().str = "열대 기후는 1년 내내 비가 온다.";
            Destroy(c.gameObject);
        }

        if(c.tag == "AntarQ1")
        {
            Title.text = "냉대 기후의 평균 일일 기온은 영하 4도다";
            obtn.SetActive(true);
            xbtn.SetActive(true);
            GameObject.Find("Grading").GetComponent<Answerbtn>().answer = "X";
            GameObject.Find("Grading").GetComponent<Answerbtn>().str = "평균 일일 기온은 영상 4도다.";
            Destroy(c.gameObject);
        }

        if (c.tag == "AntarQ2")
        {
            Title.text = "냉대 습윤기후는 일년 내내 비가 고르게 온다";
            obtn.SetActive(true);
            xbtn.SetActive(true);
            GameObject.Find("Grading").GetComponent<Answerbtn>().answer = "O";
            GameObject.Find("Grading").GetComponent<Answerbtn>().str = "";
            Destroy(c.gameObject);
        }

        if (c.tag == "AntarQ3")
        {
            Title.text = "캐나다, 알래스카, 홋카이도는 냉대 습윤 기후이다";
            obtn.SetActive(true);
            xbtn.SetActive(true);
            GameObject.Find("Grading").GetComponent<Answerbtn>().answer = "O";
            GameObject.Find("Grading").GetComponent<Answerbtn>().str = "";
            Destroy(c.gameObject);
        }
    }

    // 사막 추가 퀴즈
    public string DesertQuiz(int n)
    {
        string[] d_Quizzes = new string[2];
        d_Quizzes[0] = "사막에서는 주변에서 구한 흙벽돌로 집을 짓는다";
        d_Quizzes[1] = "사막에서는 비가 안 와서 집을 평평하게 짓는다";
        return d_Quizzes[n];
    }
    public string DesertAnswer(int n)
    {
        string[] d_Answers = new string[2];
        d_Answers[0] = "O";
        d_Answers[1] = "O";
        return d_Answers[n];
    }
    public string DesertExplanation(int n)
    {
        string[] d_Explanations = new string[2];
        d_Explanations[0] = "";
        d_Explanations[1] = "";
        return d_Explanations[n];
    }

    // 열대우림  추가 퀴즈
    public string TropicalQuiz(int n)
    {
        string[] t_Quizzes = new string[3];
        t_Quizzes[0] = "열대 우림에서 내리는 비 이름은 스텝이다";
        t_Quizzes[1] = "열대 기후에서는 얇고 긴 옷을 입는다";
        t_Quizzes[2] = "열대 기후는 튀김과 향신료를 즐긴다";
        return t_Quizzes[n];

    }

    public string TropicalAnswer(int n)
    {
        string[] t_Answers = new string[3];
        t_Answers[0] = "X";
        t_Answers[1] = "X";
        t_Answers[2] = "O";
        return t_Answers[n];
    }

    public string TropicalExplanation(int n)
    {
        string[] t_Explanations = new string[3];
        t_Explanations[0] = "비의 이름은 스콜이다";
        t_Explanations[1] = "얇고 짧은 옷을 입는다";
        t_Explanations[2] = "";
        return t_Explanations[n];
    }

    // 남극  추가 퀴즈
    public string AntarcticaQuiz(int n)
    {
        string[] a_Quizzes = new string[3];
        a_Quizzes[0] = "타이가 숲은 활엽수로 이루어져 있다";
        a_Quizzes[1] = "비가 여름에 집중되는 기후를 냉대동계건조기후라 한다";
        a_Quizzes[2] = "고지지중해성기후는 겨울에 건조하다";
        return a_Quizzes[n];

    }

    public string AntarcticaAnswer(int n)
    {
        string[] a_Answers = new string[3];
        a_Answers[0] = "X";
        a_Answers[1] = "O";
        a_Answers[2] = "X";
        return a_Answers[n];
    }

    public string AntarcticaExplanation(int n)
    {
        string[] a_Explanations = new string[3];
        a_Explanations[0] = "타이가 숲은 침엽수로 이루어져 있다";
        a_Explanations[1] = "";
        a_Explanations[2] = "여름에 건조하다";
        return a_Explanations[n];
    }
}
