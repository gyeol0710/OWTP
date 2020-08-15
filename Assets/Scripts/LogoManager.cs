using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogoManager : MonoBehaviour
{
    public Image Logo;

    void Start()
    {
        Logo.color = new Color32(255, 255, 255, 0);
        StartCoroutine(Logo_Fade());
    }

    void Update()
    {
        
    }

    IEnumerator Logo_Fade()
    {
        short i = 0;
        while(true)
        {
            Logo.color += new Color32(255, 255, 255, 10);
            i++;
            if(i > 50)
            {
                if (GameManager.RePlay == false)
                {
                    LoadingManager.LoadScene("Intro");
                }
                else
                {
                    LoadingManager.LoadScene("MainScene");
                }

                yield break;
            }
            yield return new WaitForSeconds(0.02f);
        }
    }
}
