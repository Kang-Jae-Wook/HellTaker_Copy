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
                Debug.Log("���ۿ���é��");
            }
        }else if(ChaptBtn == true)
            {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                editBtnValue(false, false, true);
     /*           StartBtn = false;
                ChaptBtn = false;
                EndBtn = true;*/
                Debug.Log("é�Ϳ�������");
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                editBtnValue(true, false, false);
     /*           StartBtn = true;
                ChaptBtn = false;
                EndBtn = false;*/
                Debug.Log("é�Ϳ�������");
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
                Debug.Log("���ῡ��é��");
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
                ButtonOnOff = GameObject.Find("ButtonCanvas");      //  ��ư����ĵ����
                ButtonOnOff.SetActive(false);
                EndOnOff.SetActive(true);
                Application.Quit();
            }
        }
    }

    private void editBtnValue(bool vSBtn, bool vCBtn, bool vEBtn) // ��ư������ �Լ�
    {
        StartBtn = vSBtn;
        ChaptBtn = vCBtn;
        EndBtn = vEBtn;
    }


    void Start()
    { 
        StartBtn = GameObject.Find("StartButton");          //  ���۹�ư
        ChaptBtn = GameObject.Find("ChapterButton");        //  é�͹�ư
        EndBtn = GameObject.Find("EndButton");              //  �����ư
        EndOnOff = GameObject.Find("EndTextCanvas");        //  ����Ŭ���� �ؽ�Ʈ ĵ����
        ImgSet = GameObject.Find("ImgSet");                 //  �̹�����ĵ���� (�����ʿ�)
        StartTexts = GameObject.Find("StartReTextCanvas");  //  ��ŸƮ��ư ĵ����
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
