using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCode : MonoBehaviour
{
    void Start()
    {
        /*
        if (GameManager.RePlay == false)
        {
        }
        else
        {
            LoadingManager.LoadScene("MainScene");
        }
        */
        LoadingManager.LoadScene("MainScene");
    }

    void Update()
    {
        
    }
}
