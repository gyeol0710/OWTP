using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TechManager : MonoBehaviour
{
    public long T001_증기기관_연구력; // 증기기관 기술 필요 연구력 양
    public static long Tech001; // 증기기관 기술 전역변수
    public long T002_증기선_연구력;
    public static long Tech002;
    public long T003_수직기_연구력;
    public static long Tech003;
    public long T004_방적기_연구력;
    public static long Tech004;
    public long T005_증기기관플러스_연구력;
    public static long Tech005;
    public long T006_방직기_연구력;
    public static long Tech006;
    public long T007_기체화학_연구력;
    public static long Tech007;
    public long T008_동물전기_연구력;
    public static long Tech008;
    public long T009_대기전기_연구력;
    public static long Tech009;
    public long T010_석탄_연구력;
    public static long Tech010;
    public long T011_철강업_연구력;
    public static long Tech011;
    public long T012_증기압축_연구력;
    public static long Tech012;
    public long T013_자기력_연구력;
    public static long Tech013;
    public long T014_열역학_연구력;
    public static long Tech014;
    public long T015_유선통신_연구력;
    public static long Tech015;
    public long T016_탄도학_연구력;
    public static long Tech016;
    public long T017_나이트로글리세린_연구력;
    public static long Tech017;
    public long T018_소리_연구력;
    public static long Tech018;
    public long T019_전류진동_연구력;
    public static long Tech019;
    public long T020_필라멘트_연구력;
    public static long Tech020;
    public long T021_무선통신_연구력;
    public static long Tech021;
    public long T022_동력비행_연구력;
    public static long Tech022;

    public int tYear001; // 증기기관 연구 완료 시 연도 증가량
    public int tYear002;
    public int tYear003;
    public int tYear004;
    public int tYear005;
    public int tYear006;
    public int tYear007;
    public int tYear008;
    public int tYear009;
    public int tYear010;
    public int tYear011;
    public int tYear012;
    public int tYear013;
    public int tYear014;
    public int tYear015;
    public int tYear016;
    public int tYear017;
    public int tYear018;
    public int tYear019;
    public int tYear020;
    public int tYear021;
    public int tYear022;

    public Button Tech001Button;
    public Button Tech002Button;
    public Button Tech003Button;
    public Button Tech004Button;
    public Button Tech005Button;
    public Button Tech006Button;
    public Button Tech007Button;
    public Button Tech008Button;
    public Button Tech009Button;
    public Button Tech010Button;
    public Button Tech011Button;
    public Button Tech012Button;
    public Button Tech013Button;
    public Button Tech014Button;
    public Button Tech015Button;
    public Button Tech016Button;
    public Button Tech017Button;
    public Button Tech018Button;
    public Button Tech019Button;
    public Button Tech020Button;
    public Button Tech021Button;
    public Button Tech022Button;

    static public bool Tech001Complete; // 증기기관 기술 완료 판단
    static public bool Tech002Complete;
    static public bool Tech003Complete;
    static public bool Tech004Complete;
    static public bool Tech005Complete;
    static public bool Tech006Complete;
    static public bool Tech007Complete;
    static public bool Tech008Complete;
    static public bool Tech009Complete;
    static public bool Tech010Complete;
    static public bool Tech011Complete;
    static public bool Tech012Complete;
    static public bool Tech013Complete;
    static public bool Tech014Complete;
    static public bool Tech015Complete;
    static public bool Tech016Complete;
    static public bool Tech017Complete;
    static public bool Tech018Complete;
    static public bool Tech019Complete;
    static public bool Tech020Complete;
    static public bool Tech021Complete;
    static public bool Tech022Complete;

    public Text Pr001; // 필요 연구력 텍스트
    public Text Pr002;
    public Text Pr003;
    public Text Pr004;
    public Text Pr005;
    public Text Pr006;
    public Text Pr007;
    public Text Pr008;
    public Text Pr009;
    public Text Pr010;
    public Text Pr011;
    public Text Pr012;
    public Text Pr013;
    public Text Pr014;
    public Text Pr015;
    public Text Pr016;
    public Text Pr017;
    public Text Pr018;
    public Text Pr019;
    public Text Pr020;
    public Text Pr021;
    public Text Pr022;

    public GameObject ScrollBar;
    public GameObject SBHandle;
    public GameObject L01;
    public GameObject L02;
    public GameObject L03;
    public GameObject L04;
    public GameObject L05;
    public GameObject L06;
    public GameObject L07;
    public GameObject L08;
    public GameObject L09;
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
        Tech001 = T001_증기기관_연구력;
        Tech002 = T002_증기선_연구력;
        Tech003 = T003_수직기_연구력;
        Tech004 = T004_방적기_연구력;
        Tech005 = T005_증기기관플러스_연구력;
        Tech006 = T006_방직기_연구력;
        Tech007 = T007_기체화학_연구력;
        Tech008 = T008_동물전기_연구력;
        Tech009 = T009_대기전기_연구력;
        Tech010 = T010_석탄_연구력;
        Tech011 = T011_철강업_연구력;
        Tech012 = T012_증기압축_연구력;
        Tech013 = T013_자기력_연구력;
        Tech014 = T014_열역학_연구력;
        Tech015 = T015_유선통신_연구력;
        Tech016 = T016_탄도학_연구력;
        Tech017 = T017_나이트로글리세린_연구력;
        Tech018 = T018_소리_연구력;
        Tech019 = T019_전류진동_연구력;
        Tech020 = T020_필라멘트_연구력;
        Tech021 = T021_무선통신_연구력;
        Tech022 = T022_동력비행_연구력;
    }

    void Start()
    {
        SbTech = ScrollBar.GetComponent<Scrollbar>();
        SbTech.value = 1;
        Color NotiC = Noti.GetComponent<Image>().color; // 알림 투명도 관련
        Noti.GetComponent<Image>().color = new Color32(255, 255, 255, 0);

        Pr001.text = Tech001.ToString();
        Pr002.text = Tech002.ToString();
        Pr003.text = Tech003.ToString();
        Pr004.text = Tech004.ToString();
        Pr005.text = Tech005.ToString();
        Pr006.text = Tech006.ToString();
        Pr007.text = Tech007.ToString();
        Pr008.text = Tech008.ToString();
        Pr009.text = Tech009.ToString();
        Pr010.text = Tech010.ToString();
        Pr011.text = Tech011.ToString();
        Pr012.text = Tech012.ToString();
        Pr013.text = Tech013.ToString();
        Pr014.text = Tech014.ToString();
        Pr015.text = Tech015.ToString();
        Pr016.text = Tech016.ToString();
        Pr017.text = Tech017.ToString();
        Pr018.text = Tech018.ToString();
        Pr019.text = Tech019.ToString();
        Pr020.text = Tech020.ToString();
        Pr021.text = Tech021.ToString();
        Pr022.text = Tech022.ToString();
        StartCoroutine(TechClick(Tech001Button, Tech001Complete, Tech001, 10));
    }

    void Update()
    {
        /*
        SteamEngineButtonActiveCheck();
        Tech02ButtonActiveCheck();
        Tech03ButtonActiveCheck();
        Tech04ButtonActiveCheck();
        LineCompleteCheck();
        */
        AutoHidingHandle();
    }

    void LineCompleteCheck()
    {
        if (Tech001Complete == true)
        {
            L01.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
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

    IEnumerator TechClick(Button Btn, bool a, long b, int c)
    {
            Button btn = Btn.transform.GetComponent<Button>();
            btn.onClick.AddListener(delegate { Research0(a, b, c); });
            yield return null;
        
    }
    void Research0 (bool a, long b, int c) // 위에 트리가 0개인 연구 코루틴함수(즉, 맨 위에 있는 첫번 째 연구 ex) 증기기관
                                           // a는 연구 완료 판단 변수, b는 필요 연구력 양, c는 추가되는 years량
    {
        if (a == true)
        {

        }

        else if (a == false)
        {
            if (GameManager.science >= b)
            {
                GameManager.science -= b;

                GameManager.years += c;
            }
        }
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
