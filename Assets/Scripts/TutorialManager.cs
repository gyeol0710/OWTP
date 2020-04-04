using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TutorialManager : MonoBehaviour
{
    static public bool T01; // 대화창 변수
    static public bool T01c; // 대화창 클리어 변수
    static public bool T02;
    static public bool T02c;
    static public bool T03;
    static public bool T03c;
    static public bool T04;
    static public bool T04c;

    static public bool P01; // 푸시 변수
    static public bool P01c; // 푸시 클리어 변수

    static public bool T05;
    static public bool T05c;

    static public bool P02;
    static public bool P02c;

    static public bool T06;
    static public bool T06c;
    static public bool T07;
    static public bool T07c;
    static public bool T08;
    static public bool T08c;
    static public bool TutoAllClear; // 튜토리얼 최종 완료 변수
    public Button Click;
    public Button Robot;
    public Button Product;
    public Button Tech;



    void Start()
    {
        if (TutoAllClear == true)
        {
            Destroy(this);
        }
        if (TutoAllClear == false)
        {
            Click.interactable = false;
            Robot.interactable = false;
            Product.interactable = false;
            Tech.interactable = false;

            T01 = true;
        }
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

        if (T02c == true)
        {
            Click.interactable = true;
            T03 = true;
        }

        if (GameManager.money > 0)
        {
            T04 = true;
        }

        if (T04c ==true)
        {
            Robot.interactable = true;
        }

        if (GameManager.robotLevel > 0)
        {
            P01 = true;
        }

        if (GameManager.robotLevel > 4)
        {
            T05 = true;
        }

        if (GameManager.science >= TechManager.Tech001)
        {
            P02 = true;
        }

        if (P02c == true)
        {
            Tech.interactable = true;
        }
    }
}
