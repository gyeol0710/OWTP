﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MessageManager : MonoBehaviour
{
    static public string MSGtext;

    public GameObject prefabMessage;
    public GameObject prefabLine;
    public GameObject par;

    public GameObject Tip;
    public Text tipText;

    static public bool gomsg;

    void Start()
    {
        StartCoroutine(Message01());
    }

    void Update()
    {

    }

    IEnumerator Message01()
    {
        yield return StartCoroutine(Tuto(TutorialManager.T01)); // T01이 true이면 다음으로 진행 가능
        gomsg = true;
        if (TutorialManager.T01c == false)
        {
            /*
            yield return StartCoroutine(GoMessage("........."));
            yield return StartCoroutine(GoMessage("........."));
            yield return StartCoroutine(GoMessage("정신 차리세요."));
            yield return StartCoroutine(GoMessage("일단 우주선에 남은 연료가 적어서"));
            yield return StartCoroutine(GoMessage("불시착했습니다."));
            yield return StartCoroutine(GoMessage("XᴂP33S⧣⦹eDscx⦩ᜈ"));
            yield return StartCoroutine(GoMessage("어s어서fㅈjdwnddᅟᅵᆸ니다."));
            yield return StartCoroutine(GoMessage("언어설정완료."));
            yield return StartCoroutine(GoMessage("지역스캔완료."));
            yield return StartCoroutine(GoMessage("환경적응완료."));
            */
            yield return StartCoroutine(GoLine());
        }
        TutorialManager.T01c = true;

        yield return new WaitForSeconds(2.0f);

        yield return StartCoroutine(Tuto(TutorialManager.T02));

        if (TutorialManager.T02c == false)
        {
            gomsg = true;
            /*
            yield return StartCoroutine(GoMessage("흥미로운 별입니다."));
            yield return StartCoroutine(GoMessage("1000만종 가까운 생물들이 존재합니다."));
            yield return StartCoroutine(GoMessage("그 중에서도 사람이라는 생물의 면적이"));
            yield return StartCoroutine(GoMessage("가장 넓군요!"));
            yield return StartCoroutine(GoMessage("게다가 우리만 있는 게 아니네요."));
            yield return StartCoroutine(GoMessage("다른 은하에서 온 생물체들도 마음껏 이 환경을"));
            yield return StartCoroutine(GoMessage("꾸미고 있어요."));
            yield return StartCoroutine(GoMessage("일단 우리도 에너지를 한번 만들어 봅시다!"));
            */
            yield return StartCoroutine(GoLine());
        }
        TutorialManager.T02c = true;

        yield return new WaitForSeconds(2.0f);

        yield return StartCoroutine(Tuto(TutorialManager.T03));

        if (TutorialManager.T03c == false)
        {
            gomsg = true;
            /*
            yield return StartCoroutine(GoMessage("좋아요."));
            yield return StartCoroutine(GoMessage("우주선에 필요한 모든 부품을"));
            yield return StartCoroutine(GoMessage("우리가 캘 순 없으니 사람들이 이 행성에 있는"));
            yield return StartCoroutine(GoMessage("모든 요소들을 발견하게 만들면 되겠어요."));
            yield return StartCoroutine(GoMessage("자금을 만들어봅시다."));
            yield return StartCoroutine(GoLine());
            */
        }
        TutorialManager.T03c = true;

        yield return new WaitForSeconds(2.0f);

        while (true)
        {
            if (GameManager.money > 0)
            {
                break;
            }
            yield return null;
        }

        yield return new WaitForSeconds(0.1f); // 튜토리얼매니저 충돌방지

        yield return StartCoroutine(Tuto(TutorialManager.T04));

        if (TutorialManager.T04c == false)
        {
            gomsg = true;
            yield return StartCoroutine(GoMessage("좋아요,"));
            yield return StartCoroutine(GoMessage("기존에 있던 부품들로"));
            yield return StartCoroutine(GoMessage("직원들을 좀 만들어 봅시다."));
            yield return StartCoroutine(GoLine());
        }
        TutorialManager.T04c = true;

        yield return new WaitForSeconds(2.0f);

        while (true)
        {
            if (GameManager.robotLevel > 0)
            {
                break;
            }
            yield return null;
        }

        yield return new WaitForSeconds(0.1f); // 튜토리얼매니저 충돌방지

        yield return StartCoroutine(Tuto(TutorialManager.T05));

        if (TutorialManager.T05c == false)
        {
            GameManager.money += 99999;
            gomsg = true;
            yield return StartCoroutine(GoTip("직원들이 늘어날수록 연구력을 얻을 확률이 높아집니다."));
            yield return StartCoroutine(GoTip("더 많은 직원들을 만들어봅시다."));
        }
        TutorialManager.T05c = true;

        yield return new WaitForSeconds(2.0f);
    }


    IEnumerator GoMessage(string MSG)
    {
        while(true)
        {
            if (gomsg == true)
            {
                break;
            }
            yield return null;
        }
        MSGtext = MSG;
        Instantiate(prefabMessage).transform.SetParent(par.transform);
        gomsg = false;
        StopCoroutine(GoMessage(MSG));
    }

    IEnumerator GoLine()
    {
        while (true)
        {
            if (gomsg == true)
            {
                break;
            }
            yield return null;
        }

        Instantiate(prefabLine).transform.SetParent(par.transform);
        gomsg = false;
        StopCoroutine(GoLine());
    }

    IEnumerator Tuto(bool T)
    {
        while (true)
        {
            if (T == true)
            {
                break;
            }
            yield return null;
        }
        StopCoroutine(Tuto(T));
    }

    IEnumerator GoTip(string a)
    {
        tipText.text = a;
        int n = 0;
        Image TipImg = Tip.GetComponent<Image>();
        Text text = tipText.GetComponent<Text>();

        while (true)
        {
            if (n == 100)
            {
                break;
            }
            TipImg.color = new Color(TipImg.color.r, TipImg.color.g, TipImg.color.b, TipImg.color.a + 0.01f);
            text.color = new Color(text.color.r, text.color.g, text.color.b, text.color.a + 0.01f);

            yield return new WaitForSeconds(0.01f);
            n++;
        }

        yield return new WaitForSeconds(0.2f);
        n = 0;
        yield return new WaitForSeconds(0.2f);

        while (true)
        {
            if (n == 100)
            {
                break;
            }
            TipImg.color = new Color(TipImg.color.r, TipImg.color.g, TipImg.color.b, TipImg.color.a - 0.01f);
            text.color = new Color(text.color.r, text.color.g, text.color.b, text.color.a - 0.01f);

            yield return new WaitForSeconds(0.01f);
            n++;
        }
        gomsg = true;

        StopCoroutine(GoTip(a));

        yield return null;
    }
}