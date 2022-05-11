using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LobyPass : MonoBehaviour
{
    private GameObject OnOffControll;
    private GameObject OnOfftwo;
    private GameObject OnOffBeel;
    private GameObject OnOffButton;

    public void TextOnOffControll()
    {

        if (OnOffControll.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                {
                    OnOfftwo.gameObject.SetActive(true);
                    OnOffBeel.gameObject.SetActive(true);
                    OnOffControll.gameObject.SetActive(false);

                    Debug.Log("∏ÿ√Á");
                }
            }
        }
        else if (OnOfftwo.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                {
                    OnOfftwo.SetActive(false);
                    OnOffControll.SetActive(false);
                    OnOffButton.SetActive(true);
                    Debug.Log("≥—±‚¿⁄");
                }
            }
        }
    }


    void Start()
    {
        OnOffControll = GameObject.Find("TextCanvas");
        OnOfftwo = GameObject.Find("TextCanvastwo");
        OnOffBeel = GameObject.Find("BeelCanvas");
        OnOffControll.SetActive(true);
        OnOfftwo.SetActive(false);
        OnOffBeel.SetActive(false);
        OnOffButton = GameObject.Find("ButtonCanvas");
        OnOffButton.SetActive(false);
    }

    void Update()
    {
        TextOnOffControll();
    }
}
