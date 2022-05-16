using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    Dictionary<int, string[]> TextDatas;

    private void Awake()
    {
        TextDatas = new Dictionary<int, string[]>();
        GenerateData();
    }

    void GenerateData()
    {
        TextDatas.Add(10, new string[] { "또 헬테이커의 이야기를 들려달라고? 재미있군..." , "혹시 해설자가 필요하진 않은가?" , "허락해준다면 참 고맙겠어" , 
                                         "어느날 당신은 악마들로 가득찬 하렘을\n꿈꾸고 일어났네." , "하지만 결코 이루기 쉽지 않은 꿈이지.\n어쩌면 네 목숨을 앗아갈지도 모르고." ,
                                         "악마 하렘이 달렸다면,그 어떤 대가도 싸지.\n그리하여 당신은 지옥으로 모험을 떠났네." });
        TextDatas.Add(20, new string[] { });
        TextDatas.Add(30, new string[] { "나도 수 없이 시도 해봤지만 아직 제대로 성공한 적이 없지." });

    }

    public string GetText(int id, int textIndex)
    {
        return TextDatas[id][textIndex];
    }

}
