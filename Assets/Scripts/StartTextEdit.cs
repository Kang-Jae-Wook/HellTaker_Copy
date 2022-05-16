using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StartTextType { TName , Text }

public class StartTextEdit : MonoBehaviour
{
    [SerializeField] private List<StartTextType> textTypes;
    [SerializeField] private GameObject textPrefeb;

    private void Start()
    {
        
    }

    public StartTexts EditStartText(StartTextType type)
    {
        var newStartText = Instantiate(textPrefeb).GetComponent<StartTexts>();
        newStartText.textTypes = textTypes[(int)type];



    }
  








}
