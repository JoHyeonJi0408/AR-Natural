using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleChange : MonoBehaviour
{
    public Text Titlestr;
    public void playTitle()
    {
        Titlestr.text = "숨겨진 문제를 찾아보세요.";
    }
    public void endTitle()
    {
        Titlestr.text = "모든 문제를 푸셨습니다.";
    }
}
