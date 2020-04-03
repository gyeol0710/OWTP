using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TutorialManager : MonoBehaviour
{
    static public bool T01;
    static public bool T01c;
    static public bool T02;
    static public bool T02c;
    static public bool T03;
    static public bool T03c;
    static public bool T04;
    static public bool T05;
    static public bool T06;
    static public bool T07;
    static public bool T08;

    void Start()
    {
        T01 = true;
    }

    void Update()
    {
        if (T02 == false)
        {
            if (T01c == true)
            {
                T02 = true;
            }
        }
    }
}
