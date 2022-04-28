using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroAnima : MonoBehaviour
{
    public Animator IntroS;

    private void Update()
    {

        if(IntroS.GetCurrentAnimatorStateInfo(0).IsName("Base Layer.StartChangeAnime") && IntroS.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1f)
        {
            
            SceneManager.LoadScene("LobyScene");
        }
    }
}
