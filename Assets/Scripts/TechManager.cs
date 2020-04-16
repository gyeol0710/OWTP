using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TechManager : MonoBehaviour
{
    public long tc1_증기기관_연구력; // 증기기관 기술 필요 연구력 양
    public static long Tech1; // 증기기관 기술 전역변수
    public long tc2_증기선_연구력;
    public static long Tech2;
    public long tc3_수직기_연구력;
    public static long Tech3;
    public long tc4_방적기_연구력;
    public static long Tech4;
    public long tc5_증기기관플러스_연구력;
    public static long Tech5;
    public long tc6_방직기_연구력;
    public static long Tech6;
    public long tc7_기체화학_연구력;
    public static long Tech7;
    public long tc8_동물전기_연구력;
    public static long Tech8;
    public long tc9_대기전기_연구력;
    public static long Tech9;
    public long tc10_석탄_연구력;
    public static long Tech10;
    public long tc11_철강업_연구력;
    public static long Tech11;
    public long tc12_증기압축_연구력;
    public static long Tech12;
    public long tc13_자기력_연구력;
    public static long Tech13;
    public long tc14_열역학_연구력;
    public static long Tech14;
    public long tc15_유선통신_연구력;
    public static long Tech15;
    public long tc16_탄도학_연구력;
    public static long Tech16;
    public long tc17_나이트로글리세린_연구력;
    public static long Tech17;
    public long tc18_소리_연구력;
    public static long Tech18;
    public long tc19_전류진동_연구력;
    public static long Tech19;
    public long tc20_필라멘트_연구력;
    public static long Tech20;
    public long tc21_무선통신_연구력;
    public static long Tech21;
    public long tc22_동력비행_연구력;
    public static long Tech22;

    public int tYear1; // 증기기관 연구 완료 시 연도 증가량
    public int tYear2;
    public int tYear3;
    public int tYear4;
    public int tYear5;
    public int tYear6;
    public int tYear7;
    public int tYear8;
    public int tYear9;
    public int tYear10;
    public int tYear11;
    public int tYear12;
    public int tYear13;
    public int tYear14;
    public int tYear15;
    public int tYear16;
    public int tYear17;
    public int tYear18;
    public int tYear19;
    public int tYear20;
    public int tYear21;
    public int tYear22;

    public Button Tech1Button;
    public Button Tech2Button;
    public Button Tech3Button;
    public Button Tech4Button;
    public Button Tech5Button;
    public Button Tech6Button;
    public Button Tech7Button;
    public Button Tech8Button;
    public Button Tech9Button;
    public Button Tech10Button;
    public Button Tech11Button;
    public Button Tech12Button;
    public Button Tech13Button;
    public Button Tech14Button;
    public Button Tech15Button;
    public Button Tech16Button;
    public Button Tech17Button;
    public Button Tech18Button;
    public Button Tech19Button;
    public Button Tech20Button;
    public Button Tech21Button;
    public Button Tech22Button;

    static public bool Tech1Complete; // 증기기관 기술 완료 판단
    static public bool Tech2Complete;
    static public bool Tech3Complete;
    static public bool Tech4Complete;
    static public bool Tech5Complete;
    static public bool Tech6Complete;
    static public bool Tech7Complete;
    static public bool Tech8Complete;
    static public bool Tech9Complete;
    static public bool Tech10Complete;
    static public bool Tech11Complete;
    static public bool Tech12Complete;
    static public bool Tech13Complete;
    static public bool Tech14Complete;
    static public bool Tech15Complete;
    static public bool Tech16Complete;
    static public bool Tech17Complete;
    static public bool Tech18Complete;
    static public bool Tech19Complete;
    static public bool Tech20Complete;
    static public bool Tech21Complete;
    static public bool Tech22Complete;

    public Text Pr1; // 필요 연구력 텍스트
    public Text Pr2;
    public Text Pr3;
    public Text Pr4;
    public Text Pr5;
    public Text Pr6;
    public Text Pr7;
    public Text Pr8;
    public Text Pr9;
    public Text Pr10;
    public Text Pr11;
    public Text Pr12;
    public Text Pr13;
    public Text Pr14;
    public Text Pr15;
    public Text Pr16;
    public Text Pr17;
    public Text Pr18;
    public Text Pr19;
    public Text Pr20;
    public Text Pr21;
    public Text Pr22;

    public GameObject ScrollBar;
    public GameObject SBHandle;
    public GameObject L2;
    public GameObject L2_3;
    public GameObject L3;
    public GameObject L4;
    public GameObject L5;
    public GameObject L6;
    public GameObject L7;
    public GameObject L8;
    public GameObject L9;
    public GameObject L10;
    public GameObject L11;
    public GameObject L12;
    public GameObject L13;
    public GameObject L14;
    public GameObject L15;
    public GameObject L16;
    public GameObject L17;
    public GameObject L18;
    public GameObject L19;
    public GameObject L20;
    public GameObject L21;
    public GameObject L22;
    public GameObject Noti;

    Scrollbar SbTech; // 스크롤바 import를 위한 변수 AutoHidingHandle() 관련
    float CurrentHandleValue; // 스크롤바 커서 위치값 변수 AutoHidingHandle() 관련

    void Awake() // Tech 전역변수를 위한 awake
    {
        Tech1 = tc1_증기기관_연구력;
        Tech2 = tc2_증기선_연구력;
        Tech3 = tc3_수직기_연구력;
        Tech4 = tc4_방적기_연구력;
        Tech5 = tc5_증기기관플러스_연구력;
        Tech6 = tc6_방직기_연구력;
        Tech7 = tc7_기체화학_연구력;
        Tech8 = tc8_동물전기_연구력;
        Tech9 = tc9_대기전기_연구력;
        Tech10 = tc10_석탄_연구력;
        Tech11 = tc11_철강업_연구력;
        Tech12 = tc12_증기압축_연구력;
        Tech13 = tc13_자기력_연구력;
        Tech14 = tc14_열역학_연구력;
        Tech15 = tc15_유선통신_연구력;
        Tech16 = tc16_탄도학_연구력;
        Tech17 = tc17_나이트로글리세린_연구력;
        Tech18 = tc18_소리_연구력;
        Tech19 = tc19_전류진동_연구력;
        Tech20 = tc20_필라멘트_연구력;
        Tech21 = tc21_무선통신_연구력;
        Tech22 = tc22_동력비행_연구력;

        Pr1.text = Tech1.ToString();
        Pr2.text = Tech2.ToString();
        Pr3.text = Tech3.ToString();
        Pr4.text = Tech4.ToString();
        Pr5.text = Tech5.ToString();
        Pr6.text = Tech6.ToString();
        Pr7.text = Tech7.ToString();
        Pr8.text = Tech8.ToString();
        Pr9.text = Tech9.ToString();
        Pr10.text = Tech10.ToString();
        Pr11.text = Tech11.ToString();
        Pr12.text = Tech12.ToString();
        Pr13.text = Tech13.ToString();
        Pr14.text = Tech14.ToString();
        Pr15.text = Tech15.ToString();
        Pr16.text = Tech16.ToString();
        Pr17.text = Tech17.ToString();
        Pr18.text = Tech18.ToString();
        Pr19.text = Tech19.ToString();
        Pr20.text = Tech20.ToString();
        Pr21.text = Tech21.ToString();
        Pr22.text = Tech22.ToString();

        Tech1Button.interactable = false;
        Tech2Button.interactable = false;
        Tech3Button.interactable = false;
        Tech4Button.interactable = false;
        Tech5Button.interactable = false;
        Tech6Button.interactable = false;
        Tech7Button.interactable = false;
        Tech8Button.interactable = false;
        Tech9Button.interactable = false;
        Tech10Button.interactable = false;
        Tech11Button.interactable = false;
        Tech12Button.interactable = false;
        Tech13Button.interactable = false;
        Tech14Button.interactable = false;
        Tech15Button.interactable = false;
        Tech16Button.interactable = false;
        Tech17Button.interactable = false;
        Tech18Button.interactable = false;
        Tech19Button.interactable = false;
        Tech20Button.interactable = false;
        Tech21Button.interactable = false;
        Tech22Button.interactable = false;
    }

    void Start()
    {
        SbTech = ScrollBar.GetComponent<Scrollbar>();
        SbTech.value = 1;
        Noti.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
        StartCoroutine(TechAcs0(Tech1Button, Tech1Complete, Tech1));
    }

    void Update()
    {
        AutoHidingHandle();
    }

    IEnumerator LineCheck()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.1f);
        }
    }

    void LineChecking1_1(bool a, GameObject b)
    {
        if (a == true)
        {
            b.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        }
    }

    public void ButtonNotiOff()
    {
        Noti.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
    }

    void AutoHidingHandle()
    {
        Image im = SBHandle.GetComponent<Image>();
        im.color = new Color(im.color.r, im.color.g, im.color.b, im.color.a - 0.02f);
        if (SbTech.value != CurrentHandleValue)
        {
            im.color = new Color32(255, 255, 255, 255);
            CurrentHandleValue = SbTech.value;
        }
    }

    IEnumerator TechAcs0(Button btn, bool a, long s) // 사전연구가 0개 필요한 연구 (연구버튼, 연구완료 판단변수, 필요 연구량)
    {
        while(true)
        {
            if (a == false)
            {
                if (GameManager.science >= s)
                {
                    btn.interactable = true;
                }
                else if (GameManager.science < s)
                {
                    btn.interactable = false;
                }
            }
            else if (a == true)
            {
                StopCoroutine(TechAcs0(btn, a, s));
            }
            yield return new WaitForSeconds(0.2f);
        }
    }

    IEnumerator TechAcs1(Button btn, bool a, bool b, long s) // 사전연구가 1개 필요한 연구 (연구버튼, 연구완료 판단변수, 사전연구1 판단변수, 필요 연구량)
    {
        while (true)
        {
            if (a == false)
            {
                if (b == true)
                {
                    if (GameManager.science >= s)
                    {
                        btn.interactable = true;
                    }
                    else if (GameManager.science < s)
                    {
                        btn.interactable = false;
                    }
                }
            }
            else if (a == true)
            {
                StopCoroutine(TechAcs1(btn, a, b, s));
            }
            yield return new WaitForSeconds(0.2f);
        }
    }

    IEnumerator TechAcs2(Button btn, bool a, bool b, bool c, long s) // 사전연구가 2개 필요한 연구 (연구버튼, 연구완료 판단변수, 사전연구1 판단변수, 사전연구2 판단변수, 필요 연구량)
    {
        while (true)
        {
            if (a == false)
            {
                if (b == true)
                {
                    if (c == true)
                    {
                        if (GameManager.science >= s)
                        {
                            btn.interactable = true;
                        }
                        else if (GameManager.science < s)
                        {
                            btn.interactable = false;
                        }
                    }
                }
            }
            else if (a == true)
            {
                StopCoroutine(TechAcs2(btn, a, b, c, s));
            }
            yield return new WaitForSeconds(0.2f);
        }
    }

    public void TechGo1() // 버튼에 할당하는 함수
    {
        GameManager.science -= Tech1;
        GameManager.years += tYear1;
        Tech1Complete = true;
        Tech1Button.interactable = false;
    }
    public void TechGo2()
    {
        GameManager.science -= Tech2;
        GameManager.years += tYear2;
        Tech2Complete = true;
        Tech2Button.interactable = false;
        L2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        L2_3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
    }
    public void TechGo3()
    {
        GameManager.science -= Tech3;
        GameManager.years += tYear3;
        Tech3Complete = true;
        Tech3Button.interactable = false;

    }
    public void TechGo4()
    {
        GameManager.science -= Tech4;
        GameManager.years += tYear4;
        Tech4Complete = true;
        Tech4Button.interactable = false;
    }
    public void TechGo5()
    {
        GameManager.science -= Tech5;
        GameManager.years += tYear5;
        Tech5Complete = true;
        Tech5Button.interactable = false;
    }
    public void TechGo6()
    {
        GameManager.science -= Tech6;
        GameManager.years += tYear6;
        Tech6Complete = true;
        Tech6Button.interactable = false;
    }
    public void TechGo7()
    {
        GameManager.science -= Tech7;
        GameManager.years += tYear7;
        Tech7Complete = true;
        Tech7Button.interactable = false;
    }
    public void TechGo8()
    {
        GameManager.science -= Tech8;
        GameManager.years += tYear8;
        Tech8Complete = true;
        Tech8Button.interactable = false;
    }
    public void TechGo9()
    {
        GameManager.science -= Tech9;
        GameManager.years += tYear9;
        Tech9Complete = true;
        Tech9Button.interactable = false;
    }
    public void TechGo10()
    {
        GameManager.science -= Tech10;
        GameManager.years += tYear10;
        Tech10Complete = true;
        Tech10Button.interactable = false;
    }
    public void TechGo11()
    {
        GameManager.science -= Tech11;
        GameManager.years += tYear11;
        Tech11Complete = true;
        Tech11Button.interactable = false;
    }
    public void TechGo12()
    {
        GameManager.science -= Tech12;
        GameManager.years += tYear12;
        Tech12Complete = true;
        Tech12Button.interactable = false;
    }
    public void TechGo13()
    {
        GameManager.science -= Tech13;
        GameManager.years += tYear13;
        Tech13Complete = true;
        Tech13Button.interactable = false;
    }
    public void TechGo14()
    {
        GameManager.science -= Tech14;
        GameManager.years += tYear14;
        Tech14Complete = true;
        Tech14Button.interactable = false;
    }
    public void TechGo15()
    {
        GameManager.science -= Tech15;
        GameManager.years += tYear15;
        Tech15Complete = true;
        Tech15Button.interactable = false;
    }
    public void TechGo16()
    {
        GameManager.science -= Tech16;
        GameManager.years += tYear16;
        Tech16Complete = true;
        Tech16Button.interactable = false;
    }
    public void TechGo17()
    {
        GameManager.science -= Tech17;
        GameManager.years += tYear17;
        Tech17Complete = true;
        Tech17Button.interactable = false;
    }
    public void TechGo18()
    {
        GameManager.science -= Tech18;
        GameManager.years += tYear18;
        Tech18Complete = true;
        Tech18Button.interactable = false;
    }
    public void TechGo19()
    {
        GameManager.science -= Tech19;
        GameManager.years += tYear19;
        Tech19Complete = true;
        Tech19Button.interactable = false;
    }
    public void TechGo20()
    {
        GameManager.science -= Tech20;
        GameManager.years += tYear20;
        Tech20Complete = true;
        Tech20Button.interactable = false;
    }
    public void TechGo21()
    {
        GameManager.science -= Tech21;
        GameManager.years += tYear21;
        Tech21Complete = true;
        Tech21Button.interactable = false;
    }
    public void TechGo22()
    {
        GameManager.science -= Tech22;
        GameManager.years += tYear22;
        Tech22Complete = true;
        Tech22Button.interactable = false;
    }


    /*
    public void SteamEngineResearch()
    {
        if (Tech001Complete == false)
        {
            if (GameManager.science >= SteamEngineSciencePrice)
            {
                GameManager.science -= SteamEngineSciencePrice;
                SteamEngineComplete = true;
                GameManager.years += 20;
            }
        }
    }

    void SteamEngineButtonActiveCheck()
    {
        if (SteamEngineComplete == false)
        {
            if (GameManager.science >= SteamEngineSciencePrice)
            {
                SteamEngineButton.interactable = true;
                Noti.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }
            else
                SteamEngineButton.interactable = false;
        }
        else
            SteamEngineButton.interactable = false;
    }

    public void Tech02Research()
    {
        if (SteamEngineComplete == true)
        {
            if (Tech02Complete == false)
            {
                if (GameManager.science >= Tech02Price)
                {
                    GameManager.science -= Tech02Price;
                    Tech02Complete = true;
                    GameManager.years += 15;
                }
            }
        }
    }

    void Tech02ButtonActiveCheck()
    {
        if (SteamEngineComplete == true)
        {
            if (Tech02Complete == false)
            {
                if (GameManager.science >= Tech02Price)
                {
                    Tech02Button.interactable = true;
                }
                else
                    Tech02Button.interactable = false;
            }
            else
                Tech02Button.interactable = false;
        }
        else
            Tech02Button.interactable = false;
    }

    public void Tech03Research()
    {
        if (SteamEngineComplete == true)
        {
            if (Tech03Complete == false)
            {
                if (GameManager.science >= Tech03Price)
                {
                    GameManager.science -= Tech03Price;
                    Tech03Complete = true;
                    GameManager.years += 15;
                }
            }
        }
    }

    void Tech03ButtonActiveCheck()
    {
        if (SteamEngineComplete == true)
        {
            if (Tech03Complete == false)
            {
                if (GameManager.science >= Tech03Price)
                {
                    Tech03Button.interactable = true;
                }
                else
                    Tech03Button.interactable = false;
            }
            else
                Tech03Button.interactable = false;
        }
        else
            Tech03Button.interactable = false;
    }

    public void Tech04Research()
    {
        if (Tech02Complete == true)
        {
            if (Tech03Complete == true)
            {
                if (Tech04Complete == false)
                {
                    if (GameManager.science >= Tech04Price)
                    {
                        GameManager.science -= Tech04Price;
                        Tech04Complete = true;
                        GameManager.years += 10;
                    }
                }
            }
        }
    }

    void Tech04ButtonActiveCheck()
    {
        if (Tech02Complete == true)
        {
            if (Tech03Complete == true)
            {
                if (Tech04Complete == false)
                {
                    if (GameManager.science >= Tech04Price)
                    {
                        Tech04Button.interactable = true;
                    }
                    else
                        Tech04Button.interactable = false;
                }
                else
                    Tech04Button.interactable = false;
            }
            else
                Tech04Button.interactable = false;
        }
        else
            Tech04Button.interactable = false;
    }
    */
}
