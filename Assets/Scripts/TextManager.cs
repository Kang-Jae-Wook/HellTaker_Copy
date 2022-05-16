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
        TextDatas.Add(10, new string[] { "�� ������Ŀ�� �̾߱⸦ ����޶��? ����ֱ�..." , "Ȥ�� �ؼ��ڰ� �ʿ����� ������?" , "������شٸ� �� ���ھ�" , 
                                         "����� ����� �Ǹ���� ������ �Ϸ���\n�޲ٰ� �Ͼ��." , "������ ���� �̷�� ���� ���� ������.\n��¼�� �� ����� �Ѿư����� �𸣰�." ,
                                         "�Ǹ� �Ϸ��� �޷ȴٸ�,�� � �밡�� ����.\n�׸��Ͽ� ����� �������� ������ ������." });
        TextDatas.Add(20, new string[] { });
        TextDatas.Add(30, new string[] { "���� �� ���� �õ� �غ����� ���� ����� ������ ���� ����." });

    }

    public string GetText(int id, int textIndex)
    {
        return TextDatas[id][textIndex];
    }

}
