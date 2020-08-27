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

    static public bool P03;
    static public bool P03c;

    static public bool T06;
    static public bool T06c;
    static public bool T07;
    static public bool T07c;

    static public bool P04;
    static public bool P04c;

    static public bool T08;
    static public bool T08c;
    static public bool T09;
    static public bool T09c;

    static public bool TutoAllClear; // 튜토리얼 최종 완료 변수
    public Button Click;
    public Button Robot;
    public Button Product;
    public Button Tech;
    public Button Offer;


    void Start()
    {
        if (TutoAllClear == true)
        {
            passiveLoad();
            Destroy(this);
        }
        if (TutoAllClear == false)
        {
            Click.interactable = false;
            Robot.interactable = false;
            Product.interactable = false;
            Tech.interactable = false;
            Offer.interactable = false;



            T01 = true;
        }

        StartCoroutine(Tutorial());
    }

    void Update()
    {
        
    }

    void Tutorial01()
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

        if (T04c == true)
        {
            Offer.interactable = true;
            Robot.interactable = true;
        }

        if (GameManager.robotLevel > 0)
        {
            P01 = true;
        }

        if (GameManager.robotLevel > 4)
        {
            T05 = true;
            Tech.interactable = true;
        }

        if (GameManager.science >= TechManager.Tech1)
        {
            P02 = true;
        }

        if (P02c == true)
        {
            P03 = true;
        }

        if (TechManager.Tech1Complete == true)
        {
            T06 = true;
        }

        if (T06c == true)
        {
            T07 = true;
        }

        if (T07c == true)
        {
            P04 = true;
            Product.interactable = true;
        }

        if (ProductManager.Prod_1_Level > 0)
        {
            T08 = true;
        }

        if (T08c == true)
        {
            T09 = true;
        }
    }

    IEnumerator Tutorial()
    {
        while(true)
        {
            Tutorial01();
            yield return new WaitForSeconds(0.1f);
        }
    }

    void passiveLoad()
    {
        if (T02c == true)
        {
            Click.interactable = true;
        }

        if (T04c == true)
        {
            Offer.interactable = true;
            Robot.interactable = true;
        }

        if (T05 == true)
        {
            T05 = true;
            Tech.interactable = true;
        }

        if (T07c == true)
        {
            Product.interactable = true;
        }
    }
}
