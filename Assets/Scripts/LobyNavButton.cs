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
    private GameObject ImgSet;
    private GameObject StartTexts;

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
                ButtonOnOff = GameObject.Find("ButtonCanvas");      //  버튼포함캔버스
                ButtonOnOff.SetActive(false);
                EndOnOff.SetActive(true);
                Application.Quit();
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
        StartBtn = GameObject.Find("StartButton");          //  시작버튼
        ChaptBtn = GameObject.Find("ChapterButton");        //  챕터버튼
        EndBtn = GameObject.Find("EndButton");              //  종료버튼
        EndOnOff = GameObject.Find("EndTextCanvas");        //  종료클릭시 텍스트 캔버스
        ImgSet = GameObject.Find("ImgSet");                 //  이미지총캔버스 (수정필요)
        StartTexts = GameObject.Find("StartReTextCanvas");  //  스타트버튼 캔버스
        EndOnOff.SetActive(false);
        ImgSet.SetActive(false);
        StartTexts.SetActive(false);
        StartBtn = true;
        ChaptBtn = false;
        EndBtn = false;
    }

    void Update()
    {
        OnClickButton();
    }
}
