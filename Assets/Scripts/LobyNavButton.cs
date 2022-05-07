using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LobyNavButton : MonoBehaviour
{
    private bool StartBtn;
    private bool ChaptBtn;
    private bool EndBtn;
    private GameObject ButtonOnOff;
    private GameObject EndOnOff;

    public void OnClickButton()
    {
        if (StartBtn == true)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                editBtnValue(false, true, false);
               /* StartBtn = false;
                ChaptBtn = true;
                EndBtn = false;*/
                Debug.Log("시작에서챕터");
            }
        }else if(ChaptBtn == true)
            {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                editBtnValue(false, false, true);
     /*           StartBtn = false;
                ChaptBtn = false;
                EndBtn = true;*/
                Debug.Log("챕터에서종료");
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                editBtnValue(true, false, false);
     /*           StartBtn = true;
                ChaptBtn = false;
                EndBtn = false;*/
                Debug.Log("챕터에서시작");
            }
        }
        else if(EndBtn == true)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                editBtnValue(false, true, false);
                //StartBtn = false;
                //ChaptBtn = true;
                //EndBtn = false;
                Debug.Log("종료에서챕터");
            }
        }



        if(Input.GetKeyDown(KeyCode.Return))
        {
            if(StartBtn == true)
            {

            }
            else if (ChaptBtn == true)
            {

            }
            else if (EndBtn == true)
            {
                EndOnOff.SetActive(true);
                ButtonOnOff.SetActive(false);
            }
        }
        if(EndOnOff.activeSelf == true)
        {
            if(Input.GetKeyDown(KeyCode.Return))
            {
                Debug.Log(" 흠");
            }
        }
    }

    private void editBtnValue(bool vSBtn, bool vCBtn, bool vEBtn) // 버튼값변경 함수
    {
        StartBtn = vSBtn;
        ChaptBtn = vCBtn;
        EndBtn = vEBtn;
    }


    void Start()
    {
        StartBtn = GameObject.Find("StartButton");
        ChaptBtn = GameObject.Find("ChapterButton");
        EndBtn = GameObject.Find("EndButton");
        StartBtn = true;
        ChaptBtn = false;
        EndBtn = false;
        ButtonOnOff = GameObject.Find("ButtonCanvas");
        EndOnOff = GameObject.Find("EndTextCanvas");
        EndOnOff.SetActive(false);
    }

    void Update()
    {
        OnClickButton();
    }
}
