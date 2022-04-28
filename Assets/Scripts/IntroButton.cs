using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroButton : MonoBehaviour
{

    public void OnClcikExit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
       if (Input.GetMouseButtonDown(1) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Application.Quit();
        }
#endif
    }

    void Start()
    {
        
    }

    void Update()
    {
       
    }
}
