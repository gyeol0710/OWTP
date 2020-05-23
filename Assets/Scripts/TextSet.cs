using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TextSet : MonoBehaviour
{
    static int msgnumber;

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
        Scrollbar scrbar = MessageManager.ScrBar.GetComponent<Scrollbar>();
        string subtext = MessageManager.MSGtext;
        int n;
        int Length = subtext.Length;
        for (n = 0; n < Length; n++)
        {
            scrbar.value = 0;

            text.text += subtext[n];
            yield return new WaitForSeconds(0.03f);
        }
        yield return new WaitForSeconds(0.5f);
        MessageManager.gomsg = true;

        StopCoroutine(TextAnim());
    }
}
