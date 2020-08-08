using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCode : MonoBehaviour
{
    void Start()
    {
        if (GameManager.RePlay == false)
        {
            LoadingManager.LoadScene("Intro");
        }
        else
        {
            LoadingManager.LoadScene("MainScene");
        }
    }

    void Update()
    {
        
    }
}
