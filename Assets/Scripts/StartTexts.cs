using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartTexts : MonoBehaviour
{
    public TextEditSc textEditSc;

    public void PrintTextEditSc()
    {
        Debug.Log("텍스트 이름 :: " + textEditSc.TextName);
        Debug.Log("텍스트 종류 :: " + textEditSc.StartTexts);
    }

}
