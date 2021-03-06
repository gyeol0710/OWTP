﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class JokeSet : MonoBehaviour
{
    void Start()
    {
        Text text = GetComponent<Text>();
        StartCoroutine(TextAnim());
    }

    void Update()
    {

    }

    IEnumerator TextAnim()
    {
        Text text = GetComponent<Text>();
        string subtext = MessageManager.JOKEtext;
        int n;
        int Length = subtext.Length;
        for (n = 0; n < Length; n++)
        {
            if (n == 1)
            {
                MessageManager.ScrBar.value = 0;
            }
            text.text += subtext[n];
            yield return new WaitForSeconds(0.03f);
        }
        yield return new WaitForSeconds(0.5f);
        MessageManager.gojokemsg2 = false;

        yield break;
    }
}
