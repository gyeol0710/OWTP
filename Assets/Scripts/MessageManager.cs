using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MessageManager : MonoBehaviour
{
    public Text msg;

    static public string MSGtext;

    public GameObject prefabMessage;
    public GameObject prefabLine;
    public GameObject par;

    static public bool gomsg;

    public string text;

    void Start()
    {
        StartCoroutine(Message());
    }

    void Update()
    {

    }

    IEnumerator Message()
    {
        yield return StartCoroutine(Tuto(TutorialManager.T01));
        gomsg = true;
        if (TutorialManager.T01c == false)
        {
            /*
            yield return StartCoroutine(GoMessage("........."));
            yield return StartCoroutine(GoMessage("........."));
            yield return StartCoroutine(GoMessage("정신차리세요."));
            yield return StartCoroutine(GoMessage("일단 우주선에 남은 연료가 적어서"));
            yield return StartCoroutine(GoMessage("불시착했습니다."));
            yield return StartCoroutine(GoMessage("XᴂP33S⧣⦹eDscx⦩ᜈ"));
            yield return StartCoroutine(GoMessage("어s어서fㅈjdwnddᅟᅵᆸ니다."));
            yield return StartCoroutine(GoMessage("언어설정완료."));
            yield return StartCoroutine(GoMessage("지역스캔완료."));
            */
            yield return StartCoroutine(GoMessage("환경적응완료."));
            yield return StartCoroutine(GoLine());
        }
        TutorialManager.T01c = true;

        yield return new WaitForSeconds(2.0f);

        yield return StartCoroutine(Tuto(TutorialManager.T02));

        if (TutorialManager.T02c == false)
        {
            gomsg = true;
            yield return StartCoroutine(GoMessage("흥미로운 별입니다."));
            yield return StartCoroutine(GoMessage("1000만종 가까운 생물들이 존재합니다."));
            yield return StartCoroutine(GoMessage("그 중에서도 사람이라는 생물의 면적이"));
            yield return StartCoroutine(GoMessage("가장 넓군요!"));
            yield return StartCoroutine(GoMessage("게다가 우리만 있는게 아니네요."));
            yield return StartCoroutine(GoMessage("다른 은하에서 온 생물체들도 마음껏 이 환경을"));
            yield return StartCoroutine(GoMessage("꾸미고 있어요."));
            yield return StartCoroutine(GoMessage("일단 우리도 에너지를 한번 만들어 봅시다!"));
            yield return StartCoroutine(GoLine());
            TutorialManager.T02c = true;
        }
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
}