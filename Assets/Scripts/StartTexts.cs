using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartTexts : MonoBehaviour
{
    public TextEditSc textEditSc;

    public void PrintTextEditSc()
    {
        Debug.Log("�ؽ�Ʈ �̸� :: " + textEditSc.TextName);
        Debug.Log("�ؽ�Ʈ ���� :: " + textEditSc.StartTexts);
    }

}
