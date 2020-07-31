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
    bool Tech60AnimC;
    bool Tech61AnimC;
    bool Tech62AnimC;
    bool Tech63AnimC;
    bool Tech64AnimC;
    bool Tech65AnimC;
    bool Tech66AnimC;
    bool Tech67AnimC;
    bool Tech68AnimC;
    bool Tech69AnimC;
    bool Tech70AnimC;

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
    public GameObject L39;
    public GameObject L40;
    public GameObject L40_39;
    public GameObject L41;
    public GameObject L42;
    public GameObject L43;
    public GameObject L43_1;
    public GameObject L43_2;
    public GameObject L43_3;
    public GameObject L44;
    public GameObject L45;
    public GameObject L46;
    public GameObject L47;
    public GameObject L48;
    public GameObject L49;
    public GameObject L50;
    public GameObject L50_48;
    public GameObject L50_47;
    public GameObject L51;
    public GameObject L52;
    public GameObject L53;
    public GameObject L53_52;
    public GameObject L54;
    public GameObject L55;
    public GameObject L57;
    public GameObject L58;
    public GameObject L58_57;
    public GameObject L59;
    public GameObject L60;
    public GameObject L61;
    public GameObject L62;
    public GameObject L63_1;
    public GameObject L63_2;
    public GameObject L63_3;
    public GameObject L64;
    public GameObject L65;
    public GameObject L65_64;
    public GameObject L66;
    public GameObject L67_1;
    public GameObject L67_2;
    public GameObject L67_3;
    public GameObject L68;
    public GameObject L69;
    public GameObject L70;


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
    public GameObject TechIcon38;
    public GameObject TechIcon39;
    public GameObject TechIcon40;
    public GameObject TechIcon41;
    public GameObject TechIcon42;
    public GameObject TechIcon43;
    public GameObject TechIcon44;
    public GameObject TechIcon45;
    public GameObject TechIcon46;
    public GameObject TechIcon47;
    public GameObject TechIcon48;
    public GameObject TechIcon49;
    public GameObject TechIcon50;
    public GameObject TechIcon51;
    public GameObject TechIcon52;
    public GameObject TechIcon53;
    public GameObject TechIcon54;
    public GameObject TechIcon55;
    public GameObject TechIcon56;
    public GameObject TechIcon57;
    public GameObject TechIcon58;
    public GameObject TechIcon59;
    public GameObject TechIcon60;
    public GameObject TechIcon61;
    public GameObject TechIcon62;
    public GameObject TechIcon63;
    public GameObject TechIcon64;
    public GameObject TechIcon65;
    public GameObject TechIcon66;
    public GameObject TechIcon67;
    public GameObject TechIcon68;
    public GameObject TechIcon69;
    public GameObject TechIcon70;

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
    public Sprite TechCplImg38;
    public Sprite TechCplImg39;
    public Sprite TechCplImg40;
    public Sprite TechCplImg41;
    public Sprite TechCplImg42;
    public Sprite TechCplImg43;
    public Sprite TechCplImg44;
    public Sprite TechCplImg45;
    public Sprite TechCplImg46;
    public Sprite TechCplImg47;
    public Sprite TechCplImg48;
    public Sprite TechCplImg49;
    public Sprite TechCplImg50;
    public Sprite TechCplImg51;
    public Sprite TechCplImg52;
    public Sprite TechCplImg53;
    public Sprite TechCplImg54;
    public Sprite TechCplImg55;
    public Sprite TechCplImg56;
    public Sprite TechCplImg57;
    public Sprite TechCplImg58;
    public Sprite TechCplImg59;
    public Sprite TechCplImg60;
    public Sprite TechCplImg61;
    public Sprite TechCplImg62;
    public Sprite TechCplImg63;
    public Sprite TechCplImg64;
    public Sprite TechCplImg65;
    public Sprite TechCplImg66;
    public Sprite TechCplImg67;
    public Sprite TechCplImg68;
    public Sprite TechCplImg69;
    public Sprite TechCplImg70;

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
    public GameObject ProdBtn38;
    public GameObject ProdBtn39;
    public GameObject ProdBtn40;
    public GameObject ProdBtn41;
    public GameObject ProdBtn42;
    public GameObject ProdBtn43;
    public GameObject ProdBtn44;
    public GameObject ProdBtn45;
    public GameObject ProdBtn46;
    public GameObject ProdBtn47;
    public GameObject ProdBtn48;
    public GameObject ProdBtn49;
    public GameObject ProdBtn51;
    public GameObject ProdBtn52;
    public GameObject ProdBtn53;
    public GameObject ProdBtn54;
    public GameObject ProdBtn55;
    public GameObject ProdBtn56;
    public GameObject ProdBtn58;
    public GameObject ProdBtn59;
    public GameObject ProdBtn60;
    public GameObject ProdBtn61;
    public GameObject ProdBtn62;
    public GameObject ProdBtn63;
    public GameObject ProdBtn64;
    public GameObject ProdBtn65;
    public GameObject ProdBtn66;
    public GameObject ProdBtn67;
    public GameObject ProdBtn68;
    public GameObject ProdBtn69;
    public GameObject ProdBtn70;

    static public bool age_war;
    static public bool age_elec;
    static public bool age_modern;

    // 연구아이콘 클릭 시 나오는 패널 관련
    public Text title;
    public Text exp;
    public GameObject Icon; // 연구완료 아이콘 집어넣기
    public Text NeedScience;
    public Button TechUpBtn;
    public GameObject TechUpPanel;

    short PanelNum;

    public GameObject MainTechPanel;
    public GameObject Panel_ind_Tech;
    public GameObject Panel_war_Tech;
    public GameObject Panel_elec_Tech;
    public GameObject Panel_modern_Tech;
    public GameObject ScrollBar_IND;
    public GameObject SBHandle_IND;
    public GameObject ScrollBar_WAR;
    public GameObject SBHandle_WAR;
    public GameObject ScrollBar_ELEC;
    public GameObject SBHandle_ELEC;
    public GameObject ScrollBar_MODERN;
    public GameObject SBHandle_MODERN;
    public Image im1;
    public Image im2;
    public Image im3;
    public Image im4;


    Scrollbar SbTech_IND; // 스크롤바 import를 위한 변수 AutoHidingHandle() 관련
    float CurrentHandleValue_IND; // 스크롤바 커서 위치값 변수 AutoHidingHandle() 관련
    Scrollbar SbTech_WAR;
    float CurrentHandleValue_WAR;
    Scrollbar SbTech_ELEC;
    float CurrentHandleValue_ELEC;
    Scrollbar SbTech_MODERN;
    float CurrentHandleValue_MODERN;


    void Awake()
    {
        MainTechPanel.SetActive(true);
        Panel_ind_Tech.SetActive(true);
        Panel_war_Tech.SetActive(true);
        Panel_elec_Tech.SetActive(true);
        Panel_modern_Tech.SetActive(true);

        SbTech_IND = ScrollBar_IND.GetComponent<Scrollbar>();
        SbTech_IND.value = 1;
        SbTech_WAR = ScrollBar_WAR.GetComponent<Scrollbar>();
        SbTech_WAR.value = 1;
        SbTech_ELEC = ScrollBar_ELEC.GetComponent<Scrollbar>();
        SbTech_ELEC.value = 1;
        SbTech_MODERN = ScrollBar_MODERN.GetComponent<Scrollbar>();
        SbTech_MODERN.value = 1;

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
        Tech38 = tc38_삼원색_연구력;
        Tech39 = tc39_극초단파_연구력;
        Tech40 = tc40_신호변환_연구력;
        Tech41 = tc41_레이저_연구력;
        Tech42 = tc42_해열진통제_연구력;
        Tech43 = tc43_자기저장소_연구력;
        Tech44 = tc44_소리플러스_연구력;
        Tech45 = tc45_발광다이오드_연구력;
        Tech46 = tc46_신경안정제_연구력;
        Tech47 = tc47_저장소플러스_연구력;
        Tech48 = tc48_논리회로_연구력;
        Tech49 = tc49_전자두뇌_연구력;
        Tech50 = tc50_보이저계획_연구력;
        Tech51 = tc51_콜레스테릭_연구력;
        Tech52 = tc52_이더넷_연구력;
        Tech53 = tc53_양성자반응_연구력;
        Tech54 = tc54_전송_연구력;
        Tech55 = tc55_전자오락_연구력;
        Tech56 = tc56_컴퓨터언어_연구력;
        Tech57 = tc57_유전자치료_연구력;
        Tech58 = tc58_근거리통신망_연구력;
        Tech59 = tc59_통신위성_연구력;
        Tech60 = tc60_유전자변화_연구력;
        Tech61 = tc61_세계통합_연구력;
        Tech62 = tc62_복제_연구력;
        Tech63 = tc63_컴퓨터플러스_연구력;
        Tech64 = tc64_블록체인_연구력;
        Tech65 = tc65_AI_연구력;
        Tech66 = tc66_고속통신_연구력;
        Tech67 = tc67_가상현실_연구력;
        Tech68 = tc68_증강현실_연구력;
        Tech69 = tc69_제품화_연구력;
        Tech70 = tc70_서버변경_연구력;

        im1 = SBHandle_IND.GetComponent<Image>();
        im2 = SBHandle_WAR.GetComponent<Image>();
        im3 = SBHandle_ELEC.GetComponent<Image>();
        im4 = SBHandle_MODERN.GetComponent<Image>();

    }

    void Start()
    {
        StartCoroutine(AutoHidingHandle());
        StartCoroutine(TechUpButtonCheck());

        if (age_modern == true)
        {
            Panel_ind_Tech.SetActive(false);
            Panel_war_Tech.SetActive(false);
            Panel_elec_Tech.SetActive(false);
        }
        else if (age_elec == true)
        {
            Panel_ind_Tech.SetActive(false);
            Panel_war_Tech.SetActive(false);
            Panel_modern_Tech.SetActive(false);
        }
        else if (age_war == true)
        {
            Panel_ind_Tech.SetActive(false);
            Panel_elec_Tech.SetActive(false);
            Panel_modern_Tech.SetActive(false);
        }
        else
        {
            Panel_war_Tech.SetActive(false);
            Panel_elec_Tech.SetActive(false);
            Panel_modern_Tech.SetActive(false);
        }

        MainTechPanel.SetActive(false);

        Noti.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
    }

    void Update()
    {
        TechAnim();
        ExceptionRule();
    }

    public void ButtonNotiOff()
    {
        Noti.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
    }

    IEnumerator AutoHidingHandle()
    {
        while(true)
        {
            im1.color = new Color(im1.color.r, im1.color.g, im1.color.b, im1.color.a - 0.05f);
            if (SbTech_IND.value != CurrentHandleValue_IND)
            {
                im1.color = new Color32(255, 255, 255, 255);
                CurrentHandleValue_IND = SbTech_IND.value;
            }

            im2.color = new Color(im2.color.r, im2.color.g, im2.color.b, im2.color.a - 0.05f);
            if (SbTech_WAR.value != CurrentHandleValue_WAR)
            {
                im2.color = new Color32(255, 255, 255, 255);
                CurrentHandleValue_WAR = SbTech_WAR.value;
            }

            im3.color = new Color(im3.color.r, im3.color.g, im3.color.b, im3.color.a - 0.05f);
            if (SbTech_ELEC.value != CurrentHandleValue_ELEC)
            {
                im3.color = new Color32(255, 255, 255, 255);
                CurrentHandleValue_ELEC = SbTech_ELEC.value;
            }

            im4.color = new Color(im4.color.r, im4.color.g, im4.color.b, im4.color.a - 0.05f);
            if (SbTech_MODERN.value != CurrentHandleValue_MODERN)
            {
                im4.color = new Color32(255, 255, 255, 255);
                CurrentHandleValue_MODERN = SbTech_MODERN.value;
            }

            yield return new WaitForSeconds(0.05f);
        }
    }

    /* ==================================================================================================== */

    public void UpTech() // 연구 상세정보 진입 후, '연구하기 버튼'에 대입
    {
        if (PanelNum == 1 && Tech1Complete == false && GameManager.science >= Tech1)
        {
            UpTechLogic2(Tech1, tYear1, ref Tech1Complete, ref TechIcon1, TechCplImg1, ref TechIcon2, ref TechIcon3, ref ProdBtn1);
        }
        else if (PanelNum == 2 && Tech2Complete == false && GameManager.science >= Tech2 && Tech1Complete == true)
        {
            UpTechLogic2x(Tech2, tYear2, ref Tech2Complete, ref TechIcon2, TechCplImg2, ref TechIcon5, ref TechIcon7);
        }
        else if (PanelNum == 3 && Tech3Complete == false && GameManager.science >= Tech3 && Tech1Complete == true)
        {
            UpTechLogic1(Tech3, tYear3, ref Tech3Complete, ref TechIcon3, TechCplImg3, ref TechIcon4, ref ProdBtn3);
        }
        else if (PanelNum == 4 && Tech4Complete == false && GameManager.science >= Tech4 && Tech3Complete == true)
        {
            UpTechLogic1(Tech4, tYear4, ref Tech4Complete, ref TechIcon4, TechCplImg4, ref TechIcon6, ref ProdBtn4);
        }
        else if (PanelNum == 5 && Tech5Complete == false && GameManager.science >= Tech5 && Tech2Complete == true)
        {
            UpTechLogic0(Tech5, tYear5, ref Tech5Complete, ref TechIcon5, TechCplImg5, ref ProdBtn5);
        }
        else if (PanelNum == 6 && Tech6Complete == false && GameManager.science >= Tech6 && Tech4Complete == true)
        {
            UpTechLogic0(Tech6, tYear6, ref Tech6Complete, ref TechIcon6, TechCplImg6, ref ProdBtn6);
        }
        else if (PanelNum == 7 && Tech7Complete == false && GameManager.science >= Tech7 && Tech2Complete == true)
        {
            UpTechLogic2(Tech7, tYear7, ref Tech7Complete, ref TechIcon7, TechCplImg7, ref TechIcon8, ref TechIcon10, ref ProdBtn7);
        }
        else if (PanelNum == 8 && Tech8Complete == false && GameManager.science >= Tech8 && Tech7Complete == true)
        {
            UpTechLogic1(Tech8, tYear8, ref Tech8Complete, ref TechIcon8, TechCplImg8, ref TechIcon9, ref ProdBtn8);
        }
        else if (PanelNum == 9 && Tech9Complete == false && GameManager.science >= Tech9 && Tech8Complete == true)
        {
            UpTechLogic1(Tech9, tYear9, ref Tech9Complete, ref TechIcon9, TechCplImg9, ref TechIcon13, ref ProdBtn9);
        }
        else if (PanelNum == 10 && Tech10Complete == false && GameManager.science >= Tech10 && Tech7Complete == true)
        {
            UpTechLogic2(Tech10, tYear10, ref Tech10Complete, ref TechIcon10, TechCplImg10, ref TechIcon11, ref TechIcon12, ref ProdBtn10);
        }
        else if (PanelNum == 11 && Tech11Complete == false && GameManager.science >= Tech11 && Tech10Complete == true)
        {
            UpTechLogic1(Tech11, tYear11, ref Tech11Complete, ref TechIcon11, TechCplImg11, ref TechIcon14, ref ProdBtn11);
        }
        else if (PanelNum == 12 && Tech12Complete == false && GameManager.science >= Tech12 && Tech10Complete == true)
        {
            UpTechLogic0(Tech12, tYear12, ref Tech12Complete, ref TechIcon12, TechCplImg12, ref ProdBtn12);
        }
        else if (PanelNum == 13 && Tech13Complete == false && GameManager.science >= Tech13 && Tech9Complete == true)
        {
            UpTechLogic1(Tech13, tYear13, ref Tech13Complete, ref TechIcon13, TechCplImg13, ref TechIcon15, ref ProdBtn13);
        }
        else if (PanelNum == 14 && Tech14Complete == false && GameManager.science >= Tech14 && Tech11Complete == true)
        {
            UpTechLogic2(Tech14, tYear14, ref Tech14Complete, ref TechIcon14, TechCplImg14, ref TechIcon16, ref TechIcon17, ref ProdBtn14);
        }
        else if (PanelNum == 15 && Tech15Complete == false && GameManager.science >= Tech15 && Tech13Complete == true)
        {
            UpTechLogic0(Tech15, tYear15, ref Tech15Complete, ref TechIcon15, TechCplImg15, ref ProdBtn15);
        }
        else if (PanelNum == 16 && Tech16Complete == false && GameManager.science >= Tech16 && Tech14Complete == true)
        {
            UpTechLogic1x(Tech16, tYear16, ref Tech16Complete, ref TechIcon16, TechCplImg16, ref TechIcon18);
        }
        else if (PanelNum == 17 && Tech17Complete == false && GameManager.science >= Tech17 && Tech14Complete == true)
        {
            UpTechLogic1(Tech17, tYear17, ref Tech17Complete, ref TechIcon17, TechCplImg17, ref TechIcon20, ref ProdBtn17);
        }
        else if (PanelNum == 18 && Tech18Complete == false && GameManager.science >= Tech18 && Tech16Complete == true)
        {
            UpTechLogic0(Tech18, tYear18, ref Tech18Complete, ref TechIcon18, TechCplImg18, ref ProdBtn18);
        }
        else if (PanelNum == 19 && Tech19Complete == false && GameManager.science >= Tech19 && Tech15Complete == true && Tech17Complete == true)
        {
            UpTechLogic0(Tech19, tYear19, ref Tech19Complete, ref TechIcon19, TechCplImg19, ref ProdBtn19);
        }
        else if (PanelNum == 20 && Tech20Complete == false && GameManager.science >= Tech20 && Tech17Complete == true)
        {
            UpTechLogic2(Tech20, tYear20, ref Tech20Complete, ref TechIcon20, TechCplImg20, ref TechIcon21, ref TechIcon22, ref ProdBtn20);
        }
        else if (PanelNum == 21 && Tech21Complete == false && GameManager.science >= Tech21 && Tech20Complete == true)
        {
            UpTechLogic0(Tech21, tYear21, ref Tech21Complete, ref TechIcon21, TechCplImg21, ref ProdBtn21);
        }
        else if (PanelNum == 22 && Tech22Complete == false && GameManager.science >= Tech22 && Tech20Complete == true)
        {
            UpTechLogic0(Tech22, tYear22, ref Tech22Complete, ref TechIcon22, TechCplImg22, ref ProdBtn22);
        }
        else if (PanelNum == 23 && Tech23Complete == false && GameManager.science >= Tech23 && age_war == true)
        {
            UpTechLogic2(Tech23, tYear23, ref Tech23Complete, ref TechIcon23, TechCplImg23, ref TechIcon24, ref TechIcon25, ref ProdBtn23);
        }
        else if (PanelNum == 24 && Tech24Complete == false && GameManager.science >= Tech24 && Tech23Complete == true)
        {
            UpTechLogic1(Tech24, tYear24, ref Tech24Complete, ref TechIcon24, TechCplImg24, ref TechIcon26, ref ProdBtn24);
        }
        else if (PanelNum == 25 && Tech25Complete == false && GameManager.science >= Tech25 && Tech23Complete == true)
        {
            UpTechLogic1(Tech25, tYear25, ref Tech25Complete, ref TechIcon25, TechCplImg25, ref TechIcon29, ref ProdBtn25);
        }
        else if (PanelNum == 26 && Tech26Complete == false && GameManager.science >= Tech26 && Tech24Complete == true)
        {
            UpTechLogic2(Tech26, tYear26, ref Tech26Complete, ref TechIcon26, TechCplImg26, ref TechIcon27, ref TechIcon28, ref ProdBtn26);
        }
        else if (PanelNum == 27 && Tech27Complete == false && GameManager.science >= Tech27 && Tech26Complete == true)
        {
            UpTechLogic1(Tech27, tYear27, ref Tech27Complete, ref TechIcon27, TechCplImg27, ref TechIcon30, ref ProdBtn27);
        }
        else if (PanelNum == 28 && Tech28Complete == false && GameManager.science >= Tech28 && Tech26Complete == true)
        {
            UpTechLogic0(Tech28, tYear28, ref Tech28Complete, ref TechIcon28, TechCplImg28, ref ProdBtn28);
        }
        else if (PanelNum == 29 && Tech29Complete == false && GameManager.science >= Tech29 && Tech25Complete == true)
        {
            UpTechLogic0(Tech29, tYear29, ref Tech29Complete, ref TechIcon29, TechCplImg29, ref ProdBtn29);
        }
        else if (PanelNum == 30 && Tech30Complete == false && GameManager.science >= Tech30 && Tech27Complete == true)
        {
            UpTechLogic1(Tech30, tYear30, ref Tech30Complete, ref TechIcon30, TechCplImg30, ref TechIcon31, ref ProdBtn30);
        }
        else if (PanelNum == 31 && Tech31Complete == false && GameManager.science >= Tech31 && Tech30Complete == true)
        {
            UpTechLogic1(Tech31, tYear31, ref Tech31Complete, ref TechIcon31, TechCplImg31, ref TechIcon33, ref ProdBtn31);
        }
        else if (PanelNum == 32 && Tech32Complete == false && GameManager.science >= Tech32 && Tech28Complete == true && Tech29Complete == true)
        {
            UpTechLogic1(Tech32, tYear32, ref Tech32Complete, ref TechIcon32, TechCplImg32, ref TechIcon34, ref ProdBtn32);
        }
        else if (PanelNum == 33 && Tech33Complete == false && GameManager.science >= Tech33 && Tech31Complete == true)
        {
            UpTechLogic0(Tech33, tYear33, ref Tech33Complete, ref TechIcon33, TechCplImg33, ref ProdBtn33);
        }
        else if (PanelNum == 34 && Tech34Complete == false && GameManager.science >= Tech34 && Tech32Complete == true)
        {
            UpTechLogic1(Tech34, tYear34, ref Tech34Complete, ref TechIcon34, TechCplImg34, ref TechIcon35, ref ProdBtn34);
        }
        else if (PanelNum == 35 && Tech35Complete == false && GameManager.science >= Tech35 && Tech34Complete == true)
        {
            UpTechLogic0(Tech35, tYear35, ref Tech35Complete, ref TechIcon35, TechCplImg35, ref ProdBtn35);
        }
        else if (PanelNum == 36 && Tech36Complete == false && GameManager.science >= Tech36 && Tech33Complete == true && Tech34Complete == true)
        {
            UpTechLogic0(Tech36, tYear36, ref Tech36Complete, ref TechIcon36, TechCplImg36, ref ProdBtn36);
        }
        else if (PanelNum == 37 && Tech37Complete == false && GameManager.science >= Tech37 && Tech34Complete == true && Tech35Complete == true && Tech36Complete == true)
        {
            UpTechLogic0(Tech37, tYear37, ref Tech37Complete, ref TechIcon37, TechCplImg37, ref ProdBtn37);
        }
        else if (PanelNum == 38 && Tech38Complete == false && GameManager.science >= Tech38 && age_elec == true)
        {
            UpTechLogic2(Tech38, tYear38, ref Tech38Complete, ref TechIcon38, TechCplImg38, ref TechIcon39, ref TechIcon40, ref ProdBtn38);
        }
        else if (PanelNum == 39 && Tech39Complete == false && GameManager.science >= Tech39 && Tech38Complete == true)
        {
            UpTechLogic0(Tech39, tYear39, ref Tech39Complete, ref TechIcon39, TechCplImg39, ref ProdBtn39);
        }
        else if (PanelNum == 40 && Tech40Complete == false && GameManager.science >= Tech40 && Tech38Complete == true)
        {
            UpTechLogic3(Tech40, tYear40, ref Tech40Complete, ref TechIcon40, TechCplImg40, ref TechIcon41, ref TechIcon42, ref TechIcon43, ref ProdBtn40);
        }
        else if (PanelNum == 41 && Tech41Complete == false && GameManager.science >= Tech41 && Tech40Complete == true)
        {
            UpTechLogic1(Tech41, tYear41, ref Tech41Complete, ref TechIcon41, TechCplImg41, ref TechIcon44, ref ProdBtn41);
        }
        else if (PanelNum == 42 && Tech42Complete == false && GameManager.science >= Tech42 && Tech40Complete == true)
        {
            UpTechLogic1(Tech42, tYear42, ref Tech42Complete, ref TechIcon42, TechCplImg42, ref TechIcon46, ref ProdBtn42);
        }
        else if (PanelNum == 43 && Tech43Complete == false && GameManager.science >= Tech43 && Tech40Complete == true)
        {
            UpTechLogic1(Tech43, tYear43, ref Tech43Complete, ref TechIcon43, TechCplImg43, ref TechIcon45, ref ProdBtn43);
        }
        else if (PanelNum == 44 && Tech44Complete == false && GameManager.science >= Tech44 && Tech41Complete == true)
        {
            UpTechLogic0(Tech44, tYear44, ref Tech44Complete, ref TechIcon44, TechCplImg44, ref ProdBtn44);
        }
        else if (PanelNum == 45 && Tech45Complete == false && GameManager.science >= Tech45 && Tech43Complete == true)
        {
            UpTechLogic3(Tech45, tYear45, ref Tech45Complete, ref TechIcon45, TechCplImg45, ref TechIcon47, ref TechIcon48, ref TechIcon50, ref ProdBtn45);
        }
        else if (PanelNum == 46 && Tech46Complete == false && GameManager.science >= Tech46 && Tech42Complete == true)
        {
            UpTechLogic0(Tech46, tYear46, ref Tech46Complete, ref TechIcon46, TechCplImg46, ref ProdBtn46);
        }
        else if (PanelNum == 47 && Tech47Complete == false && GameManager.science >= Tech47 && Tech45Complete == true)
        {
            UpTechLogic1(Tech47, tYear47, ref Tech47Complete, ref TechIcon47, TechCplImg47, ref TechIcon49, ref ProdBtn47);
        }
        else if (PanelNum == 48 && Tech48Complete == false && GameManager.science >= Tech48 && Tech45Complete == true)
        {
            UpTechLogic1(Tech48, tYear48, ref Tech48Complete, ref TechIcon48, TechCplImg48, ref TechIcon51, ref ProdBtn48);
        }
        else if (PanelNum == 49 && Tech49Complete == false && GameManager.science >= Tech49 && Tech47Complete == true)
        {
            UpTechLogic0(Tech49, tYear49, ref Tech49Complete, ref TechIcon49, TechCplImg49, ref ProdBtn49);
        }
        else if (PanelNum == 50 && Tech50Complete == false && GameManager.science >= Tech50 && Tech45Complete == true)
        {
            UpTechLogic2x(Tech50, tYear50, ref Tech50Complete, ref TechIcon50, TechCplImg50, ref TechIcon52, ref TechIcon53);
        }
        else if (PanelNum == 51 && Tech51Complete == false && GameManager.science >= Tech51 && Tech48Complete == true)
        {
            UpTechLogic0(Tech51, tYear51, ref Tech51Complete, ref TechIcon51, TechCplImg51, ref ProdBtn51);
        }
        else if (PanelNum == 52 && Tech52Complete == false && GameManager.science >= Tech52 && Tech50Complete == true)
        {
            UpTechLogic1(Tech52, tYear52, ref Tech52Complete, ref TechIcon52, TechCplImg52, ref TechIcon54, ref ProdBtn52);
        }
        else if (PanelNum == 53 && Tech53Complete == false && GameManager.science >= Tech53 && Tech50Complete == true)
        {
            UpTechLogic1(Tech53, tYear53, ref Tech53Complete, ref TechIcon53, TechCplImg53, ref TechIcon55, ref ProdBtn53);
        }
        else if (PanelNum == 54 && Tech54Complete == false && GameManager.science >= Tech54 && Tech52Complete == true)
        {
            UpTechLogic0(Tech54, tYear54, ref Tech54Complete, ref TechIcon54, TechCplImg54, ref ProdBtn54);
        }
        else if (PanelNum == 55 && Tech55Complete == false && GameManager.science >= Tech55 && Tech53Complete == true)
        {
            UpTechLogic0(Tech55, tYear55, ref Tech55Complete, ref TechIcon55, TechCplImg55, ref ProdBtn55);
        }
        else if (PanelNum == 56 && Tech56Complete == false && GameManager.science >= Tech56 && age_modern == true)
        {
            UpTechLogic2(Tech56, tYear56, ref Tech56Complete, ref TechIcon56, TechCplImg56, ref TechIcon57, ref TechIcon58, ref ProdBtn56);
        }
        else if (PanelNum == 57 && Tech57Complete == false && GameManager.science >= Tech57 && Tech56Complete == true)
        {
            UpTechLogic1x(Tech57, tYear57, ref Tech57Complete, ref TechIcon57, TechCplImg57, ref TechIcon60);
        }
        else if (PanelNum == 58 && Tech58Complete == false && GameManager.science >= Tech58 && Tech56Complete == true)
        {
            UpTechLogic1(Tech58, tYear58, ref Tech58Complete, ref TechIcon58, TechCplImg58, ref TechIcon59, ref ProdBtn58);
        }
        else if (PanelNum == 59 && Tech59Complete == false && GameManager.science >= Tech59 && Tech58Complete == true)
        {
            UpTechLogic1(Tech59, tYear59, ref Tech59Complete, ref TechIcon59, TechCplImg59, ref TechIcon61, ref ProdBtn59);
        }
        else if (PanelNum == 60 && Tech60Complete == false && GameManager.science >= Tech60 && Tech57Complete == true)
        {
            UpTechLogic1(Tech60, tYear60, ref Tech60Complete, ref TechIcon60, TechCplImg60, ref TechIcon62, ref ProdBtn60);
        }
        else if (PanelNum == 61 && Tech61Complete == false && GameManager.science >= Tech61 && Tech59Complete == true)
        {
            UpTechLogic0(Tech61, tYear61, ref Tech61Complete, ref TechIcon61, TechCplImg61, ref ProdBtn61);
        }
        else if (PanelNum == 62 && Tech62Complete == false && GameManager.science >= Tech62 && Tech60Complete == true)
        {
            UpTechLogic0(Tech62, tYear62, ref Tech62Complete, ref TechIcon62, TechCplImg62, ref ProdBtn62);
        }
        else if (PanelNum == 63 && Tech63Complete == false && GameManager.science >= Tech63 && Tech61Complete == true && Tech62Complete == true)
        {
            UpTechLogic2(Tech63, tYear63, ref Tech63Complete, ref TechIcon63, TechCplImg63, ref TechIcon64, ref TechIcon65, ref ProdBtn63);
        }
        else if (PanelNum == 64 && Tech64Complete == false && GameManager.science >= Tech64 && Tech63Complete == true)
        {
            UpTechLogic1(Tech64, tYear64, ref Tech64Complete, ref TechIcon64, TechCplImg64, ref TechIcon66, ref ProdBtn64);
        }
        else if (PanelNum == 65 && Tech65Complete == false && GameManager.science >= Tech65 && Tech63Complete == true)
        {
            UpTechLogic0(Tech65, tYear65, ref Tech65Complete, ref TechIcon65, TechCplImg65, ref ProdBtn65);
        }
        else if (PanelNum == 66 && Tech66Complete == false && GameManager.science >= Tech66 && Tech64Complete == true)
        {
            UpTechLogic0(Tech66, tYear66, ref Tech66Complete, ref TechIcon66, TechCplImg66, ref ProdBtn66);
        }
        else if (PanelNum == 67 && Tech67Complete == false && GameManager.science >= Tech67 && Tech65Complete == true && Tech66Complete == true)
        {
            UpTechLogic1(Tech67, tYear67, ref Tech67Complete, ref TechIcon67, TechCplImg67, ref TechIcon68, ref ProdBtn67);
        }
        else if (PanelNum == 68 && Tech68Complete == false && GameManager.science >= Tech68 && Tech67Complete == true)
        {
            UpTechLogic1(Tech68, tYear68, ref Tech68Complete, ref TechIcon68, TechCplImg68, ref TechIcon69, ref ProdBtn68);
        }
        else if (PanelNum == 69 && Tech69Complete == false && GameManager.science >= Tech69 && Tech68Complete == true)
        {
            UpTechLogic1(Tech69, tYear69, ref Tech69Complete, ref TechIcon69, TechCplImg69, ref TechIcon70, ref ProdBtn69);
        }
        else if (PanelNum == 70 && Tech70Complete == false && GameManager.science >= Tech70 && Tech69Complete == true)
        {
            UpTechLogic0(Tech70, tYear70, ref Tech70Complete, ref TechIcon70, TechCplImg70, ref ProdBtn70);
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

    void UpTechLogic3(long a, int b, ref bool c, ref GameObject d, Sprite e, ref GameObject f, ref GameObject g, ref GameObject h, ref GameObject P)
    // a는 필요연구량, b는 증가연도, c는 연구완료판단 변수, d는 해당연구아이콘, e는 연구완료아이콘. f는 후행연구1, g는 후행연구2, h는 후행연구3
    {
        GameManager.science -= a;
        GameManager.years += b;
        c = true;
        TechUpPanel.SetActive(false);
        d.GetComponent<Image>().sprite = e;
        d.GetComponent<Image>().color = new Color32(255, 255, 255, 100);
        f.GetComponent<Button>().interactable = true;
        g.GetComponent<Button>().interactable = true;
        h.GetComponent<Button>().interactable = true;
        P.SetActive(true);
    }

    /* ==================================================================================================== */

    void TechAnim() // 업데이트 함수에 대입
    {
        if(age_modern == true)
        {
            TechAnimLogic2_0_3(ref Tech56AnimC, ref Tech56Complete, ref TechIcon56, ref TechIcon57, ref TechIcon58, ref L57, ref L58, ref L58_57);
            TechAnimLogic1_2_1(ref Tech57AnimC, ref Tech57Complete, ref TechIcon57, ref TechIcon60, ref L57, ref L58_57, ref L60);
            TechAnimLogic1_2_1(ref Tech58AnimC, ref Tech58Complete, ref TechIcon58, ref TechIcon59, ref L57, ref L58_57, ref L59);
            TechAnimLogic1_1_1(ref Tech59AnimC, ref Tech59Complete, ref TechIcon59, ref TechIcon61, ref L59, ref L61);
            TechAnimLogic1_1_1(ref Tech60AnimC, ref Tech60Complete, ref TechIcon60, ref TechIcon62, ref L60, ref L62);
            TechAnimLogic0_1_2(ref Tech61AnimC, ref Tech61Complete, ref TechIcon61, ref L61, ref L63_2, ref L63_3);
            TechAnimLogic0_1_2(ref Tech62AnimC, ref Tech62Complete, ref TechIcon62, ref L62, ref L63_1, ref L63_3);
            TechAnimLogic2_3_3(ref Tech63AnimC, ref Tech63Complete, ref TechIcon63, ref TechIcon64, ref TechIcon65, ref L63_1, ref L63_2, ref L63_3, ref L64, ref L65, ref L65_64);
            TechAnimLogic1_2_1(ref Tech64AnimC, ref Tech64Complete, ref TechIcon64, ref TechIcon66, ref L64, ref L65_64, ref L66);
            TechAnimLogic0_2_2(ref Tech65AnimC, ref Tech65Complete, ref TechIcon65, ref L65, ref L65_64, ref L67_2, ref L67_3);
            TechAnimLogic0_1_2(ref Tech66AnimC, ref Tech66Complete, ref TechIcon66, ref L66, ref L67_1, ref L67_3);
            TechAnimLogic1_3_1(ref Tech67AnimC, ref Tech67Complete, ref TechIcon67, ref TechIcon68, ref L67_1, ref L67_2, ref L67_3, ref L68);
            TechAnimLogic1_1_1(ref Tech68AnimC, ref Tech68Complete, ref TechIcon68, ref TechIcon69, ref L68, ref L69);
            TechAnimLogic1_1_1(ref Tech69AnimC, ref Tech69Complete, ref TechIcon69, ref TechIcon70, ref L69, ref L70);
            TechAnimLogic0_1_0(ref Tech70AnimC, ref Tech70Complete, ref TechIcon70, ref L70);
        }
        else if(age_elec == true)
        {
            TechAnimLogic2_0_3(ref Tech38AnimC, ref Tech38Complete, ref TechIcon38, ref TechIcon39, ref TechIcon40, ref L39, ref L40, ref L40_39);
            TechAnimLogic0_2_0(ref Tech39AnimC, ref Tech39Complete, ref TechIcon39, ref L39, ref L40_39);
            TechAnimLogic3_2_6(ref Tech40AnimC, ref Tech40Complete, ref TechIcon40, ref TechIcon41, ref TechIcon42, ref TechIcon43, ref L40, ref L40_39, ref L41, ref L42, ref L43, ref L43_1, ref L43_2, ref L43_3);
            TechAnimLogic1_3_1(ref Tech41AnimC, ref Tech41Complete, ref TechIcon41, ref TechIcon44, ref L41, ref L43_1, ref L43_3, ref L44);
            TechAnimLogic1_3_1(ref Tech42AnimC, ref Tech42Complete, ref TechIcon42, ref TechIcon46, ref L42, ref L43_2, ref L43_3, ref L46);
            TechAnimLogic1_4_1(ref Tech43AnimC, ref Tech43Complete, ref TechIcon43, ref TechIcon45, ref L43, ref L43_1, ref L43_2, ref L43_3, ref L45);
            TechAnimLogic0_1_0(ref Tech44AnimC, ref Tech44Complete, ref TechIcon44, ref L44);
            TechAnimLogic3_1_5(ref Tech45AnimC, ref Tech45Complete, ref TechIcon45, ref TechIcon47, ref TechIcon48, ref TechIcon50, ref L45, ref L47, ref L48, ref L50, ref L50_47, ref L50_48);
            TechAnimLogic0_1_0(ref Tech46AnimC, ref Tech46Complete, ref TechIcon46, ref L46);
            TechAnimLogic1_2_1(ref Tech47AnimC, ref Tech47Complete, ref TechIcon47, ref TechIcon49, ref L47, ref L50_47, ref L49);
            TechAnimLogic1_3_1(ref Tech48AnimC, ref Tech48Complete, ref TechIcon48, ref TechIcon51, ref L48, ref L50_47, ref L50_48, ref L51);
            TechAnimLogic0_1_0(ref Tech49AnimC, ref Tech49Complete, ref TechIcon49, ref L49);
            TechAnimLogic2_3_3(ref Tech50AnimC, ref Tech50Complete, ref TechIcon50, ref TechIcon52, ref TechIcon53, ref L50, ref L50_47, ref L50_48, ref L52, ref L53, ref L53_52);
            TechAnimLogic0_1_0(ref Tech51AnimC, ref Tech51Complete, ref TechIcon51, ref L51);
            TechAnimLogic1_2_1(ref Tech52AnimC, ref Tech52Complete, ref TechIcon52, ref TechIcon54, ref L52, ref L53_52, ref L54);
            TechAnimLogic1_2_1(ref Tech53AnimC, ref Tech53Complete, ref TechIcon53, ref TechIcon55, ref L53, ref L53_52, ref L55);
            TechAnimLogic0_1_0(ref Tech54AnimC, ref Tech54Complete, ref TechIcon54, ref L54);
            TechAnimLogic0_1_0(ref Tech55AnimC, ref Tech55Complete, ref TechIcon55, ref L55);
        }
        else if(age_war == true)
        {
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
        else
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
        }
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

    void TechAnimLogic1_4_1(ref bool a, ref bool b, ref GameObject c, ref GameObject d, ref GameObject L__1, ref GameObject L__2, ref GameObject L__3, ref GameObject L__4, ref GameObject L__a)
    //후행연구 1개, 선행라인 4개, 후행라인 1개
    {
        if (a == false && b == true)
        {
            c.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            d.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            L__1.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__2.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__3.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__4.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
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

    void TechAnimLogic2_3_3(ref bool a, ref bool b, ref GameObject c, ref GameObject d, ref GameObject e, ref GameObject L__1, ref GameObject L__2, ref GameObject L__3, ref GameObject L__a, ref GameObject L__b, ref GameObject L__c)
    //후행연구 2개, 선행라인 3개, 후행라인 3개
    {
        if (a == false && b == true)
        {
            c.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            d.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            e.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            L__1.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__2.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__3.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__a.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            L__b.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            L__c.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            if (c.GetComponent<Image>().color.a > 2.7)
            {
                a = true;
            }
        }
    }

    void TechAnimLogic3_1_5(ref bool a, ref bool b, ref GameObject c, ref GameObject d, ref GameObject e, ref GameObject f, ref GameObject L__1, ref GameObject L__a, ref GameObject L__b, ref GameObject L__c, ref GameObject L__d, ref GameObject L__e)
    //후행연구 3개, 선행라인 1개, 후행라인 5개
    {
        if (a == false && b == true)
        {
            c.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            d.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            e.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            f.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            L__1.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__a.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            L__b.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            L__c.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            L__d.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            L__e.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            if (c.GetComponent<Image>().color.a > 2.7)
            {
                a = true;
            }
        }
    }

    void TechAnimLogic3_2_5(ref bool a, ref bool b, ref GameObject c, ref GameObject d, ref GameObject e, ref GameObject f, ref GameObject L__1, ref GameObject L__2, ref GameObject L__a, ref GameObject L__b, ref GameObject L__c, ref GameObject L__d, ref GameObject L__e)
    //후행연구 3개, 선행라인 2개, 후행라인 5개
    {
        if (a == false && b == true)
        {
            c.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            d.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            e.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            f.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            L__1.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__2.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__a.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            L__b.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            L__c.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            L__d.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            L__e.GetComponent<Image>().color += new Color32(0, 0, 0, 4);
            if (c.GetComponent<Image>().color.a > 2.7)
            {
                a = true;
            }
        }
    }

    void TechAnimLogic3_2_6(ref bool a, ref bool b, ref GameObject c, ref GameObject d, ref GameObject e, ref GameObject f, ref GameObject L__1, ref GameObject L__2, ref GameObject L__a, ref GameObject L__b, ref GameObject L__c, ref GameObject L__d, ref GameObject L__e, ref GameObject L__f)
    //후행연구 3개, 선행라인 2개, 후행라인 6개
    {
        if (a == false && b == true)
        {
            c.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            d.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            e.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            f.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            L__1.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
            L__2.GetComponent<Image>().color += new Color32(4, 4, 4, 0);
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

    /* ==================================================================================================== */

    public void Tech_1_Oepn() // 1번(증기기관) 연구 아이콘(버튼에 대입)을 눌렀을 때
    {
        title.text = "증기기관";
        exp.text = "증기기관은 수증기를 통해 열 에너지를 만들고, 그 에너지를 통해 운동한다.";
        Icon.GetComponent<Image>().sprite = TechCplImg1;
        UnitTransform(Tech1);
        TechOpenCom(ref Tech1Complete);
        PanelNum = 1;
        TechUpPanel.SetActive(true);
    }

    public void Tech_2_Oepn()
    {
        title.text = "증기선";
        exp.text = "증기기관을 동력으로 나아가는 기선이다.";
        Icon.GetComponent<Image>().sprite = TechCplImg2;
        UnitTransform(Tech2);
        TechOpenCom(ref Tech2Complete);
        PanelNum = 2;
        TechUpPanel.SetActive(true);
    }

    public void Tech_3_Oepn()
    {
        title.text = "수직기";
        exp.text = "사람의 손발로 움직여 베를 짜는 기계이다. 기존보다 발전합니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg3;
        UnitTransform(Tech3);
        TechOpenCom(ref Tech3Complete);
        PanelNum = 3;
        TechUpPanel.SetActive(true);
    }

    public void Tech_4_Oepn()
    {
        title.text = "방적기";
        exp.text = "동물과 식물에서 추출된 섬유로 실을 뽑는 기계이다. 직조가 자동화됩니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg4;
        UnitTransform(Tech4);
        TechOpenCom(ref Tech4Complete);
        PanelNum = 4;
        TechUpPanel.SetActive(true);
    }

    public void Tech_5_Oepn()
    {
        title.text = "증기기관+";
        exp.text = "기존 증기기관에서 응축기를 분리함으로써 열 능률을 올립니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg5;
        UnitTransform(Tech5);
        TechOpenCom(ref Tech5Complete);
        PanelNum = 5;
        TechUpPanel.SetActive(true);
    }

    public void Tech_6_Oepn()
    {
        title.text = "방직기";
        exp.text = "실을 얽고, 천을 만든다. 자동화 됩니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg6;
        UnitTransform(Tech6);
        TechOpenCom(ref Tech6Complete);
        PanelNum = 6;
        TechUpPanel.SetActive(true);
    }

    public void Tech_7_Oepn()
    {
        title.text = "기체화학";
        exp.text = "진공의 개념을 받아드리고 공기의 물리적 성질을 조사할 수 있습니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg7;
        UnitTransform(Tech7);
        TechOpenCom(ref Tech7Complete);
        PanelNum = 7;
        TechUpPanel.SetActive(true);
    }

    public void Tech_8_Oepn()
    {
        title.text = "동물전기";
        exp.text = "동물이 전기를 만들어 내는 것을 발견하다. 전류 연구의 방향을 제시합니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg8;
        UnitTransform(Tech8);
        TechOpenCom(ref Tech8Complete);
        PanelNum = 8;
        TechUpPanel.SetActive(true);
    }

    public void Tech_9_Oepn()
    {
        title.text = "대기전기";
        exp.text = "대기중에 존재하는 전기 현상에 대해서 관심을 가집니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg9;
        UnitTransform(Tech9);
        TechOpenCom(ref Tech9Complete);
        PanelNum = 9;
        TechUpPanel.SetActive(true);
    }

    public void Tech_10_Oepn()
    {
        title.text = "석탄";
        exp.text = "불타는 돌. 화력발전과 연료로 산업화를 가속시킵니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg10;
        UnitTransform(Tech10);
        TechOpenCom(ref Tech10Complete);
        PanelNum = 10;
        TechUpPanel.SetActive(true);
    }

    public void Tech_11_Oepn()
    {
        title.text = "철강업";
        exp.text = "철은 역사적으로 오랜 기간 동안 있어왔습니다. 이제는 강철의 시대입니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg11;
        UnitTransform(Tech11);
        TechOpenCom(ref Tech11Complete);
        PanelNum = 11;
        TechUpPanel.SetActive(true);
    }

    public void Tech_12_Oepn()
    {
        title.text = "증기압축";
        exp.text = "가스를 압축하여 액체상태로 만듭니다. 기체로 열을 조절할 수 있습니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg12;
        UnitTransform(Tech12);
        TechOpenCom(ref Tech12Complete);
        PanelNum = 12;
        TechUpPanel.SetActive(true);
    }

    public void Tech_13_Oepn()
    {
        title.text = "자기력";
        exp.text = "자기장을 변화시키면 전기장과 전류를 유도할 수 있습니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg13;
        UnitTransform(Tech13);
        TechOpenCom(ref Tech13Complete);
        PanelNum = 13;
        TechUpPanel.SetActive(true);
    }

    public void Tech_14_Oepn()
    {
        title.text = "열역학";
        exp.text = "열과 에너지에 대한 연구입니다. 열에 따라 물질의 형상 변화에 대해 알게됩니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg14;
        UnitTransform(Tech14);
        TechOpenCom(ref Tech14Complete);
        PanelNum = 14;
        TechUpPanel.SetActive(true);
    }

    public void Tech_15_Oepn()
    {
        title.text = "유선통신";
        exp.text = "선과 선이 연결되는 곳이면, 정보를 전달할 수 있습니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg15;
        UnitTransform(Tech15);
        TechOpenCom(ref Tech15Complete);
        PanelNum = 15;
        TechUpPanel.SetActive(true);
    }

    public void Tech_16_Oepn()
    {
        title.text = "탄도학";
        exp.text = "날라가는 모든 비상체는 힘에 의해 최종목표까지 도달할 수 있어야 합니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg16;
        UnitTransform(Tech16);
        TechOpenCom(ref Tech16Complete);
        PanelNum = 16;
        TechUpPanel.SetActive(true);
    }

    public void Tech_17_Oepn()
    {
        title.text = "나이트로글리세린";
        exp.text = "폭발성과 유독성을 가진 투명 무색의 액체입니다. 매우 불안정합니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg17;
        UnitTransform(Tech17);
        TechOpenCom(ref Tech17Complete);
        PanelNum = 17;
        TechUpPanel.SetActive(true);
    }

    public void Tech_18_Oepn()
    {
        title.text = "소리";
        exp.text = "전통적인 감각기관을 자극하는 요소입니다. 이제는 시각으로 소리를 볼 수 있습니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg18;
        UnitTransform(Tech18);
        TechOpenCom(ref Tech18Complete);
        PanelNum = 18;
        TechUpPanel.SetActive(true);
    }

    public void Tech_19_Oepn()
    {
        title.text = "전류진동";
        exp.text = "진동하는 전기장이 발생하면 주기적으로 진동하는 자기장이 발생합니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg19;
        UnitTransform(Tech19);
        TechOpenCom(ref Tech19Complete);
        PanelNum = 19;
        TechUpPanel.SetActive(true);
    }

    public void Tech_20_Oepn()
    {
        title.text = "필라멘트";
        exp.text = "진공관 내부에 전류를 통하게 하는 실처럼 가는 선입니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg20;
        UnitTransform(Tech20);
        TechOpenCom(ref Tech20Complete);
        PanelNum = 20;
        TechUpPanel.SetActive(true);
    }

    public void Tech_21_Oepn()
    {
        title.text = "무선통신";
        exp.text = "이제 정보를 주고 받는데 공간적 제약을 극복합니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg21;
        UnitTransform(Tech21);
        TechOpenCom(ref Tech21Complete);
        PanelNum = 21;
        TechUpPanel.SetActive(true);
    }

    public void Tech_22_Oepn()
    {
        title.text = "비행";
        exp.text = "엔진을 이용하여 하늘을 누릴 수 있습니다. 더 이상 새들이 독점하는 공간이 아닙니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg22;
        UnitTransform(Tech22);
        TechOpenCom(ref Tech22Complete);
        PanelNum = 22;
        TechUpPanel.SetActive(true);
    }

    public void Tech_23_Oepn()
    {
        title.text = "개틀링건";
        exp.text = "회전운동을 왕복운동으로 바꾸어 여러 개의 총신에서 높은 발사력을 지닙니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg23;
        UnitTransform(Tech23);
        TechOpenCom(ref Tech23Complete);
        PanelNum = 23;
        TechUpPanel.SetActive(true);
    }

    public void Tech_24_Oepn()
    {
        title.text = "진공";
        exp.text = "외부로부터 어떠한 작용도 내부의 물질도 존재하지 않는 공간입니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg24;
        UnitTransform(Tech24);
        TechOpenCom(ref Tech24Complete);
        PanelNum = 24;
        TechUpPanel.SetActive(true);
    }

    public void Tech_25_Oepn()
    {
        title.text = "오프셋인쇄";
        exp.text = "인쇄판과 고무롤러를 사용해 종이에 인쇄하는 방법입니다.  대량의 인쇄가 가능합니다";
        Icon.GetComponent<Image>().sprite = TechCplImg25;
        UnitTransform(Tech25);
        TechOpenCom(ref Tech25Complete);
        PanelNum = 25;
        TechUpPanel.SetActive(true);
    }

    public void Tech_26_Oepn()
    {
        title.text = "냉각순환";
        exp.text = "열을 빼앗아 온도를 낮춥니다. 원하는 공간의 온도를 조절할 수 있습니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg26;
        UnitTransform(Tech26);
        TechOpenCom(ref Tech26Complete);
        PanelNum = 26;
        TechUpPanel.SetActive(true);
    }

    public void Tech_27_Oepn()
    {
        title.text = "전자기파";
        exp.text = "특정 전자기적인 과정에서 복사되는 에너지입니다. 볼 순 없지만 사용할 순 있습니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg27;
        UnitTransform(Tech27);
        TechOpenCom(ref Tech27Complete);
        PanelNum = 27;
        TechUpPanel.SetActive(true);
    }

    public void Tech_28_Oepn()
    {
        title.text = "폭격기";
        exp.text = "폭탄을 싣고 적의 시설이나 진지를 폭격하는 항공기체입니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg28;
        UnitTransform(Tech28);
        TechOpenCom(ref Tech28Complete);
        PanelNum = 28;
        TechUpPanel.SetActive(true);
    }

    public void Tech_29_Oepn()
    {
        title.text = "4기통엔진";
        exp.text = "실린더의 개수가 4개인 엔진입니다. 기계의 심장입니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg29;
        UnitTransform(Tech29);
        TechOpenCom(ref Tech29Complete);
        PanelNum = 29;
        TechUpPanel.SetActive(true);
    }

    public void Tech_30_Oepn()
    {
        title.text = "암모니아";
        exp.text = "자극적인 악취가 나는 무색의 기체입니다. 인공적으로 만들 수 있습니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg30;
        UnitTransform(Tech30);
        TechOpenCom(ref Tech30Complete);
        PanelNum = 30;
        TechUpPanel.SetActive(true);
    }

    public void Tech_31_Oepn()
    {
        title.text = "암호학";
        exp.text = "정보의 소통이 많아짐에 따라 평문에 기밀성을 더하는 연구입니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg31;
        UnitTransform(Tech31);
        TechOpenCom(ref Tech31Complete);
        PanelNum = 31;
        TechUpPanel.SetActive(true);
    }

    public void Tech_32_Oepn()
    {
        title.text = "탱크";
        exp.text = "무한궤도를 장착한 기갑 전투 차량입니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg32;
        UnitTransform(Tech32);
        TechOpenCom(ref Tech32Complete);
        PanelNum = 32;
        TechUpPanel.SetActive(true);
    }

    public void Tech_33_Oepn()
    {
        title.text = "급속동결";
        exp.text = "최대얼음결정생성대의 온도대역을 빠르게 통과하는 기술입니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg33;
        UnitTransform(Tech33);
        TechOpenCom(ref Tech33Complete);
        PanelNum = 33;
        TechUpPanel.SetActive(true);
    }

    public void Tech_34_Oepn()
    {
        title.text = "항생재";
        exp.text = "세균을 죽이거나 세균의 성장을 억제하는 약입니다. 인공적으로 제공 가능합니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg34;
        UnitTransform(Tech34);
        TechOpenCom(ref Tech34Complete);
        PanelNum = 34;
        TechUpPanel.SetActive(true);
    }

    public void Tech_35_Oepn()
    {
        title.text = "나일론";
        exp.text = "인공적으로 만들어 낸 합성 섬유입니다. 가볍고 부드러우며 탄력적입니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg35;
        UnitTransform(Tech35);
        TechOpenCom(ref Tech35Complete);
        PanelNum = 35;
        TechUpPanel.SetActive(true);
    }

    public void Tech_36_Oepn()
    {
        title.text = "제트엔진";
        exp.text = "고온의 가스를 분출하여 반작용을 통해 추진력을 얻는 엔진입니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg36;
        UnitTransform(Tech36);
        TechOpenCom(ref Tech36Complete);
        PanelNum = 36;
        TechUpPanel.SetActive(true);
    }

    public void Tech_37_Oepn()
    {
        title.text = "우라늄";
        exp.text = "α붕괴를 하는 광택이 있는 백색 고체의 금속입니다. 피폭의 위험이 있습니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg37;
        UnitTransform(Tech37);
        TechOpenCom(ref Tech37Complete);
        PanelNum = 37;
        TechUpPanel.SetActive(true);
    }

    public void Tech_38_Oepn()
    {
        title.text = "삼원색";
        exp.text = "모든 빛깔의 바탕이 되는 세 원색입니다. 전자상의 모든 색을 표현할 수 있게됩니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg38;
        UnitTransform(Tech38);
        TechOpenCom(ref Tech38Complete);
        PanelNum = 38;
        TechUpPanel.SetActive(true);
    }

    public void Tech_39_Oepn()
    {
        title.text = "극초단파";
        exp.text = "주파수가 300㎒에서 3.0㎓ 사이에 할당된 전자기파 입니다. 고주파와 저주파를 나눕니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg39;
        UnitTransform(Tech39);
        TechOpenCom(ref Tech39Complete);
        PanelNum = 39;
        TechUpPanel.SetActive(true);
    }

    public void Tech_40_Oepn()
    {
        title.text = "신호변환";
        exp.text = "전류의 흐름을 제어할 수 있게 됩니다. 순방향과 역방향 전압을 조절할 수 있게 됩니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg40;
        UnitTransform(Tech40);
        TechOpenCom(ref Tech40Complete);
        PanelNum = 40;
        TechUpPanel.SetActive(true);
    }

    public void Tech_41_Oepn()
    {
        title.text = "레이저";
        exp.text = "공진기를 이용해서 전자파를 증폭해 얻을 수 있는 인공적인 빛입니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg41;
        UnitTransform(Tech41);
        TechOpenCom(ref Tech41Complete);
        PanelNum = 41;
        TechUpPanel.SetActive(true);
    }

    public void Tech_42_Oepn()
    {
        title.text = "해열진통제";
        exp.text = "우리 몸이 통증을 느끼는 기준치를 올려줍니다. 고통을 더 오래 참을 수 있습니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg42;
        UnitTransform(Tech42);
        TechOpenCom(ref Tech42Complete);
        PanelNum = 42;
        TechUpPanel.SetActive(true);
    }

    public void Tech_43_Oepn()
    {
        title.text = "자기저장소";
        exp.text = "자기력을 이용하여 정보를 보관 및 관리할 수 있습니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg43;
        UnitTransform(Tech43);
        TechOpenCom(ref Tech43Complete);
        PanelNum = 43;
        TechUpPanel.SetActive(true);
    }

    public void Tech_44_Oepn()
    {
        title.text = "소리+";
        exp.text = "매개만 있다면 세계의 있는 모든 소음을 더 정확하게 전달할 수 있습니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg44;
        UnitTransform(Tech44);
        TechOpenCom(ref Tech44Complete);
        PanelNum = 44;
        TechUpPanel.SetActive(true);
    }

    public void Tech_45_Oepn()
    {
        title.text = "발광다이오드";
        exp.text = "전압을 가하면 발광하는 반도체 소자입니다. 이전 전구보다 더 밝은 빛을 냅니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg45;
        UnitTransform(Tech45);
        TechOpenCom(ref Tech45Complete);
        PanelNum = 45;
        TechUpPanel.SetActive(true);
    }

    public void Tech_46_Oepn()
    {
        title.text = "신경안정제";
        exp.text = "중추신경 억제성 기능을 강화시켜 진정과 항불안의 효과를 냅니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg46;
        UnitTransform(Tech46);
        TechOpenCom(ref Tech46Complete);
        PanelNum = 46;
        TechUpPanel.SetActive(true);
    }

    public void Tech_47_Oepn()
    {
        title.text = "저장소+";
        exp.text = "전압을 중지하면 정보는 사라지지만, 정보를 빠르게 불러올 수 있습니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg47;
        UnitTransform(Tech47);
        TechOpenCom(ref Tech47Complete);
        PanelNum = 47;
        TechUpPanel.SetActive(true);
    }

    public void Tech_48_Oepn()
    {
        title.text = "논리회로";
        exp.text = "논리적 입력값에 대해 논리 연산을 수행하고 논리적 출력값을 얻을 수 있습니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg48;
        UnitTransform(Tech48);
        TechOpenCom(ref Tech48Complete);
        PanelNum = 48;
        TechUpPanel.SetActive(true);
    }

    public void Tech_49_Oepn()
    {
        title.text = "전자두뇌";
        exp.text = "기계의 두뇌입니다. 기계의 모든 활동을 제어할 수 있는 중추입니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg49;
        UnitTransform(Tech49);
        TechOpenCom(ref Tech49Complete);
        PanelNum = 49;
        TechUpPanel.SetActive(true);
    }

    public void Tech_50_Oepn()
    {
        title.text = "보이저계획";
        exp.text = "우주탐사선을 통해 외태양계 연구를 진행할 수 있습니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg50;
        UnitTransform(Tech50);
        TechOpenCom(ref Tech50Complete);
        PanelNum = 50;
        TechUpPanel.SetActive(true);
    }

    public void Tech_51_Oepn()
    {
        title.text = "콜레스테릭";
        exp.text = "액정에서 분자의 배열방식 패턴의 하나입니다.  고체와 액체의 중간상태를 띱니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg51;
        UnitTransform(Tech51);
        TechOpenCom(ref Tech51Complete);
        PanelNum = 51;
        TechUpPanel.SetActive(true);
    }

    public void Tech_52_Oepn()
    {
        title.text = "이더넷";
        exp.text = "네트워크 위에 흐르고 있는 데이터를 감지하여 양방향적 전송이 가능해집니다. ";
        Icon.GetComponent<Image>().sprite = TechCplImg52;
        UnitTransform(Tech52);
        TechOpenCom(ref Tech52Complete);
        PanelNum = 52;
        TechUpPanel.SetActive(true);
    }

    public void Tech_53_Oepn()
    {
        title.text = "양성자반응";
        exp.text = "수소 원자핵이 자기장 내에서 자기장과 상호작용하며 특정 주파수의 패턴을 측정합니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg53;
        UnitTransform(Tech53);
        TechOpenCom(ref Tech53Complete);
        PanelNum = 53;
        TechUpPanel.SetActive(true);
    }

    public void Tech_54_Oepn()
    {
        title.text = "전송";
        exp.text = "공간, 시간에 상관없이 우리가 보내고 싶은 정보를 그대로 전달합니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg54;
        UnitTransform(Tech54);
        TechOpenCom(ref Tech54Complete);
        PanelNum = 54;
        TechUpPanel.SetActive(true);
    }

    public void Tech_55_Oepn()
    {
        title.text = "전자오락";
        exp.text = "전자기 물체를 이용해서 유희를 즐길 수 있습니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg55;
        UnitTransform(Tech55);
        TechOpenCom(ref Tech55Complete);
        PanelNum = 55;
        TechUpPanel.SetActive(true);
    }

    public void Tech_56_Oepn()
    {
        title.text = "컴퓨터언어";
        exp.text = "회로에 물리적인 변화를 가하지 않더라도 기계에 내부적 변화를 가할 수 있습니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg56;
        UnitTransform(Tech56);
        TechOpenCom(ref Tech56Complete);
        PanelNum = 56;
        TechUpPanel.SetActive(true);
    }

    public void Tech_57_Oepn()
    {
        title.text = "유전자치료";
        exp.text = "유전자 내부의 암호를 밝혀냅니다. 유전자 변형을 통해 근본적인 문제를 해결합니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg57;
        UnitTransform(Tech57);
        TechOpenCom(ref Tech57Complete);
        PanelNum = 57;
        TechUpPanel.SetActive(true);
    }

    public void Tech_58_Oepn()
    {
        title.text = "근거리통신망";
        exp.text = "불특정 다수의 사람들이 네트워크를 공유합니다. 전자세계가 더 광범위해집니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg58;
        UnitTransform(Tech58);
        TechOpenCom(ref Tech58Complete);
        PanelNum = 58;
        TechUpPanel.SetActive(true);
    }

    public void Tech_59_Oepn()
    {
        title.text = "통신위성";
        exp.text = "통신을 주목적으로 우주에 머무르고 있는 인공위성입니다. 다양한 궤도에 안착합니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg59;
        UnitTransform(Tech59);
        TechOpenCom(ref Tech59Complete);
        PanelNum = 59;
        TechUpPanel.SetActive(true);
    }

    public void Tech_60_Oepn()
    {
        title.text = "유전자변화";
        exp.text = "유전자를 단순 절개할 뿐만 아니라 원하는 방식으로 개조합니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg60;
        UnitTransform(Tech60);
        TechOpenCom(ref Tech60Complete);
        PanelNum = 60;
        TechUpPanel.SetActive(true);
    }

    public void Tech_61_Oepn()
    {
        title.text = "세계통합";
        exp.text = "세계는 하나가 됩니다. 전자 안에서.";
        Icon.GetComponent<Image>().sprite = TechCplImg61;
        UnitTransform(Tech61);
        TechOpenCom(ref Tech61Complete);
        PanelNum = 61;
        TechUpPanel.SetActive(true);
    }

    public void Tech_62_Oepn()
    {
        title.text = "복제";
        exp.text = "DNA, 세포, 유기체을 복사해서 동일한 개체를 생산합니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg62;
        UnitTransform(Tech62);
        TechOpenCom(ref Tech62Complete);
        PanelNum = 62;
        TechUpPanel.SetActive(true);
    }

    public void Tech_63_Oepn()
    {
        title.text = "컴퓨터+";
        exp.text = "컴퓨터의 성능은 모든 세계에 걸쳐 진보합니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg63;
        UnitTransform(Tech63);
        TechOpenCom(ref Tech63Complete);
        PanelNum = 63;
        TechUpPanel.SetActive(true);
    }

    public void Tech_64_Oepn()
    {
        title.text = "블록체인";
        exp.text = "각 데이터인 블록들이 누구도 변경할 수 없는 고유한 코드를 가지게 됩니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg64;
        UnitTransform(Tech64);
        TechOpenCom(ref Tech64Complete);
        PanelNum = 64;
        TechUpPanel.SetActive(true);
    }

    public void Tech_65_Oepn()
    {
        title.text = "AI";
        exp.text = "기계는 스스로 작동하고 움직입니다. 그리고 판단합니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg65;
        UnitTransform(Tech65);
        TechOpenCom(ref Tech65Complete);
        PanelNum = 65;
        TechUpPanel.SetActive(true);
    }

    public void Tech_66_Oepn()
    {
        title.text = "고속통신";
        exp.text = "통신의 속도는 사람의 인지가 따라오기 힘들 정도로 빨라집니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg66;
        UnitTransform(Tech66);
        TechOpenCom(ref Tech66Complete);
        PanelNum = 66;
        TechUpPanel.SetActive(true);
    }

    public void Tech_67_Oepn()
    {
        title.text = "가상현실";
        exp.text = "사용자는 창조자가 만든 어떤 세계를 실재의 세계처럼 느끼게 됩니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg67;
        UnitTransform(Tech67);
        TechOpenCom(ref Tech67Complete);
        PanelNum = 67;
        TechUpPanel.SetActive(true);
    }

    public void Tech_68_Oepn()
    {
        title.text = "증강현실";
        exp.text = "실제 존재하는 환경을 전자세계에 똑같이 혹은 개선된 형태로 복사합니다. ";
        Icon.GetComponent<Image>().sprite = TechCplImg68;
        UnitTransform(Tech68);
        TechOpenCom(ref Tech68Complete);
        PanelNum = 68;
        TechUpPanel.SetActive(true);
    }

    public void Tech_69_Oepn()
    {
        title.text = "제품화";
        exp.text = "생체학적인 모든 신체부위를 기계로 변환 가능합니다. 하나의 칩으로 생각은 공유됩니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg69;
        UnitTransform(Tech69);
        TechOpenCom(ref Tech69Complete);
        PanelNum = 69;
        TechUpPanel.SetActive(true);
    }

    public void Tech_70_Oepn()
    {
        title.text = "서버변경";
        exp.text = "차원을 경유합니다. 공간상 이동의 의미가 사라집니다.";
        Icon.GetComponent<Image>().sprite = TechCplImg70;
        UnitTransform(Tech70);
        TechOpenCom(ref Tech70Complete);
        PanelNum = 70;
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

    void UnitTransform(long a)
    {
        long b;
        if(a <= 999999999)
        {
            NeedScience.text = a.ToString("###,###");
        }
        else if(a <= 999999999999)
        {
            b = a / 1000;
            NeedScience.text = b.ToString("###,###") + " k";
        }
        else if (a <= 999999999999999)
        {
            b = a / 1000000;
            NeedScience.text = b.ToString("###,###") + " m";
        }
        else if (a <= 999999999999999999)
        {
            b = a / 1000000000;
            NeedScience.text = b.ToString("###,###") + " b";
        }
        else if (a <= 9223372036854775807)
        {
            b = a / 1000000000000;
            NeedScience.text = b.ToString("###,###") + " t";
        }
    }

    /* ==================================================================================================== */

    IEnumerator TechUpButtonCheck()
    {
        while (true)
        {
            if (PanelNum == 1)
            {
                if (Tech1Complete == false && GameManager.science >= Tech1)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 2)
            {
                if (Tech2Complete == false && GameManager.science >= Tech2 && Tech1Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 3)
            {
                if (Tech3Complete == false && GameManager.science >= Tech3 && Tech1Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 4)
            {
                if (Tech4Complete == false && GameManager.science >= Tech4 && Tech3Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 5)
            {
                if (Tech5Complete == false && GameManager.science >= Tech5 && Tech2Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 6)
            {
                if (Tech6Complete == false && GameManager.science >= Tech6 && Tech4Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 7)
            {
                if (Tech7Complete == false && GameManager.science >= Tech7 && Tech2Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 8)
            {
                if (Tech8Complete == false && GameManager.science >= Tech8 && Tech7Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 9)
            {
                if (Tech9Complete == false && GameManager.science >= Tech9 && Tech8Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 10)
            {
                if (Tech10Complete == false && GameManager.science >= Tech10 && Tech7Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 11)
            {
                if (Tech11Complete == false && GameManager.science >= Tech11 && Tech10Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 12)
            {
                if (Tech12Complete == false && GameManager.science >= Tech12 && Tech10Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 13)
            {
                if (Tech13Complete == false && GameManager.science >= Tech13 && Tech9Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 14)
            {
                if (Tech14Complete == false && GameManager.science >= Tech14 && Tech11Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 15)
            {
                if (Tech15Complete == false && GameManager.science >= Tech15 && Tech13Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 16)
            {
                if (Tech16Complete == false && GameManager.science >= Tech16 && Tech14Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 17)
            {
                if (Tech17Complete == false && GameManager.science >= Tech17 && Tech14Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 18)
            {
                if (Tech18Complete == false && GameManager.science >= Tech18 && Tech16Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 19)
            {
                if (Tech19Complete == false && GameManager.science >= Tech19 && Tech15Complete == true && Tech17Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 20)
            {
                if (Tech20Complete == false && GameManager.science >= Tech20 && Tech17Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 21)
            {
                if (Tech21Complete == false && GameManager.science >= Tech21 && Tech20Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 22)
            {
                if (Tech22Complete == false && GameManager.science >= Tech22 && Tech20Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 23) // 전쟁시대
            {
                if (Tech23Complete == false && GameManager.science >= Tech23 && age_war == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 24)
            {
                if (Tech24Complete == false && GameManager.science >= Tech24 && Tech23Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 25)
            {
                if (Tech25Complete == false && GameManager.science >= Tech25 && Tech23Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 26)
            {
                if (Tech26Complete == false && GameManager.science >= Tech26 && Tech24Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 27)
            {
                if (Tech27Complete == false && GameManager.science >= Tech27 && Tech26Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 28)
            {
                if (Tech28Complete == false && GameManager.science >= Tech28 && Tech26Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 29)
            {
                if (Tech29Complete == false && GameManager.science >= Tech29 && Tech25Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 30)
            {
                if (Tech30Complete == false && GameManager.science >= Tech30 && Tech27Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 31)
            {
                if (Tech31Complete == false && GameManager.science >= Tech31 && Tech30Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 32)
            {
                if (Tech32Complete == false && GameManager.science >= Tech32 && Tech28Complete == true && Tech29Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 33)
            {
                if (Tech33Complete == false && GameManager.science >= Tech33 && Tech31Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 34)
            {
                if (Tech34Complete == false && GameManager.science >= Tech34 && Tech32Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 35)
            {
                if (Tech35Complete == false && GameManager.science >= Tech35 && Tech34Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 36)
            {
                if (Tech36Complete == false && GameManager.science >= Tech36 && Tech33Complete == true && Tech34Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 37)
            {
                if (Tech37Complete == false && GameManager.science >= Tech37 && Tech34Complete == true && Tech35Complete == true && Tech36Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 38) // 전자시대
            {
                if (Tech38Complete == false && GameManager.science >= Tech38 && age_elec == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 39)
            {
                if (Tech39Complete == false && GameManager.science >= Tech39 && Tech38Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 40)
            {
                if (Tech40Complete == false && GameManager.science >= Tech40 && Tech38Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 41)
            {
                if (Tech41Complete == false && GameManager.science >= Tech41 && Tech40Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 42)
            {
                if (Tech42Complete == false && GameManager.science >= Tech42 && Tech40Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 43)
            {
                if (Tech43Complete == false && GameManager.science >= Tech43 && Tech40Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 44)
            {
                if (Tech44Complete == false && GameManager.science >= Tech44 && Tech41Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 45)
            {
                if (Tech45Complete == false && GameManager.science >= Tech45 && Tech43Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 46)
            {
                if (Tech46Complete == false && GameManager.science >= Tech46 && Tech42Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 47)
            {
                if (Tech47Complete == false && GameManager.science >= Tech47 && Tech45Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 48)
            {
                if (Tech48Complete == false && GameManager.science >= Tech48 && Tech45Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 49)
            {
                if (Tech49Complete == false && GameManager.science >= Tech49 && Tech47Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 50)
            {
                if (Tech50Complete == false && GameManager.science >= Tech50 && Tech45Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 51)
            {
                if (Tech51Complete == false && GameManager.science >= Tech51 && Tech48Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 52)
            {
                if (Tech52Complete == false && GameManager.science >= Tech52 && Tech50Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 53)
            {
                if (Tech53Complete == false && GameManager.science >= Tech53 && Tech50Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 54)
            {
                if (Tech54Complete == false && GameManager.science >= Tech54 && Tech52Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 55)
            {
                if (Tech55Complete == false && GameManager.science >= Tech55 && Tech53Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 56) // 현대시대
            {
                if (Tech56Complete == false && GameManager.science >= Tech56 && age_modern == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 57)
            {
                if (Tech57Complete == false && GameManager.science >= Tech57 && Tech56Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 58)
            {
                if (Tech58Complete == false && GameManager.science >= Tech58 && Tech56Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 59)
            {
                if (Tech59Complete == false && GameManager.science >= Tech59 && Tech58Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 60)
            {
                if (Tech60Complete == false && GameManager.science >= Tech60 && Tech57Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 61)
            {
                if (Tech61Complete == false && GameManager.science >= Tech61 && Tech59Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 62)
            {
                if (Tech62Complete == false && GameManager.science >= Tech62 && Tech60Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 63)
            {
                if (Tech63Complete == false && GameManager.science >= Tech63 && Tech61Complete == true && Tech62Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 64)
            {
                if (Tech64Complete == false && GameManager.science >= Tech64 && Tech63Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 65)
            {
                if (Tech65Complete == false && GameManager.science >= Tech65 && Tech63Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 66)
            {
                if (Tech66Complete == false && GameManager.science >= Tech66 && Tech64Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 67)
            {
                if (Tech67Complete == false && GameManager.science >= Tech67 && Tech65Complete == true && Tech66Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 68)
            {
                if (Tech68Complete == false && GameManager.science >= Tech68 && Tech67Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 69)
            {
                if (Tech69Complete == false && GameManager.science >= Tech69 && Tech68Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else if (PanelNum == 70)
            {
                if (Tech70Complete == false && GameManager.science >= Tech70 && Tech69Complete == true)
                {
                    TechUpBtn.interactable = true;
                }
                else
                {
                    TechUpBtn.interactable = false;
                }
            }
            else
            {
                TechUpBtn.interactable = false;
            }

            yield return new WaitForSeconds(0.15f);
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
            TechIcon37.GetComponent<Button>().interactable = true;
            if (TechIcon37.GetComponent<Image>().color.a < 2.7)
            {
                TechIcon37.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            }
        }

        if (Tech61Complete == true && Tech62Complete == true && Tech63Complete == false) // 세계통합(61) + 복제(62) -> 컴퓨터(63)
        {
            TechIcon63.GetComponent<Button>().interactable = true;
            if (TechIcon63.GetComponent<Image>().color.a < 2.7)
            {
                TechIcon63.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            }
        }

        if (Tech65Complete == true && Tech66Complete == true && Tech67Complete == false) // AI(65) + 고속통신(66) -> 가상현실(67)
        {
            TechIcon67.GetComponent<Button>().interactable = true;
            if (TechIcon67.GetComponent<Image>().color.a < 2.7)
            {
                TechIcon67.GetComponent<Image>().color += new Color32(0, 0, 0, 2);
            }
        }
    }
}