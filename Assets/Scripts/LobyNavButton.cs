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
                StartBtn = false;
                ChaptBtn = true;
                EndBtn = false;
                Debug.Log("Ω√¿€ø°º≠√©≈Õ");
            }
        }else if(ChaptBtn == true)
            {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                    StartBtn = false;
                    ChaptBtn = false;
                    EndBtn = true;
                    Debug.Log("√©≈Õø°º≠¡æ∑·");
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                    StartBtn = true;
                    ChaptBtn = false;
                    EndBtn = false;
                    Debug.Log("√©≈Õø°º≠Ω√¿€");
            }
        }
        else if(EndBtn == true)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                StartBtn = false;
                ChaptBtn = true;
                EndBtn = false;
                Debug.Log("¡æ∑·ø°º≠√©≈Õ");
            }
        }
        else
        {

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
                Debug.Log(" »Ï");
            }
        }
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
