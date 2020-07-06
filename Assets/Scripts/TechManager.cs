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
    public long tc23_개틀링건_연구력;
    public static long Tech23;
    public long tc24_진공_연구력;
    public static long Tech24;
    public long tc25_오프셋인쇄_연구력;
    public static long Tech25;
    public long tc26_냉각순환_연구력;
    public static long Tech26;
    public long tc27_전자기파_연구력;
    public static long Tech27;
    public long tc28_폭격기_연구력;
    public static long Tech28;
    public long tc29_4기통엔진_연구력;
    public static long Tech29;
    public long tc30_암모니아_연구력;
    public static long Tech30;
    public long tc31_암호학_연구력;
    public static long Tech31;
    public long tc32_탱크_연구력;
    public static long Tech32;
    public long tc33_급속동결_연구력;
    public static long Tech33;
    public long tc34_항생재_연구력;
    public static long Tech34;
    public long tc35_나일론_연구력;
    public static long Tech35;
    public long tc36_제트엔진_연구력;
    public static long Tech36;
    public long tc37_우라늄_연구력;
    public static long Tech37;
    public long tc38_삼원색_연구력;
    public static long Tech38;
    public long tc39_극초단파_연구력;
    public static long Tech39;
    public long tc40_신호변환_연구력;
    public static long Tech40;
    public long tc41_레이저_연구력;
    public static long Tech41;
    public long tc42_해열진통제_연구력;
    public static long Tech42;
    public long tc43_자기저장소_연구력;
    public static long Tech43;
    public long tc44_소리플러스_연구력;
    public static long Tech44;
    public long tc45_발광다이오드_연구력;
    public static long Tech45;
    public long tc46_신경안정제_연구력;
    public static long Tech46;
    public long tc47_저장소플러스_연구력;
    public static long Tech47;
    public long tc48_논리회로_연구력;
    public static long Tech48;
    public long tc49_전자두뇌_연구력;
    public static long Tech49;
    public long tc50_보이저계획_연구력;
    public static long Tech50;
    public long tc51_콜레스테릭_연구력;
    public static long Tech51;
    public long tc52_이더넷_연구력;
    public static long Tech52;
    public long tc53_양성자반응_연구력;
    public static long Tech53;
    public long tc54_전송_연구력;
    public static long Tech54;
    public long tc55_전자오락_연구력;
    public static long Tech55;
    public long tc56_컴퓨터언어_연구력;
    public static long Tech56;
    public long tc57_유전자치료_연구력;
    public static long Tech57;
    public long tc58_근거리통신망_연구력;
    public static long Tech58;
    public long tc59_통신위성_연구력;
    public static long Tech59;
    public long tc60_유전자변화_연구력;
    public static long Tech60;
    public long tc61_세계통합_연구력;
    public static long Tech61;
    public long tc62_복제_연구력;
    public static long Tech62;
    public long tc63_컴퓨터플러스_연구력;
    public static long Tech63;
    public long tc64_블록체인_연구력;
    public static long Tech64;
    public long tc65_AI_연구력;
    public static long Tech65;
    public long tc66_고속통신_연구력;
    public static long Tech66;
    public long tc67_가상현실_연구력;
    public static long Tech67;
    public long tc68_증강현실_연구력;
    public static long Tech68;
    public long tc69_제품화_연구력;
    public static long Tech69;
    public long tc70_서버변경_연구력;
    public static long Tech70;


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
    public int tYear23;
    public int tYear24;
    public int tYear25;
    public int tYear26;
    public int tYear27;
    public int tYear28;
    public int tYear29;
    public int tYear30;
    public int tYear31;
    public int tYear32;
    public int tYear33;
    public int tYear34;
    public int tYear35;
    public int tYear36;
    public int tYear37;
    public int tYear38;
    public int tYear39;
    public int tYear40;
    public int tYear41;
    public int tYear42;
    public int tYear43;
    public int tYear44;
    public int tYear45;
    public int tYear46;
    public int tYear47;
    public int tYear48;
    public int tYear49;
    public int tYear50;
    public int tYear51;
    public int tYear52;
    public int tYear53;
    public int tYear54;
    public int tYear55;
    public int tYear56;
    public int tYear57;
    public int tYear58;
    public int tYear59;
    public int tYear60;
    public int tYear61;
    public int tYear62;
    public int tYear63;
    public int tYear64;
    public int tYear65;
    public int tYear66;
    public int tYear67;
    public int tYear68;
    public int tYear69;
    public int tYear70;

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
    static public bool Tech23Complete;
    static public bool Tech24Complete;
    static public bool Tech25Complete;
    static public bool Tech26Complete;
    static public bool Tech27Complete;
    static public bool Tech28Complete;
    static public bool Tech29Complete;
    static public bool Tech30Complete;
    static public bool Tech31Complete;
    static public bool Tech32Complete;
    static public bool Tech33Complete;
    static public bool Tech34Complete;
    static public bool Tech35Complete;
    static public bool Tech36Complete;
    static public bool Tech37Complete;
    static public bool Tech38Complete;
    static public bool Tech39Complete;
    static public bool Tech40Complete;
    static public bool Tech41Complete;
    static public bool Tech42Complete;
    static public bool Tech43Complete;
    static public bool Tech44Complete;
    static public bool Tech45Complete;
    static public bool Tech46Complete;
    static public bool Tech47Complete;
    static public bool Tech48Complete;
    static public bool Tech49Complete;
    static public bool Tech50Complete;
    static public bool Tech51Complete;
    static public bool Tech52Complete;
    static public bool Tech53Complete;
    static public bool Tech54Complete;
    static public bool Tech55Complete;
    static public bool Tech56Complete;
    static public bool Tech57Complete;
    static public bool Tech58Complete;
    static public bool Tech59Complete;
    static public bool Tech60Complete;
    static public bool Tech61Complete;
    static public bool Tech62Complete;
    static public bool Tech63Complete;
    static public bool Tech64Complete;
    static public bool Tech65Complete;
    static public bool Tech66Complete;
    static public bool Tech67Complete;
    static public bool Tech68Complete;
    static public bool Tech69Complete;
    static public bool Tech70Complete;

    bool Tech1AnimC;
    bool Tech2AnimC;
    bool Tech3AnimC;
    bool Tech4AnimC;
    bool Tech5AnimC;
    bool Tech6AnimC;
    bool Tech7AnimC;
    bool Tech8AnimC;
    bool Tech9AnimC;
    bool Tech10AnimC;
    bool Tech11AnimC;
    bool Tech12AnimC;
    bool Tech13AnimC;
    bool Tech14AnimC;
    bool Tech15AnimC;
    bool Tech16AnimC;
    bool Tech17AnimC;
    bool Tech18AnimC;
    bool Tech19AnimC;
    bool Tech20AnimC;
    bool Tech21AnimC;
    bool Tech22AnimC;
    bool Tech23AnimC;
    bool Tech24AnimC;
    bool Tech25AnimC;
    bool Tech26AnimC;
    bool Tech27AnimC;
    bool Tech28AnimC;
    bool Tech29AnimC;
    bool Tech30AnimC;
    bool Tech31AnimC;
    bool Tech32AnimC;
    bool Tech33AnimC;
    bool Tech34AnimC;
    bool Tech35AnimC;
    bool Tech36AnimC;
    bool Tech37AnimC;
    bool Tech38AnimC;
    bool Tech39AnimC;
    bool Tech40AnimC;
    bool Tech41AnimC;
    bool Tech42AnimC;
    bool Tech43AnimC;
    bool Tech44AnimC;
    bool Tech45AnimC;
    bool Tech46AnimC;
    bool Tech47AnimC;
    bool Tech48AnimC;
    bool Tech49AnimC;
    bool Tech50AnimC;
    bool Tech51AnimC;
    bool Tech52AnimC;
    bool Tech53AnimC;
    bool Tech54AnimC;
    bool Tech55AnimC;
    bool Tech56AnimC;
    bool Tech57AnimC;
    bool Tech58AnimC;
    bool Tech59AnimC;


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
    public GameObject L24;
    public GameObject L24_25;
    public GameObject L25;
    public GameObject L26;
    public GameObject L27;
    public GameObject L27_28;
    public GameObject L28;
    public GameObject L28_32;
    public GameObject L29;
    public GameObject L29_32;
    public GameObject L30;
    public GameObject L31;
    public GameObject L32;
    public GameObject L33;
    public GameObject L34;
    public GameObject L35;
    public GameObject L36_1;
    public GameObject L36_2;
    public GameObject L36_3;
    public GameObject L37_1;
    public GameObject L37_2;
    public GameObject L37_3;
    public GameObject L37_35;
    public GameObject L37_36;

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
    public GameObject TechIcon23;
    public GameObject TechIcon24;
    public GameObject TechIcon25;
    public GameObject TechIcon26;
    public GameObject TechIcon27;
    public GameObject TechIcon28;
    public GameObject TechIcon29;
    public GameObject TechIcon30;
    public GameObject TechIcon31;
    public GameObject TechIcon32;
    public GameObject TechIcon33;
    public GameObject TechIcon34;
    public GameObject TechIcon35;
    public GameObject TechIcon36;
    public GameObject TechIcon37;

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
    public Sprite TechCplImg23;
    public Sprite TechCplImg24;
    public Sprite TechCplImg25;
    public Sprite TechCplImg26;
    public Sprite TechCplImg27;
    public Sprite TechCplImg28;
    public Sprite TechCplImg29;
    public Sprite TechCplImg30;
    public Sprite TechCplImg31;
    public Sprite TechCplImg32;
    public Sprite TechCplImg33;
    public Sprite TechCplImg34;
    public Sprite TechCplImg35;
    public Sprite TechCplImg36;
    public Sprite TechCplImg37;

    public GameObject ProdBtn1;
    public GameObject ProdBtn3;
    public GameObject ProdBtn4;
    public GameObject ProdBtn5;
    public GameObject ProdBtn6;
    public GameObject ProdBtn7;
    public GameObject ProdBtn8;
    public GameObject ProdBtn9;
    public GameObject ProdBtn10;
    public GameObject ProdBtn11;
    public GameObject ProdBtn12;
    public GameObject ProdBtn13;
    public GameObject ProdBtn14;
    public GameObject ProdBtn15;
    public GameObject ProdBtn17;
    public GameObject ProdBtn18;
    public GameObject ProdBtn19;
    public GameObject ProdBtn20;
    public GameObject ProdBtn21;
    public GameObject ProdBtn22;
    public GameObject ProdBtn23;
    public GameObject ProdBtn24;
    public GameObject ProdBtn25;
    public GameObject ProdBtn26;
    public GameObject ProdBtn27;
    public GameObject ProdBtn28;
    public GameObject ProdBtn29;
    public GameObject ProdBtn30;
    public GameObject ProdBtn31;
    public GameObject ProdBtn32;
    public GameObject ProdBtn33;
    public GameObject ProdBtn34;
    public GameObject ProdBtn35;
    public GameObject ProdBtn36;
    public GameObject ProdBtn37;

    // 연구아이콘 클릭 시 나오는 패널 관련
    public Text title;
    public Text exp;
    public GameObject Icon; // 연구완료 아이콘 집어넣기
    public Text NeedScience;
    public Button TechUpBtn;
    public GameObject TechUpPanel;

    short PanelNum;

    public GameObject MainTechPanel;
    public GameObject ScrollBar_IND;
    public GameObject SBHandle_IND;
    public GameObject ScrollBar_WAR;
    public GameObject SBHandle_WAR;

    Scrollbar SbTech_IND; // 스크롤바 import를 위한 변수 AutoHidingHandle() 관련
    float CurrentHandleValue_IND; // 스크롤바 커서 위치값 변수 AutoHidingHandle() 관련
    Scrollbar SbTech_WAR;
    float CurrentHandleValue_WAR;

    void Awake()
    {
        MainTechPanel.SetActive(true);
        SbTech_IND = ScrollBar_IND.GetComponent<Scrollbar>();
        SbTech_IND.value = 1;
        SbTech_WAR = ScrollBar_WAR.GetComponent<Scrollbar>();
        SbTech_WAR.value = 1;

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
        Tech23 = tc23_개틀링건_연구력;
        Tech24 = tc24_진공_연구력;
        Tech25 = tc25_오프셋인쇄_연구력;
        Tech26 = tc26_냉각순환_연구력;
        Tech27 = tc27_전자기파_연구력;
        Tech28 = tc28_폭격기_연구력;
        Tech29 = tc29_4기통엔진_연구력;
        Tech30 = tc30_암모니아_연구력;
        Tech31 = tc31_암호학_연구력;
        Tech32 = tc32_탱크_연구력;
        Tech33 = tc33_급속동결_연구력;
        Tech34 = tc34_항생재_연구력;
        Tech35 = tc35_나일론_연구력;
        Tech36 = tc36_제트엔진_연구력;
        Tech37 = tc37_우라늄_연구력;
    }

    void Start()
    {
        MainTechPanel.SetActive(false);
        Noti.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
    }

    void Update()
    {
        AutoHidingHandle();
        TechUpButtonCheck();
        TechAnim();
        ExceptionRule();
    }

    public void ButtonNotiOff()
    {
        Noti.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
    }

    void AutoHidingHandle()
    {
        Image im1 = SBHandle_IND.GetComponent<Image>();
        Image im2 = SBHandle_WAR.GetComponent<Image>();

        im1.color = new Color(im1.color.r, im1.color.g, im1.color.b, im1.color.a - 0.02f);
        if (SbTech_IND.value != CurrentHandleValue_IND)
        {
            im1.color = new Color32(255, 255, 255, 255);
            CurrentHandleValue_IND = SbTech_IND.value;
        }

        im2.color = new Color(im2.color.r, im2.color.g, im2.color.b, im2.color.a - 0.02f);
        if (SbTech_WAR.value != CurrentHandleValue_WAR)
        {
            im2.color = new Color32(255, 255, 255, 255);
            CurrentHandleValue_WAR = SbTech_WAR.value;
        }
    }

    /* ==================================================================================================== */

    public void UpTech() // 연구 상세정보 진입 후, '연구하기 버튼'에 대입
    {
        if (PanelNum == 1)
        {
            UpTechLogic2(Tech1, tYear1, ref Tech1Complete, ref TechIcon1, TechCplImg1, ref TechIcon2, ref TechIcon3, ref ProdBtn1);
        }
        else if (PanelNum == 2)
        {
            UpTechLogic2x(Tech2, tYear2, ref Tech2Complete, ref TechIcon2, TechCplImg2, ref TechIcon5, ref TechIcon7);
        }
        else if (PanelNum == 3)
        {
            UpTechLogic1(Tech3, tYear3, ref Tech3Complete, ref TechIcon3, TechCplImg3, ref TechIcon4, ref ProdBtn3);
        }
        else if (PanelNum == 4)
        {
            UpTechLogic1(Tech4, tYear4, ref Tech4Complete, ref TechIcon4, TechCplImg4, ref TechIcon6, ref ProdBtn4);
        }
        else if (PanelNum == 5)
        {
            UpTechLogic0(Tech5, tYear5, ref Tech5Complete, ref TechIcon5, TechCplImg5, ref ProdBtn5);
        }
        else if (PanelNum == 6)
        {
            UpTechLogic0(Tech6, tYear6, ref Tech6Complete, ref TechIcon6, TechCplImg6, ref ProdBtn6);
        }
        else if (PanelNum == 7)
        {
            UpTechLogic2(Tech7, tYear7, ref Tech7Complete, ref TechIcon7, TechCplImg7, ref TechIcon8, ref TechIcon10, ref ProdBtn7);
        }
        else if (PanelNum == 8)
        {
            UpTechLogic1(Tech8, tYear8, ref Tech8Complete, ref TechIcon8, TechCplImg8, ref TechIcon9, ref ProdBtn8);
        }
        else if (PanelNum == 9)
        {
            UpTechLogic1(Tech9, tYear9, ref Tech9Complete, ref TechIcon9, TechCplImg9, ref TechIcon13, ref ProdBtn9);
        }
        else if (PanelNum == 10)
        {
            UpTechLogic2(Tech10, tYear10, ref Tech10Complete, ref TechIcon10, TechCplImg10, ref TechIcon11, ref TechIcon12, ref ProdBtn10);
        }
        else if (PanelNum == 11)
        {
            UpTechLogic1(Tech11, tYear11, ref Tech11Complete, ref TechIcon11, TechCplImg11, ref TechIcon14, ref ProdBtn11);
        }
        else if (PanelNum == 12)
        {
            UpTechLogic0(Tech12, tYear12, ref Tech12Complete, ref TechIcon12, TechCplImg12, ref ProdBtn12);
        }
        else if (PanelNum == 13)
        {
            UpTechLogic1(Tech13, tYear13, ref Tech13Complete, ref TechIcon13, TechCplImg13, ref TechIcon15, ref ProdBtn13);
        }
        else if (PanelNum == 14)
        {
            UpTechLogic2(Tech14, tYear14, ref Tech14Complete, ref TechIcon14, TechCplImg14, ref TechIcon16, ref TechIcon17, ref ProdBtn14);
        }
        else if (PanelNum == 15)
        {
            UpTechLogic0(Tech15, tYear15, ref Tech15Complete, ref TechIcon15, TechCplImg15, ref ProdBtn15);
        }
        else if (PanelNum == 16)
        {
            UpTechLogic1x(Tech16, tYear16, ref Tech16Complete, ref TechIcon16, TechCplImg16, ref TechIcon16);
        }
        else if (PanelNum == 17)
        {
            UpTechLogic1(Tech17, tYear17, ref Tech17Complete, ref TechIcon17, TechCplImg17, ref TechIcon20, ref ProdBtn17);
        }
        else if (PanelNum == 18)
        {
            UpTechLogic0(Tech18, tYear18, ref Tech18Complete, ref TechIcon18, TechCplImg18, ref ProdBtn18);
        }
        else if (PanelNum == 19)
        {
            UpTechLogic0(Tech19, tYear19, ref Tech19Complete, ref TechIcon19, TechCplImg19, ref ProdBtn19);
        }
        else if (PanelNum == 20)
        {
            UpTechLogic2(Tech20, tYear20, ref Tech20Complete, ref TechIcon20, TechCplImg20, ref TechIcon21, ref TechIcon22, ref ProdBtn20);
        }
        else if (PanelNum == 21)
        {
            UpTechLogic0(Tech21, tYear21, ref Tech21Complete, ref TechIcon21, TechCplImg21, ref ProdBtn21);
        }
        else if (PanelNum == 22)
        {
            UpTechLogic0(Tech22, tYear22, ref Tech22Complete, ref TechIcon22, TechCplImg22, ref ProdBtn22);
        }
        else if (PanelNum == 23)
        {
            UpTechLogic2(Tech23, tYear23, ref Tech23Complete, ref TechIcon23, TechCplImg23, ref TechIcon24, ref TechIcon25, ref ProdBtn23);
        }
        else if (PanelNum == 24)
        {
            UpTechLogic1(Tech24, tYear24, ref Tech24Complete, ref TechIcon24, TechCplImg24, ref TechIcon26, ref ProdBtn24);
        }
        else if (PanelNum == 25)
        {
            UpTechLogic1(Tech25, tYear25, ref Tech25Complete, ref TechIcon25, TechCplImg25, ref TechIcon29, ref ProdBtn25);
        }
        else if (PanelNum == 26)
        {
            UpTechLogic2(Tech26, tYear26, ref Tech26Complete, ref TechIcon26, TechCplImg26, ref TechIcon27, ref TechIcon28, ref ProdBtn26);
        }
        else if (PanelNum == 27)
        {
            UpTechLogic1(Tech27, tYear27, ref Tech27Complete, ref TechIcon27, TechCplImg27, ref TechIcon30, ref ProdBtn27);
        }
        else if (PanelNum == 28)
        {
            UpTechLogic0(Tech28, tYear28, ref Tech28Complete, ref TechIcon28, TechCplImg28, ref ProdBtn28);
        }
        else if (PanelNum == 29)
        {
            UpTechLogic0(Tech29, tYear29, ref Tech29Complete, ref TechIcon29, TechCplImg29, ref ProdBtn29);
        }
        else if (PanelNum == 30)
        {
            UpTechLogic1(Tech30, tYear30, ref Tech30Complete, ref TechIcon30, TechCplImg30, ref TechIcon31, ref ProdBtn30);
        }
        else if (PanelNum == 31)
        {
            UpTechLogic1(Tech31, tYear31, ref Tech31Complete, ref TechIcon31, TechCplImg31, ref TechIcon33, ref ProdBtn31);
        }
        else if (PanelNum == 32)
        {
            UpTechLogic1(Tech32, tYear32, ref Tech32Complete, ref TechIcon32, TechCplImg32, ref TechIcon34, ref ProdBtn32);
        }
        else if (PanelNum == 33)
        {
            UpTechLogic0(Tech33, tYear33, ref Tech33Complete, ref TechIcon33, TechCplImg33, ref ProdBtn33);
        }
        else if (PanelNum == 34)
        {
            UpTechLogic1(Tech34, tYear34, ref Tech34Complete, ref TechIcon34, TechCplImg34, ref TechIcon35, ref ProdBtn34);
        }
        else if (PanelNum == 35)
        {
            UpTechLogic0(Tech35, tYear35, ref Tech35Complete, ref TechIcon35, TechCplImg35, ref ProdBtn35);
        }
        else if (PanelNum == 36)
        {
            UpTechLogic0(Tech36, tYear36, ref Tech36Complete, ref TechIcon36, TechCplImg36, ref ProdBtn36);
        }
        else if (PanelNum == 37)
        {
            UpTechLogic0(Tech37, tYear37, ref Tech37Complete, ref TechIcon37, TechCplImg37, ref ProdBtn37);
        }
    }

    void UpTechLogic0(long a, int b, ref bool c, ref GameObject d, Sprite e, ref GameObject P)
    // a는 필요연구량, b는 증가연도, c는 연구완료판단 변수, d는 해당연구아이콘, e는 연구완료아이콘
    {
        GameManager.science -= a;
        GameManager.years += b;
        c = true;
        TechUpPanel.SetActive(false);
        d.GetComponent<Image>().sprite = e;
        d.GetComponent<Image>().color = new Color32(255, 255, 255, 100);
        P.SetActive(true);
    }

    void UpTechLogic0x(long a, int b, ref bool c, ref GameObject d, Sprite e)
    // a는 필요연구량, b는 증가연도, c는 연구완료판단 변수, d는 해당연구아이콘, e는 연구완료아이콘
    {
        GameManager.science -= a;
        GameManager.years += b;
        c = true;
        TechUpPanel.SetActive(false);
        d.GetComponent<Image>().sprite = e;
        d.GetComponent<Image>().color = new Color32(255, 255, 255, 100);
    }

    void UpTechLogic1(long a, int b, ref bool c, ref GameObject d, Sprite e, ref GameObject f, ref GameObject P)
    // a는 필요연구량, b는 증가연도, c는 연구완료판단 변수, d는 해당연구아이콘, e는 연구완료아이콘. f는 후행연구1
    {
        GameManager.science -= a;
        GameManager.years += b;
        c = true;
        TechUpPanel.SetActive(false);
        d.GetComponent<Image>().sprite = e;
        d.GetComponent<Image>().color = new Color32(255, 255, 255, 100);
        f.GetComponent<Button>().interactable = true;
        P.SetActive(true);
    }

    void UpTechLogic1x(long a, int b, ref bool c, ref GameObject d, Sprite e, ref GameObject f)
    // a는 필요연구량, b는 증가연도, c는 연구완료판단 변수, d는 해당연구아이콘, e는 연구완료아이콘. f는 후행연구1
    {
        GameManager.science -= a;
        GameManager.years += b;
        c = true;
        TechUpPanel.SetActive(false);
        d.GetComponent<Image>().sprite = e;
        d.GetComponent<Image>().color = new Color32(255, 255, 255, 100);
        f.GetComponent<Button>().interactable = true;
    }

    void UpTechLogic2(long a, int b, ref bool c, ref GameObject d, Sprite e, ref GameObject f, ref GameObject g, ref GameObject P)
    // a는 필요연구량, b는 증가연도, c는 연구완료판단 변수, d는 해당연구아이콘, e는 연구완료아이콘. f는 후행연구1, g는 후행연구2
    {
        GameManager.science -= a;
        GameManager.years += b;
        c = true;
        TechUpPanel.SetActive(false);
        d.GetComponent<Image>().sprite = e;
        d.GetComponent<Image>().color = new Color32(255, 255, 255, 100);
        f.GetComponent<Button>().interactable = true;
        g.GetComponent<Button>().interactable = true;
        P.SetActive(true);
    }

    void UpTechLogic2x(long a, int b, ref bool c, ref GameObject d, Sprite e, ref GameObject f, ref GameObject g)
    // a는 필요연구량, b는 증가연도, c는 연구완료판단 변수, d는 해당연구아이콘, e는 연구완료아이콘. f는 후행연구1, g는 후행연구2
    {
        GameManager.science -= a;
        GameManager.years += b;
        c = true;
        TechUpPanel.SetActive(false);
        d.GetComponent<Image>().sprite = e;
        d.GetComponent<Image>().color = new Color32(255, 255, 255, 100);
        f.GetComponent<Button>().interactable = true;
        g.GetComponent<Button>().interactable = true;
    }

    /* ==================================================================================================== */

    void TechAnim() // 업데이트 함수에 대입
    {
        TechAnimLogic2_0_3(ref Tech1AnimC, ref Tech1Complete, ref TechIcon1, ref TechIcon2, ref TechIcon3, ref L2, ref L2_3, ref L3);
        TechAnimLogic2_2_3(ref Tech2AnimC, ref Tech2Complete, ref TechIcon2, ref TechIcon5, ref TechIcon7, ref L2, ref L2_3, ref L5, ref L7_5, ref L7);
        TechAnimLogic1_2_1(ref Tech3AnimC, ref Tech3Complete, ref TechIcon3, ref TechIcon4, ref L3, ref L2_3, ref L4);
        TechAnimLogic1_1_1(ref Tech4AnimC, ref Tech4Complete, ref TechIcon4, ref TechIcon6, ref L4, ref L6);
        TechAnimLogic0_2_0(ref Tech5AnimC, ref Tech5Complete, ref TechIcon5, ref L5, ref L7_5);
        TechAnimLogic0_1_0(ref Tech6AnimC, ref Tech6Complete, ref TechIcon6, ref L6);
        TechAnimLogic2_2_3(ref Tech7AnimC, ref Tech7Complete, ref TechIcon7, ref TechIcon8, ref TechIcon10, ref L7, ref L7_5, ref L8, ref L10_8, ref L10);
        TechAnimLogic1_2_1(ref Tech8AnimC, ref Tech8Complete, ref TechIcon8, ref TechIcon9, ref L8, ref L10_8, ref L9);
        TechAnimLogic1_1_1(ref Tech9AnimC, ref Tech9Complete, ref TechIcon9, ref TechIcon13, ref L9, ref L13);
        TechAnimLogic2_2_3(ref Tech10AnimC, ref Tech10Complete, ref TechIcon10, ref TechIcon11, ref TechIcon12, ref L10, ref L10_8, ref L11, ref L11_12, ref L12);
        TechAnimLogic1_2_1(ref Tech11AnimC, ref Tech11Complete, ref TechIcon11, ref TechIcon14, ref L11, ref L11_12, ref L14);
        TechAnimLogic0_2_0(ref Tech12AnimC, ref Tech12Complete, ref TechIcon12, ref L12, ref L11_12);
        TechAnimLogic1_1_1(ref Tech13AnimC, ref Tech13Complete, ref TechIcon13, ref TechIcon15, ref L13, ref L15);
        TechAnimLogic2_1_3(ref Tech14AnimC, ref Tech14Complete, ref TechIcon14, ref TechIcon16, ref TechIcon17, ref L14, ref L16, ref L17_16, ref L17);
        TechAnimLogic0_1_1(ref Tech15AnimC, ref Tech15Complete, ref TechIcon15, ref L15, ref L19_1);
        TechAnimLogic1_2_1(ref Tech16AnimC, ref Tech16Complete, ref TechIcon16, ref TechIcon18, ref L16, ref L17_16, ref L18);
        TechAnimLogic1_2_3(ref Tech17AnimC, ref Tech17Complete, ref TechIcon17, ref TechIcon20, ref L17, ref L17_16, ref L19_2, ref L20, ref L20_19);
        TechAnimLogic0_1_0(ref Tech18AnimC, ref Tech18Complete, ref TechIcon18, ref L18);
        TechAnimLogic0_3_0(ref Tech19AnimC, ref Tech19Complete, ref TechIcon19, ref L19_1, ref L19_2, ref L20_19);
        TechAnimLogic2_2_3(ref Tech20AnimC, ref Tech20Complete, ref TechIcon20, ref TechIcon21, ref TechIcon22, ref L20, ref L20_19, ref L21, ref L22_21, ref L22);
        TechAnimLogic0_2_0(ref Tech21AnimC, ref Tech21Complete, ref TechIcon21, ref L21, ref L22_21);
        TechAnimLogic0_2_0(ref Tech22AnimC, ref Tech22Complete, ref TechIcon22, ref L22, ref L22_21);

        TechAnimLogic2_0_3(ref Tech23AnimC, ref Tech23Complete, ref TechIcon23, ref TechIcon24, ref TechIcon25, ref L24, ref L24_25, ref L25);
        TechAnimLogic1_2_1(ref Tech24AnimC, ref Tech24Complete, ref TechIcon24, ref TechIcon26, ref L24, ref L24_25, ref L26);
        TechAnimLogic1_2_1(ref Tech25AnimC, ref Tech25Complete, ref TechIcon25, ref TechIcon29, ref L24_25, ref L25, ref L29);
        TechAnimLogic2_1_3(ref Tech26AnimC, ref Tech26Complete, ref TechIcon26, ref TechIcon27, ref TechIcon28, ref L26, ref L27, ref L27_28, ref L28);
        TechAnimLogic1_2_1(ref Tech27AnimC, ref Tech27Complete, ref TechIcon27, ref TechIcon30, ref L27, ref L27_28, ref L30);
        TechAnimLogic0_2_2(ref Tech28AnimC, ref Tech28Complete, ref TechIcon28, ref L27_28, ref L28, ref L28_32, ref L32);
        TechAnimLogic0_1_2(ref Tech29AnimC, ref Tech29Complete, ref TechIcon29, ref L29, ref L29_32, ref L32);
        TechAnimLogic1_1_1(ref Tech30AnimC, ref Tech30Complete, ref TechIcon30, ref TechIcon31, ref L30, ref L31);
        TechAnimLogic1_1_1(ref Tech31AnimC, ref Tech31Complete, ref TechIcon31, ref TechIcon33, ref L31, ref L33);
        TechAnimLogic1_3_1(ref Tech32AnimC, ref Tech32Complete, ref TechIcon32, ref TechIcon34, ref L28_32, ref L29_32, ref L32, ref L34);
        TechAnimLogic0_1_2(ref Tech33AnimC, ref Tech33Complete, ref TechIcon33, ref L33, ref L36_1, ref L36_3);
        TechAnimLogic1_1_6(ref Tech34AnimC, ref Tech34Complete, ref TechIcon34, ref TechIcon35, ref L34, ref L35, ref L36_2, ref L36_3, ref L37_1, ref L37_36, ref L37_35);
        TechAnimLogic0_2_1(ref Tech35AnimC, ref Tech35Complete, ref TechIcon35, ref L35, ref L37_35, ref L37_2);
        TechAnimLogic0_5_1(ref Tech36AnimC, ref Tech36Complete, ref TechIcon36, ref L36_1, ref L36_2, ref L36_3, ref L37_35, ref L37_36, ref L37_3);
        TechAnimLogic0_5_0(ref Tech37AnimC, ref Tech37Complete, ref TechIcon37, ref L37_1, ref L37_2, ref L37_3, ref L37_35, ref L37_36);

    }

    void TechAnimLogic0_1_0(ref bool a, ref bool b, ref GameObject c, ref GameObject L__1)
    //후행연구 0개, 선행라인 1개, 후행라인 0개
    {
        if (a == false && b == true)
        {
            c.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            L__1.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            if (c.GetComponent<Image>().color.a > 2.7)
            {
                a = true;
            }
        }
    }

    void TechAnimLogic0_1_1(ref bool a, ref bool b, ref GameObject c, ref GameObject L__1, ref GameObject L__a)
    //후행연구 0개, 선행라인 1개, 후행라인 1개
    {
        if (a == false && b == true)
        {
            c.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            L__1.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__a.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            if (c.GetComponent<Image>().color.a > 2.7)
            {
                a = true;
            }
        }
    }

    void TechAnimLogic0_1_2(ref bool a, ref bool b, ref GameObject c, ref GameObject L__1, ref GameObject L__a, ref GameObject L__b)
    //후행연구 0개, 선행라인 1개, 후행라인 2개
    {
        if (a == false && b == true)
        {
            c.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            L__1.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__a.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            L__b.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            if (c.GetComponent<Image>().color.a > 2.7)
            {
                a = true;
            }
        }
    }

    void TechAnimLogic0_2_0(ref bool a, ref bool b, ref GameObject c, ref GameObject L__1, ref GameObject L__2)
    //후행연구 0개, 선행라인 2개, 후행라인 0개
    {
        if (a == false && b == true)
        {
            c.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            L__1.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__2.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            if (c.GetComponent<Image>().color.a > 2.7)
            {
                a = true;
            }
        }
    }

    void TechAnimLogic0_2_1(ref bool a, ref bool b, ref GameObject c, ref GameObject L__1, ref GameObject L__2, ref GameObject L__a)
    //후행연구 0개, 선행라인 2개, 후행라인 1개
    {
        if (a == false && b == true)
        {
            c.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            L__1.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__2.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__a.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            if (c.GetComponent<Image>().color.a > 2.7)
            {
                a = true;
            }
        }
    }

    void TechAnimLogic0_2_2(ref bool a, ref bool b, ref GameObject c, ref GameObject L__1, ref GameObject L__2, ref GameObject L__a, ref GameObject L__b)
    //후행연구 0개, 선행라인 2개, 후행라인 2개
    {
        if (a == false && b == true)
        {
            c.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            L__1.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__2.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__a.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            L__b.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            if (c.GetComponent<Image>().color.a > 2.7)
            {
                a = true;
            }
        }
    }

    void TechAnimLogic0_3_0(ref bool a, ref bool b, ref GameObject c, ref GameObject L__1, ref GameObject L__2, ref GameObject L__3)
    //후행연구 0개, 선행라인 3개, 후행라인 0개
    {
        if (a == false && b == true)
        {
            c.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            L__1.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__2.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__3.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            if (c.GetComponent<Image>().color.a > 2.7)
            {
                a = true;
            }
        }
    }

    void TechAnimLogic0_5_0(ref bool a, ref bool b, ref GameObject c, ref GameObject L__1, ref GameObject L__2, ref GameObject L__3, ref GameObject L__4, ref GameObject L__5)
    //후행연구 0개, 선행라인 5개, 후행라인 0개
    {
        if (a == false && b == true)
        {
            c.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            L__1.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__2.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__3.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__4.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__5.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            if (c.GetComponent<Image>().color.a > 2.7)
            {
                a = true;
            }
        }
    }

    void TechAnimLogic0_5_1(ref bool a, ref bool b, ref GameObject c, ref GameObject L__1, ref GameObject L__2, ref GameObject L__3, ref GameObject L__4, ref GameObject L__5, ref GameObject L__a)
    //후행연구 0개, 선행라인 5개, 후행라인 1개
    {
        if (a == false && b == true)
        {
            c.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            L__1.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__2.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__3.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__4.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__5.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__a.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            if (c.GetComponent<Image>().color.a > 2.7)
            {
                a = true;
            }
        }
    }

    void TechAnimLogic1_1_1(ref bool a, ref bool b, ref GameObject c, ref GameObject d, ref GameObject L__1, ref GameObject L__a)
    //후행연구 1개, 선행라인 1개, 후행라인 1개
    {
        if (a == false && b == true)
        {
            c.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            d.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            L__1.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__a.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            if (c.GetComponent<Image>().color.a > 2.7)
            {
                a = true;
            }
        }
    }

    void TechAnimLogic1_1_6(ref bool a, ref bool b, ref GameObject c, ref GameObject d, ref GameObject L__1, ref GameObject L__a, ref GameObject L__b, ref GameObject L__c, ref GameObject L__d, ref GameObject L__e, ref GameObject L__f)
    //후행연구 1개, 선행라인 1개, 후행라인 6개
    {
        if (a == false && b == true)
        {
            c.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            d.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            L__1.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__a.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            L__b.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            L__c.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            L__d.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            L__e.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            L__f.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            if (c.GetComponent<Image>().color.a > 2.7)
            {
                a = true;
            }
        }
    }

    void TechAnimLogic1_2_1(ref bool a, ref bool b, ref GameObject c, ref GameObject d, ref GameObject L__1, ref GameObject L__2, ref GameObject L__a)
    //후행연구 1개, 선행라인 2개, 후행라인 1개
    {
        if (a == false && b == true)
        {
            c.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            d.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            L__1.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__2.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__a.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            if (c.GetComponent<Image>().color.a > 2.7)
            {
                a = true;
            }
        }
    }

    void TechAnimLogic1_2_3(ref bool a, ref bool b, ref GameObject c, ref GameObject d, ref GameObject L__1, ref GameObject L__2, ref GameObject L__a, ref GameObject L__b, ref GameObject L__c)
    //후행연구 1개, 선행라인 2개, 후행라인 3개
    {
        if (a == false && b == true)
        {
            c.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            d.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            L__1.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__2.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__a.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            L__b.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            L__c.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            if (c.GetComponent<Image>().color.a > 2.7)
            {
                a = true;
            }
        }
    }

    void TechAnimLogic1_3_1(ref bool a, ref bool b, ref GameObject c, ref GameObject d, ref GameObject L__1, ref GameObject L__2, ref GameObject L__3, ref GameObject L__a)
    //후행연구 1개, 선행라인 3개, 후행라인 1개
    {
        if (a == false && b == true)
        {
            c.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            d.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            L__1.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__2.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__3.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__a.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            if (c.GetComponent<Image>().color.a > 2.7)
            {
                a = true;
            }
        }
    }

    void TechAnimLogic2_0_3(ref bool a, ref bool b, ref GameObject c, ref GameObject d, ref GameObject e, ref GameObject L__a, ref GameObject L__b, ref GameObject L__c)
    //a는 테크에님, b는 연구완료판단, c는 해당 연구아이콘, d 후행연구아이콘1, e는 후행연구아이콘2, 후행라인 3개
    {
        if (a == false && b == true)
        {
            c.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            d.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            e.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            L__a.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            L__b.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            L__c.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            if (c.GetComponent<Image>().color.a > 2.7)
            {
                a = true;
            }
        }
    }

    void TechAnimLogic2_1_3(ref bool a, ref bool b, ref GameObject c, ref GameObject d, ref GameObject e, ref GameObject L__1, ref GameObject L__a, ref GameObject L__b, ref GameObject L__c)
    //후행연구 2개, 선행라인 1개, 후행라인 3개
    {
        if (a == false && b == true)
        {
            c.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            d.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            e.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            L__1.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__a.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            L__b.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            L__c.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            if (c.GetComponent<Image>().color.a > 2.7)
            {
                a = true;
            }
        }
    }

    void TechAnimLogic2_2_3(ref bool a, ref bool b, ref GameObject c, ref GameObject d, ref GameObject e, ref GameObject L__1, ref GameObject L__2, ref GameObject L__a, ref GameObject L__b, ref GameObject L__c)
    //후행연구 2개, 선행라인 2개, 후행라인 3개
    {
        if (a == false && b == true)
        {
            c.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            d.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            e.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            L__1.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__2.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__a.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            L__b.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            L__c.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            if (c.GetComponent<Image>().color.a > 2.7)
            {
                a = true;
            }
        }
    }

    /* ==================================================================================================== */

    public void Tech_1_Oepn() // 1번(증기기관) 연구 아이콘(버튼에 대입)을 눌렀을 때
    {
        title.text = "증기기관";
        exp.text = "증기기관은 수증기를 통해 열 에너지를 만들고, 그 에너지를 통해 운동한다.";
        Icon.GetComponent<Image>().sprite = TechCplImg1;
        NeedScience.text = Tech1.ToString("###,###");
        TechOpenCom(ref Tech1Complete);
        PanelNum = 1;
        TechUpPanel.SetActive(true);
    }

    public void Tech_2_Oepn()
    {
        title.text = "증기선";
        exp.text = "증기기관을 동력으로 나아가는 기선이다.";
        Icon.GetComponent<Image>().sprite = TechCplImg2;
        NeedScience.text = Tech2.ToString("###,###");
        TechOpenCom(ref Tech2Complete);
        PanelNum = 2;
        TechUpPanel.SetActive(true);
    }

    public void Tech_3_Oepn()
    {
        title.text = "수직기";
        exp.text = "사람의 손발로 움직여 베를 짜는 기계이다. 기존보다 발전합니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg3;
        NeedScience.text = Tech3.ToString("###,###");
        TechOpenCom(ref Tech3Complete);
        PanelNum = 3;
        TechUpPanel.SetActive(true);
    }

    public void Tech_4_Oepn()
    {
        title.text = "방적기";
        exp.text = "동물과 식물에서 추출된 섬유로 실을 뽑는 기계이다. 직조가 자동화됩니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg4;
        NeedScience.text = Tech4.ToString("###,###");
        TechOpenCom(ref Tech4Complete);
        PanelNum = 4;
        TechUpPanel.SetActive(true);
    }

    public void Tech_5_Oepn()
    {
        title.text = "증기기관+";
        exp.text = "기존 증기기관에서 응축기를 분리함으로써 열 능률을 올립니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg5;
        NeedScience.text = Tech5.ToString("###,###");
        TechOpenCom(ref Tech5Complete);
        PanelNum = 5;
        TechUpPanel.SetActive(true);
    }

    public void Tech_6_Oepn()
    {
        title.text = "방직기";
        exp.text = "실을 얽고, 천을 만든다. 자동화 됩니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg6;
        NeedScience.text = Tech6.ToString("###,###");
        TechOpenCom(ref Tech6Complete);
        PanelNum = 6;
        TechUpPanel.SetActive(true);
    }

    public void Tech_7_Oepn()
    {
        title.text = "기체화학";
        exp.text = "진공의 개념을 받아드리고 공기의 물리적 성질을 조사할 수 있습니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg7;
        NeedScience.text = Tech7.ToString("###,###");
        TechOpenCom(ref Tech7Complete);
        PanelNum = 7;
        TechUpPanel.SetActive(true);
    }

    public void Tech_8_Oepn()
    {
        title.text = "동물전기";
        exp.text = "동물이 전기를 만들어 내는 것을 발견하다. 전류 연구의 방향을 제시합니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg8;
        NeedScience.text = Tech8.ToString("###,###");
        TechOpenCom(ref Tech8Complete);
        PanelNum = 8;
        TechUpPanel.SetActive(true);
    }

    public void Tech_9_Oepn()
    {
        title.text = "대기전기";
        exp.text = "대기중에 존재하는 전기 현상에 대해서 관심을 가집니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg9;
        NeedScience.text = Tech9.ToString("###,###");
        TechOpenCom(ref Tech9Complete);
        PanelNum = 9;
        TechUpPanel.SetActive(true);
    }

    public void Tech_10_Oepn()
    {
        title.text = "석탄";
        exp.text = "불타는 돌. 화력발전과 연료로 산업화를 가속시킵니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg10;
        NeedScience.text = Tech10.ToString("###,###");
        TechOpenCom(ref Tech10Complete);
        PanelNum = 10;
        TechUpPanel.SetActive(true);
    }

    public void Tech_11_Oepn()
    {
        title.text = "철강업";
        exp.text = "철은 역사적으로 오랜 기간 동안 있어왔습니다. 이제는 강철의 시대입니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg11;
        NeedScience.text = Tech11.ToString("###,###");
        TechOpenCom(ref Tech11Complete);
        PanelNum = 11;
        TechUpPanel.SetActive(true);
    }

    public void Tech_12_Oepn()
    {
        title.text = "증기압축";
        exp.text = "가스를 압축하여 액체상태로 만듭니다. 기체로 열을 조절할 수 있습니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg12;
        NeedScience.text = Tech12.ToString("###,###");
        TechOpenCom(ref Tech12Complete);
        PanelNum = 12;
        TechUpPanel.SetActive(true);
    }

    public void Tech_13_Oepn()
    {
        title.text = "자기력";
        exp.text = "자기장을 변화시키면 전기장과 전류를 유도할 수 있습니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg13;
        NeedScience.text = Tech13.ToString("###,###");
        TechOpenCom(ref Tech13Complete);
        PanelNum = 13;
        TechUpPanel.SetActive(true);
    }

    public void Tech_14_Oepn()
    {
        title.text = "열역학";
        exp.text = "열과 에너지에 대한 연구입니다. 열에 따라 물질의 형상 변화에 대해 알게됩니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg14;
        NeedScience.text = Tech14.ToString("###,###");
        TechOpenCom(ref Tech14Complete);
        PanelNum = 14;
        TechUpPanel.SetActive(true);
    }

    public void Tech_15_Oepn()
    {
        title.text = "유선통신";
        exp.text = "선과 선이 연결되는 곳이면, 정보를 전달할 수 있습니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg15;
        NeedScience.text = Tech15.ToString("###,###");
        TechOpenCom(ref Tech15Complete);
        PanelNum = 15;
        TechUpPanel.SetActive(true);
    }

    public void Tech_16_Oepn()
    {
        title.text = "탄도학";
        exp.text = "날라가는 모든 비상체는 힘에 의해 최종목표까지 도달할 수 있어야 합니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg16;
        NeedScience.text = Tech16.ToString("###,###");
        TechOpenCom(ref Tech16Complete);
        PanelNum = 16;
        TechUpPanel.SetActive(true);
    }

    public void Tech_17_Oepn()
    {
        title.text = "나이트로글리세린";
        exp.text = "폭발성과 유독성을 가진 투명 무색의 액체입니다. 매우 불안정합니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg17;
        NeedScience.text = Tech17.ToString("###,###");
        TechOpenCom(ref Tech17Complete);
        PanelNum = 17;
        TechUpPanel.SetActive(true);
    }

    public void Tech_18_Oepn()
    {
        title.text = "소리";
        exp.text = "전통적인 감각기관을 자극하는 요소입니다. 이제는 시각으로 소리를 볼 수 있습니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg18;
        NeedScience.text = Tech18.ToString("###,###");
        TechOpenCom(ref Tech18Complete);
        PanelNum = 18;
        TechUpPanel.SetActive(true);
    }

    public void Tech_19_Oepn()
    {
        title.text = "전류진동";
        exp.text = "진동하는 전기장이 발생하면 주기적으로 진동하는 자기장이 발생합니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg19;
        NeedScience.text = Tech19.ToString("###,###");
        TechOpenCom(ref Tech19Complete);
        PanelNum = 19;
        TechUpPanel.SetActive(true);
    }

    public void Tech_20_Oepn()
    {
        title.text = "필라멘트";
        exp.text = "진공관 내부에 전류를 통하게 하는 실처럼 가는 선입니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg20;
        NeedScience.text = Tech20.ToString("###,###");
        TechOpenCom(ref Tech20Complete);
        PanelNum = 20;
        TechUpPanel.SetActive(true);
    }

    public void Tech_21_Oepn()
    {
        title.text = "무선통신";
        exp.text = "이제 정보를 주고 받는데 공간적 제약을 극복합니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg21;
        NeedScience.text = Tech21.ToString("###,###");
        TechOpenCom(ref Tech21Complete);
        PanelNum = 21;
        TechUpPanel.SetActive(true);
    }

    public void Tech_22_Oepn()
    {
        title.text = "비행";
        exp.text = "엔진을 이용하여 하늘을 누릴 수 있습니다. 더 이상 새들이 독점하는 공간이 아닙니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg22;
        NeedScience.text = Tech22.ToString("###,###");
        TechOpenCom(ref Tech22Complete);
        PanelNum = 22;
        TechUpPanel.SetActive(true);
    }

    public void Tech_23_Oepn()
    {
        title.text = "개틀링건";
        exp.text = "회전운동을 왕복운동으로 바꾸어 여러 개의 총신에서 높은 발사력을 지닙니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg23;
        NeedScience.text = Tech23.ToString("###,###");
        TechOpenCom(ref Tech23Complete);
        PanelNum = 23;
        TechUpPanel.SetActive(true);
    }

    public void Tech_24_Oepn()
    {
        title.text = "진공";
        exp.text = "외부로부터 어떠한 작용도 내부의 물질도 존재하지 않는 공간입니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg24;
        NeedScience.text = Tech24.ToString("###,###");
        TechOpenCom(ref Tech24Complete);
        PanelNum = 24;
        TechUpPanel.SetActive(true);
    }

    public void Tech_25_Oepn()
    {
        title.text = "오프셋인쇄";
        exp.text = "인쇄판과 고무롤러를 사용해 종이에 인쇄하는 방법입니다.  대량의 인쇄가 가능합니다";
        Icon.GetComponent<Image>().sprite = TechCplImg25;
        NeedScience.text = Tech25.ToString("###,###");
        TechOpenCom(ref Tech25Complete);
        PanelNum = 25;
        TechUpPanel.SetActive(true);
    }

    public void Tech_26_Oepn()
    {
        title.text = "냉각순환";
        exp.text = "열을 빼앗아 온도를 낮춥니다. 원하는 공간의 온도를 조절할 수 있습니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg26;
        NeedScience.text = Tech26.ToString("###,###");
        TechOpenCom(ref Tech26Complete);
        PanelNum = 26;
        TechUpPanel.SetActive(true);
    }

    public void Tech_27_Oepn()
    {
        title.text = "전자기파";
        exp.text = "특정 전자기적인 과정에서 복사되는 에너지입니다. 볼 순 없지만 사용할 순 있습니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg27;
        NeedScience.text = Tech27.ToString("###,###");
        TechOpenCom(ref Tech27Complete);
        PanelNum = 27;
        TechUpPanel.SetActive(true);
    }

    public void Tech_28_Oepn()
    {
        title.text = "폭격기";
        exp.text = "폭탄을 싣고 적의 시설이나 진지를 폭격하는 항공기체입니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg28;
        NeedScience.text = Tech28.ToString("###,###");
        TechOpenCom(ref Tech28Complete);
        PanelNum = 28;
        TechUpPanel.SetActive(true);
    }

    public void Tech_29_Oepn()
    {
        title.text = "4기통엔진";
        exp.text = "실린더의 개수가 4개인 엔진입니다. 기계의 심장입니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg29;
        NeedScience.text = Tech29.ToString("###,###");
        TechOpenCom(ref Tech29Complete);
        PanelNum = 29;
        TechUpPanel.SetActive(true);
    }

    public void Tech_30_Oepn()
    {
        title.text = "암모니아";
        exp.text = "자극적인 악취가 나는 무색의 기체입니다. 인공적으로 만들 수 있습니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg30;
        NeedScience.text = Tech30.ToString("###,###");
        TechOpenCom(ref Tech30Complete);
        PanelNum = 30;
        TechUpPanel.SetActive(true);
    }

    public void Tech_31_Oepn()
    {
        title.text = "암호학";
        exp.text = "정보의 소통이 많아짐에 따라 평문에 기밀성을 더하는 연구입니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg31;
        NeedScience.text = Tech31.ToString("###,###");
        TechOpenCom(ref Tech31Complete);
        PanelNum = 31;
        TechUpPanel.SetActive(true);
    }

    public void Tech_32_Oepn()
    {
        title.text = "탱크";
        exp.text = "무한궤도를 장착한 기갑 전투 차량입니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg32;
        NeedScience.text = Tech32.ToString("###,###");
        TechOpenCom(ref Tech32Complete);
        PanelNum = 32;
        TechUpPanel.SetActive(true);
    }

    public void Tech_33_Oepn()
    {
        title.text = "급속동결";
        exp.text = "최대얼음결정생성대의 온도대역을 빠르게 통과하는 기술입니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg33;
        NeedScience.text = Tech33.ToString("###,###");
        TechOpenCom(ref Tech33Complete);
        PanelNum = 33;
        TechUpPanel.SetActive(true);
    }

    public void Tech_34_Oepn()
    {
        title.text = "항생재";
        exp.text = "세균을 죽이거나 세균의 성장을 억제하는 약입니다. 인공적으로 제공 가능합니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg34;
        NeedScience.text = Tech34.ToString("###,###");
        TechOpenCom(ref Tech34Complete);
        PanelNum = 34;
        TechUpPanel.SetActive(true);
    }

    public void Tech_35_Oepn()
    {
        title.text = "나일론";
        exp.text = "인공적으로 만들어 낸 합성 섬유입니다. 가볍고 부드러우며 탄력적입니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg35;
        NeedScience.text = Tech35.ToString("###,###");
        TechOpenCom(ref Tech35Complete);
        PanelNum = 35;
        TechUpPanel.SetActive(true);
    }

    public void Tech_36_Oepn()
    {
        title.text = "제트엔진";
        exp.text = "고온의 가스를 분출하여 반작용을 통해 추진력을 얻는 엔진입니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg36;
        NeedScience.text = Tech36.ToString("###,###");
        TechOpenCom(ref Tech36Complete);
        PanelNum = 36;
        TechUpPanel.SetActive(true);
    }

    public void Tech_37_Oepn()
    {
        title.text = "우라늄";
        exp.text = "α붕괴를 하는 광택이 있는 백색 고체의 금속입니다. 피폭의 위험이 있습니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg37;
        NeedScience.text = Tech37.ToString("###,###");
        TechOpenCom(ref Tech37Complete);
        PanelNum = 37;
        TechUpPanel.SetActive(true);
    }

    /*
    public void Tech__Oepn()
    {
        title.text = "";
        exp.text = "";
        Icon.GetComponent<Image>().sprite = TechCplImg;
        NeedScience.text = Tech.ToString("###,###");
        TechOpenCom(ref TechComplete);
        PanelNum = ;
        TechUpPanel.SetActive(true);
    }
    */

    void TechOpenCom(ref bool a)
    {
        if (a == true)
        {
            NeedScience.text = "연구 완료";
        }
    }

    /* ==================================================================================================== */

    void TechUpButtonCheck() // 업데이트 함수에 대입
    {
        TUBC_Logic0(1, ref Tech1Complete, Tech1);
        TUBC_Logic1(2, ref Tech2Complete, Tech2, ref Tech1Complete);
        TUBC_Logic1(3, ref Tech3Complete, Tech3, ref Tech1Complete);
        TUBC_Logic1(4, ref Tech4Complete, Tech4, ref Tech3Complete);
        TUBC_Logic1(5, ref Tech5Complete, Tech5, ref Tech2Complete);
        TUBC_Logic1(6, ref Tech6Complete, Tech6, ref Tech4Complete);
        TUBC_Logic1(7, ref Tech7Complete, Tech7, ref Tech2Complete);
        TUBC_Logic1(8, ref Tech8Complete, Tech8, ref Tech7Complete);
        TUBC_Logic1(9, ref Tech9Complete, Tech9, ref Tech8Complete);
        TUBC_Logic1(10, ref Tech10Complete, Tech10, ref Tech7Complete);
        TUBC_Logic1(11, ref Tech11Complete, Tech11, ref Tech10Complete);
        TUBC_Logic1(12, ref Tech12Complete, Tech12, ref Tech10Complete);
        TUBC_Logic1(13, ref Tech13Complete, Tech13, ref Tech9Complete);
        TUBC_Logic1(14, ref Tech14Complete, Tech14, ref Tech11Complete);
        TUBC_Logic1(15, ref Tech15Complete, Tech15, ref Tech13Complete);
        TUBC_Logic1(16, ref Tech16Complete, Tech16, ref Tech14Complete);
        TUBC_Logic1(17, ref Tech17Complete, Tech17, ref Tech14Complete);
        TUBC_Logic1(18, ref Tech18Complete, Tech18, ref Tech16Complete);
        TUBC_Logic2(19, ref Tech19Complete, Tech19, ref Tech15Complete, ref Tech17Complete);
        TUBC_Logic1(20, ref Tech20Complete, Tech20, ref Tech17Complete);
        TUBC_Logic1(21, ref Tech21Complete, Tech21, ref Tech20Complete);
        TUBC_Logic1(22, ref Tech22Complete, Tech22, ref Tech20Complete);
        TUBC_Logic0(23, ref Tech23Complete, Tech23);
        TUBC_Logic1(24, ref Tech24Complete, Tech24, ref Tech23Complete);
        TUBC_Logic1(25, ref Tech25Complete, Tech25, ref Tech23Complete);
        TUBC_Logic1(26, ref Tech26Complete, Tech26, ref Tech24Complete);
        TUBC_Logic1(27, ref Tech27Complete, Tech27, ref Tech26Complete);
        TUBC_Logic1(28, ref Tech28Complete, Tech28, ref Tech26Complete);
        TUBC_Logic1(29, ref Tech29Complete, Tech29, ref Tech25Complete);
        TUBC_Logic1(30, ref Tech30Complete, Tech30, ref Tech27Complete);
        TUBC_Logic1(31, ref Tech31Complete, Tech31, ref Tech30Complete);
        TUBC_Logic2(32, ref Tech32Complete, Tech32, ref Tech28Complete, ref Tech29Complete);
        TUBC_Logic1(33, ref Tech33Complete, Tech33, ref Tech31Complete);
        TUBC_Logic1(34, ref Tech34Complete, Tech34, ref Tech32Complete);
        TUBC_Logic1(35, ref Tech35Complete, Tech35, ref Tech34Complete);
        TUBC_Logic2(36, ref Tech36Complete, Tech36, ref Tech33Complete, ref Tech34Complete);
        TUBC_Logic3(37, ref Tech37Complete, Tech37, ref Tech34Complete, ref Tech35Complete, ref Tech36Complete);

    }

    void TUBC_Logic0(short a, ref bool b, long c) // a는 PanelNum,  b는 연구완료 판단 변수,  c는 필요 연구량
    {
        if (PanelNum == a)
        {
            if (b == false && GameManager.science >= c)
            {
                TechUpBtn.interactable = true;
            }
            else
            {
                TechUpBtn.interactable = false;
            }
        }
    }

    void TUBC_Logic1(short a, ref bool b, long c, ref bool d) // a는 PanelNum,  b는 연구완료 판단 변수,  c는 필요 연구량,  d는 필요 연구1
    {
        if (PanelNum == a)
        {
            if (b == false && GameManager.science >= c && d == true)
            {
                TechUpBtn.interactable = true;
            }
            else
            {
                TechUpBtn.interactable = false;
            }
        }
    }

    void TUBC_Logic2(short a, ref bool b, long c, ref bool d, ref bool e) // a는 PanelNum,  b는 연구완료 판단 변수,  c는 필요 연구량,  d는 필요 연구1,  e는 필요 연구2
    {
        if (PanelNum == a)
        {
            if (b == false && GameManager.science >= c && d == true && e == true)
            {
                TechUpBtn.interactable = true;
            }
            else
            {
                TechUpBtn.interactable = false;
            }
        }
    }

    void TUBC_Logic3(short a, ref bool b, long c, ref bool d, ref bool e, ref bool f) // a는 PanelNum,  b는 연구완료 판단 변수,  c는 필요 연구량,  d는 필요 연구1,  e는 필요 연구2,  f는 필요 연구3
    {
        if (PanelNum == a)
        {
            if (b == false && GameManager.science >= c && d == true && e == true && f == true)
            {
                TechUpBtn.interactable = true;
            }
            else
            {
                TechUpBtn.interactable = false;
            }
        }
    }

    /* ==================================================================================================== */

    void ExceptionRule() // 예외규칙. 업데이트 함수에 대입
    {
        if (Tech15Complete == true && Tech17Complete == true && Tech19Complete == false) // 유선통신(15) + 나이트로글리세린(17) -> 전류진동(19)
        {
            TechIcon19.GetComponent<Button>().interactable = true;
            if (TechIcon19.GetComponent<Image>().color.a < 2.7)
            {
                TechIcon19.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            }
        }

        if (Tech28Complete == true && Tech29Complete == true && Tech32Complete == false) // 폭격기(28) + 4기통엔진(29) -> 탱크(32)
        {
            TechIcon32.GetComponent<Button>().interactable = true;
            if (TechIcon32.GetComponent<Image>().color.a < 2.7)
            {
                TechIcon32.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            }
        }

        if (Tech33Complete == true && Tech34Complete == true && Tech36Complete == false) // 급속동결(33) + 항생제(34) -> 제트엔진(36)
        {
            TechIcon36.GetComponent<Button>().interactable = true;
            if (TechIcon36.GetComponent<Image>().color.a < 2.7)
            {
                TechIcon36.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            }
        }

        if (Tech34Complete == true && Tech35Complete == true && Tech36Complete == true && Tech37Complete == false) // 항생제(34) + 나일론(35) + 제트엔진(36) -> 우라늄(37)
        {
            TechIcon36.GetComponent<Button>().interactable = true;
            if (TechIcon36.GetComponent<Image>().color.a < 2.7)
            {
                TechIcon36.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            }
        }
    }
}