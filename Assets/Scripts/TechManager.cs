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
    
    public GameObject L2;
    public GameObject L2_3; // 영향을 받는 라인 L2, L3
    public GameObject L3;
    public GameObject L4;
    public GameObject L5;
    public GameObject L6;
    public GameObject L7;
    public GameObject L7_5; // L5, L7
    public GameObject L8;
    public GameObject L9;
    public GameObject L10;
    public GameObject L10_8; // L8, L10
    public GameObject L11;
    public GameObject L11_12; // L11, L12
    public GameObject L12;
    public GameObject L13;
    public GameObject L14;
    public GameObject L15;
    public GameObject L16;
    public GameObject L17;
    public GameObject L17_16; // L16, L17
    public GameObject L18;
    public GameObject L19_1;
    public GameObject L19_2;
    public GameObject L20;
    public GameObject L20_19; // L19, L20
    public GameObject L21;
    public GameObject L22;
    public GameObject L22_21; // L21, L22
    public GameObject Noti;

    public GameObject TechIcon1;
    public GameObject TechIcon2;
    public GameObject TechIcon3;
    public GameObject TechIcon4;
    public GameObject TechIcon5;
    public GameObject TechIcon6;
    public GameObject TechIcon7;
    public GameObject TechIcon8;
    public GameObject TechIcon9;
    public GameObject TechIcon10;
    public GameObject TechIcon11;
    public GameObject TechIcon12;
    public GameObject TechIcon13;
    public GameObject TechIcon14;
    public GameObject TechIcon15;
    public GameObject TechIcon16;
    public GameObject TechIcon17;
    public GameObject TechIcon18;
    public GameObject TechIcon19;
    public GameObject TechIcon20;
    public GameObject TechIcon21;
    public GameObject TechIcon22;

    public Sprite TechCplImg1; // 증기기관 연구 완료된 이미지(화이트)
    public Sprite TechCplImg2;
    public Sprite TechCplImg3;
    public Sprite TechCplImg4;
    public Sprite TechCplImg5;
    public Sprite TechCplImg6;
    public Sprite TechCplImg7;
    public Sprite TechCplImg8;
    public Sprite TechCplImg9;
    public Sprite TechCplImg10;
    public Sprite TechCplImg11;
    public Sprite TechCplImg12;
    public Sprite TechCplImg13;
    public Sprite TechCplImg14;
    public Sprite TechCplImg15;
    public Sprite TechCplImg16;
    public Sprite TechCplImg17;
    public Sprite TechCplImg18;
    public Sprite TechCplImg19;
    public Sprite TechCplImg20;
    public Sprite TechCplImg21;
    public Sprite TechCplImg22;

    public GameObject MainTechPanel;
    public GameObject ScrollBar;
    public GameObject SBHandle;
    Scrollbar SbTech; // 스크롤바 import를 위한 변수 AutoHidingHandle() 관련
    float CurrentHandleValue; // 스크롤바 커서 위치값 변수 AutoHidingHandle() 관련

    void Awake()
    {
        MainTechPanel.SetActive(true);
        SbTech = ScrollBar.GetComponent<Scrollbar>();
        SbTech.value = 1;

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
        MainTechPanel.SetActive(false);
        Noti.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
    }

    void Update()
    {
        AutoHidingHandle();
        TechAcs0(Tech1Button, ref Tech1Complete, Tech1);
        TechAcs1(Tech2Button, ref Tech2Complete, ref Tech1Complete, Tech2);
        TechAcs1(Tech3Button, ref Tech3Complete, ref Tech1Complete, Tech3);
        TechAcs1(Tech4Button, ref Tech4Complete, ref Tech3Complete, Tech4);
        TechAcs1(Tech5Button, ref Tech5Complete, ref Tech2Complete, Tech5);
        TechAcs1(Tech6Button, ref Tech6Complete, ref Tech4Complete, Tech6);
        TechAcs1(Tech7Button, ref Tech7Complete, ref Tech2Complete, Tech7);
        TechAcs1(Tech8Button, ref Tech8Complete, ref Tech7Complete, Tech8);
        TechAcs1(Tech9Button, ref Tech9Complete, ref Tech8Complete, Tech9);
        TechAcs1(Tech10Button, ref Tech10Complete, ref Tech7Complete, Tech10);
        TechAcs1(Tech11Button, ref Tech11Complete, ref Tech10Complete, Tech11);
        TechAcs1(Tech12Button, ref Tech12Complete, ref Tech10Complete, Tech12);
        TechAcs1(Tech13Button, ref Tech13Complete, ref Tech9Complete, Tech13);
        TechAcs1(Tech14Button, ref Tech14Complete, ref Tech11Complete, Tech14);
        TechAcs1(Tech15Button, ref Tech15Complete, ref Tech13Complete, Tech15);
        TechAcs1(Tech16Button, ref Tech16Complete, ref Tech14Complete, Tech16);
        TechAcs1(Tech17Button, ref Tech17Complete, ref Tech14Complete, Tech17);
        TechAcs1(Tech18Button, ref Tech18Complete, ref Tech16Complete, Tech18);
        TechAcs2(Tech19Button, ref Tech19Complete, ref Tech15Complete, ref Tech17Complete, Tech19);
        TechAcs1(Tech20Button, ref Tech20Complete, ref Tech17Complete, Tech20);
        TechAcs1(Tech21Button, ref Tech21Complete, ref Tech20Complete, Tech21);
        TechAcs1(Tech22Button, ref Tech22Complete, ref Tech20Complete, Tech22);
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

    void TechAcs0(Button btn, ref bool a, long s) // 사전연구가 0개 필요한 연구 (연구버튼, 연구완료 판단변수, 필요 연구량)
    {
        if (a == false)
        {
            if (GameManager.science >= s)
            {
                btn.interactable = true;
            }
        }
        else
        {
            btn.interactable = false;
        }
    }

    void TechAcs1(Button btn, ref bool a, ref bool b, long s) // 사전연구가 1개 필요한 연구 (연구버튼, 연구완료 판단변수, 사전연구1 판단변수, 필요 연구량)
    {
        if (a == false)
        {
            if (b == true)
            {
                if (GameManager.science >= s)
                {
                    btn.interactable = true;
                }
            }
        }
        else
        {
            btn.interactable = false;
        }
    }

    void TechAcs2(Button btn, ref bool a, ref bool b, ref bool c, long s) // 사전연구가 2개 필요한 연구 (연구버튼, 연구완료 판단변수, 사전연구1 판단변수, 사전연구2 판단변수, 필요 연구량)
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
                }
            }
        }
        else
        {
            btn.interactable = false;
        }
    }

    public void TechGo1() // 버튼에 할당하는 함수
    {
        GameManager.science -= Tech1;
        GameManager.years += tYear1;
        Tech1Complete = true;
        Tech1Button.interactable = false;
        TechIcon1.GetComponent<Image>().sprite = TechCplImg1;
        TechIcon1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        L2.GetComponent<Image>().color = new Color32(48, 114, 175, 255);
        L2_3.GetComponent<Image>().color = new Color32(48, 114, 175, 255);
        L3.GetComponent<Image>().color = new Color32(48, 114, 175, 255);
        TechIcon2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon2.GetComponent<Button>().interactable = true;
        TechIcon3.GetComponent<Button>().interactable = true;
    }
    public void TechGo2()
    {
        GameManager.science -= Tech2;
        GameManager.years += tYear2;
        Tech2Complete = true;
        Tech2Button.interactable = false;
        L2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        L2_3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon2.GetComponent<Image>().sprite = TechCplImg2;
        L5.GetComponent<Image>().color = new Color32(48, 114, 175, 255);
        L7_5.GetComponent<Image>().color = new Color32(48, 114, 175, 255);
        L7.GetComponent<Image>().color = new Color32(48, 114, 175, 255);
        TechIcon5.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon7.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon5.GetComponent<Button>().interactable = true;
        TechIcon7.GetComponent<Button>().interactable = true;
    }
    public void TechGo3()
    {
        GameManager.science -= Tech3;
        GameManager.years += tYear3;
        Tech3Complete = true;
        Tech3Button.interactable = false;
        L3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        L2_3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon3.GetComponent<Image>().sprite = TechCplImg3;
        L4.GetComponent<Image>().color = new Color32(48, 114, 175, 255);
        TechIcon4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon4.GetComponent<Button>().interactable = true;
    }
    public void TechGo4()
    {
        GameManager.science -= Tech4;
        GameManager.years += tYear4;
        Tech4Complete = true;
        Tech4Button.interactable = false;
        L4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon4.GetComponent<Image>().sprite = TechCplImg4;
        L6.GetComponent<Image>().color = new Color32(48, 114, 175, 255);
        TechIcon6.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon6.GetComponent<Button>().interactable = true;
    }
    public void TechGo5()
    {
        GameManager.science -= Tech5;
        GameManager.years += tYear5;
        Tech5Complete = true;
        Tech5Button.interactable = false;
        L5.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        L7_5.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon5.GetComponent<Image>().sprite = TechCplImg5;
    }
    public void TechGo6()
    {
        GameManager.science -= Tech6;
        GameManager.years += tYear6;
        Tech6Complete = true;
        Tech6Button.interactable = false;
        L6.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon6.GetComponent<Image>().sprite = TechCplImg6;
    }
    public void TechGo7()
    {
        GameManager.science -= Tech7;
        GameManager.years += tYear7;
        Tech7Complete = true;
        Tech7Button.interactable = false;
        L7.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        L7_5.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon7.GetComponent<Image>().sprite = TechCplImg7;
        L8.GetComponent<Image>().color = new Color32(48, 114, 175, 255);
        L10_8.GetComponent<Image>().color = new Color32(48, 114, 175, 255);
        L10.GetComponent<Image>().color = new Color32(48, 114, 175, 255);
        TechIcon8.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon10.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon8.GetComponent<Button>().interactable = true;
        TechIcon10.GetComponent<Button>().interactable = true;
    }
    public void TechGo8()
    {
        GameManager.science -= Tech8;
        GameManager.years += tYear8;
        Tech8Complete = true;
        Tech8Button.interactable = false;
        L8.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        L10_8.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon8.GetComponent<Image>().sprite = TechCplImg8;
        L9.GetComponent<Image>().color = new Color32(48, 114, 175, 255);
        TechIcon9.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon9.GetComponent<Button>().interactable = true;
    }
    public void TechGo9()
    {
        GameManager.science -= Tech9;
        GameManager.years += tYear9;
        Tech9Complete = true;
        Tech9Button.interactable = false;
        L9.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon9.GetComponent<Image>().sprite = TechCplImg9;
        L13.GetComponent<Image>().color = new Color32(48, 114, 175, 255);
        TechIcon13.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon13.GetComponent<Button>().interactable = true;
    }
    public void TechGo10()
    {
        GameManager.science -= Tech10;
        GameManager.years += tYear10;
        Tech10Complete = true;
        Tech10Button.interactable = false;
        L10.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        L10_8.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon10.GetComponent<Image>().sprite = TechCplImg10;
        L11.GetComponent<Image>().color = new Color32(48, 114, 175, 255);
        L11_12.GetComponent<Image>().color = new Color32(48, 114, 175, 255);
        L12.GetComponent<Image>().color = new Color32(48, 114, 175, 255);
        TechIcon11.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon12.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon11.GetComponent<Button>().interactable = true;
        TechIcon12.GetComponent<Button>().interactable = true;
    }
    public void TechGo11()
    {
        GameManager.science -= Tech11;
        GameManager.years += tYear11;
        Tech11Complete = true;
        Tech11Button.interactable = false;
        L11.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        L11_12.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon11.GetComponent<Image>().sprite = TechCplImg11;
        L14.GetComponent<Image>().color = new Color32(48, 114, 175, 255);
        TechIcon14.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon14.GetComponent<Button>().interactable = true;
    }
    public void TechGo12()
    {
        GameManager.science -= Tech12;
        GameManager.years += tYear12;
        Tech12Complete = true;
        Tech12Button.interactable = false;
        L12.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        L11_12.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon12.GetComponent<Image>().sprite = TechCplImg12;
    }
    public void TechGo13()
    {
        GameManager.science -= Tech13;
        GameManager.years += tYear13;
        Tech13Complete = true;
        Tech13Button.interactable = false;
        L13.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon13.GetComponent<Image>().sprite = TechCplImg13;
        L15.GetComponent<Image>().color = new Color32(48, 114, 175, 255);
        TechIcon15.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon15.GetComponent<Button>().interactable = true;
    }
    public void TechGo14()
    {
        GameManager.science -= Tech14;
        GameManager.years += tYear14;
        Tech14Complete = true;
        Tech14Button.interactable = false;
        L14.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon14.GetComponent<Image>().sprite = TechCplImg14;
        L16.GetComponent<Image>().color = new Color32(48, 114, 175, 255);
        L17_16.GetComponent<Image>().color = new Color32(48, 114, 175, 255);
        L17.GetComponent<Image>().color = new Color32(48, 114, 175, 255);
        TechIcon16.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon17.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon16.GetComponent<Button>().interactable = true;
        TechIcon17.GetComponent<Button>().interactable = true;
    }
    public void TechGo15()
    {
        GameManager.science -= Tech15;
        GameManager.years += tYear15;
        Tech15Complete = true;
        Tech15Button.interactable = false;
        L15.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon15.GetComponent<Image>().sprite = TechCplImg15;
        L19_1.GetComponent<Image>().color = new Color32(48, 114, 175, 255);
        if (Tech17Complete == true)
        {
            TechIcon19.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            TechIcon19.GetComponent<Button>().interactable = true;
        }
    }
    public void TechGo16()
    {
        GameManager.science -= Tech16;
        GameManager.years += tYear16;
        Tech16Complete = true;
        Tech16Button.interactable = false;
        L16.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        L17_16.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon16.GetComponent<Image>().sprite = TechCplImg16;
        L18.GetComponent<Image>().color = new Color32(48, 114, 175, 255);
        TechIcon18.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon18.GetComponent<Button>().interactable = true;
    }
    public void TechGo17()
    {
        GameManager.science -= Tech17;
        GameManager.years += tYear17;
        Tech17Complete = true;
        Tech17Button.interactable = false;
        L17.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        L17_16.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon17.GetComponent<Image>().sprite = TechCplImg17;
        L19_2.GetComponent<Image>().color = new Color32(48, 114, 175, 255);
        L20.GetComponent<Image>().color = new Color32(48, 114, 175, 255);
        L20_19.GetComponent<Image>().color = new Color32(48, 114, 175, 255);
        TechIcon20.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon20.GetComponent<Button>().interactable = true;
        if (Tech15Complete == true)
        {
            TechIcon19.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            TechIcon19.GetComponent<Button>().interactable = true;
        }
    }
    public void TechGo18()
    {
        GameManager.science -= Tech18;
        GameManager.years += tYear18;
        Tech18Complete = true;
        Tech18Button.interactable = false;
        L18.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon18.GetComponent<Image>().sprite = TechCplImg18;
        
    }
    public void TechGo19()
    {
        GameManager.science -= Tech19;
        GameManager.years += tYear19;
        Tech19Complete = true;
        Tech19Button.interactable = false;
        L19_1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        L19_2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        L20_19.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon19.GetComponent<Image>().sprite = TechCplImg19;

    }
    public void TechGo20()
    {
        GameManager.science -= Tech20;
        GameManager.years += tYear20;
        Tech20Complete = true;
        Tech20Button.interactable = false;
        L20.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        L20_19.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon20.GetComponent<Image>().sprite = TechCplImg20;
        L21.GetComponent<Image>().color = new Color32(48, 114, 175, 255);
        L22_21.GetComponent<Image>().color = new Color32(48, 114, 175, 255);
        L22.GetComponent<Image>().color = new Color32(48, 114, 175, 255);
        TechIcon21.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon22.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon21.GetComponent<Button>().interactable = true;
        TechIcon22.GetComponent<Button>().interactable = true;
    }
    public void TechGo21()
    {
        GameManager.science -= Tech21;
        GameManager.years += tYear21;
        Tech21Complete = true;
        Tech21Button.interactable = false;
        L21.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        L22_21.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon21.GetComponent<Image>().sprite = TechCplImg21;
    }
    public void TechGo22()
    {
        GameManager.science -= Tech22;
        GameManager.years += tYear22;
        Tech22Complete = true;
        Tech22Button.interactable = false;
        L22.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        L22_21.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TechIcon22.GetComponent<Image>().sprite = TechCplImg22;
    }
}