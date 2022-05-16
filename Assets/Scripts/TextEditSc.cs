using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Text EditSc", menuName = "Scriptable Object/Text EidtSc", order = int.MaxValue)]

public class TextEditSc : ScriptableObject
{
    [SerializeField] private string textName;
    public string TextName { get { return TextName; } }

    [SerializeField] private Text startTexts;
    public Text StartTexts { get { return startTexts; } }


}
