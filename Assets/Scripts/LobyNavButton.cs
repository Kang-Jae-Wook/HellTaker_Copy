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
    private GameObject BeelImg;
    private GameObject StartTexts;
    private GameObject StartImg;
    private GameObject StartBack;

    private void OnClickButton()
    {
        if (StartBtn == true)
        {
            ButtonOnOff = GameObject.Find("ButtonCanvas");
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                editBtnValue(false, true, false);
               /* StartBtn = false;
                ChaptBtn = true;
                EndBtn = false;*/
                Debug.Log("���ۿ���é��");
            }
        }
        else if(ChaptBtn == true)
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
            if (Input.GetKeyDown(KeyCode.Return))
            {
                EndOnOff.SetActive(true);
                ButtonOnOff.SetActive(false);
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
        StartTexts = GameObject.Find("StartReTextCanvas");  //  ��ŸƮ��ư ĵ����
        StartImg = GameObject.Find("StartImg1Can");
        StartBack = GameObject.Find("StIBackCanvas");
        EndOnOff.SetActive(false);
        StartTexts.SetActive(false);
        StartImg.SetActive(false);
        StartBack.SetActive(false);
        StartBtn = true;
        ChaptBtn = false;
        EndBtn = false;
    }

    void Update()
    {
        OnClickButton();
    }
}
