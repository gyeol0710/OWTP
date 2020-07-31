﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LineSet : MonoBehaviour
{
    Image image;
    int n;

    void Start()
    {
        image = GetComponent<Image>();
        n = 0;
        StartCoroutine(LineAnim());
    }

    void Update()
    {

    }

    IEnumerator LineAnim()
    {
        Scrollbar scrbar = MessageManager.ScrBar.GetComponent<Scrollbar>();
        while (true)
        {
            if(n == 150)
            {
                break;
            }
            scrbar.value = 0;

            image.color = new Color(image.color.r, image.color.g, image.color.b, image.color.a + 0.01f);
            yield return new WaitForSeconds(0.01f);
            n++;
        }
        yield break;
    }
}
