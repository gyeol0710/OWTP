using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Xml;

public class GameManager : MonoBehaviour
{
    public long StandardConst_GoldUp;
    public double GoldUp_Lv1_10;
    public double GoldUp_Lv11_20;
    public double GoldUp_Lv21_30;
    public double GoldUp_Lv31_40;
    public double GoldUp_Lv41_50;
    public double GoldUp_Lv51_60;
    public double GoldUp_Lv61_70;
    public double GoldUp_Lv71_80;
    public double GoldUp_Lv81_90;
    public double GoldUp_Lv91_100;
    public double GoldUp_Lv101_110;
    public double GoldUp_Lv111_120;
    public double GoldUp_Lv121_130;
    public double GoldUp_Lv131_140;
    public double GoldUp_Lv141_150;
    public double GoldUp_Lv151_160;
    public double GoldUp_Lv161_170;
    public double GoldUp_Lv171_180;
    public double GoldUp_Lv181_190;
    public double GoldUp_Lv191_200;
    public double GoldUp_Lv201_210;
    public double GoldUp_Lv211_220;
    public double GoldUp_Lv221_230;
    public double GoldUp_Lv231_240;
    public double GoldUp_Lv241_250;
    public double GoldUp_Lv251_260;
    public double GoldUp_Lv261_270;
    public double GoldUp_Lv271_280;
    public double GoldUp_Lv281_290;
    public double GoldUp_Lv291_300;
    public double GoldUp_Lv301_310;
    public double GoldUp_Lv311_320;
    public double GoldUp_Lv321_330;
    public double GoldUp_Lv331_340;
    public double GoldUp_Lv341_350;
    public double GoldUp_Lv351_360;
    public double GoldUp_Lv361_370;
    public double GoldUp_Lv371_380;
    public double GoldUp_Lv381_390;
    public double GoldUp_Lv391_400;
    public double GoldUp_Lv401_410;
    public double GoldUp_Lv411_420;
    public double GoldUp_Lv421_430;
    public double GoldUp_Lv431_440;
    public double GoldUp_Lv441_450;
    public double GoldUp_Lv451_460;
    public double GoldUp_Lv461_470;
    public double GoldUp_Lv471_480;
    public double GoldUp_Lv481_490;
    public double GoldUp_Lv491_500;

    public long Science_Lv1_10;
    public long Science_Lv11_20;
    public long Science_Lv21_30;
    public long Science_Lv31_40;
    public long Science_Lv41_50;
    public long Science_Lv51_60;
    public long Science_Lv61_70;
    public long Science_Lv71_80;
    public long Science_Lv81_90;
    public long Science_Lv91_100;
    public long Science_Lv101_110;
    public long Science_Lv111_120;
    public long Science_Lv121_130;
    public long Science_Lv131_140;
    public long Science_Lv141_150;
    public long Science_Lv151_160;
    public long Science_Lv161_170;
    public long Science_Lv171_180;
    public long Science_Lv181_190;
    public long Science_Lv191_200;
    public long Science_Lv201_210;
    public long Science_Lv211_220;
    public long Science_Lv221_230;
    public long Science_Lv231_240;
    public long Science_Lv241_250;
    public long Science_Lv251_260;
    public long Science_Lv261_270;
    public long Science_Lv271_280;
    public long Science_Lv281_290;
    public long Science_Lv291_300;
    public long Science_Lv301_310;
    public long Science_Lv311_320;
    public long Science_Lv321_330;
    public long Science_Lv331_340;
    public long Science_Lv341_350;
    public long Science_Lv351_360;
    public long Science_Lv361_370;
    public long Science_Lv371_380;
    public long Science_Lv381_390;
    public long Science_Lv391_400;
    public long Science_Lv401_410;
    public long Science_Lv411_420;
    public long Science_Lv421_430;
    public long Science_Lv431_440;
    public long Science_Lv441_450;
    public long Science_Lv451_460;
    public long Science_Lv461_470;
    public long Science_Lv471_480;
    public long Science_Lv481_490;
    public long Science_Lv491_500;

    public long StandardConst_Need;
    public double Need_Lv1_10;
    public double Need_Lv11_20;
    public double Need_Lv21_30;
    public double Need_Lv31_40;
    public double Need_Lv41_50;
    public double Need_Lv51_60;
    public double Need_Lv61_70;
    public double Need_Lv71_80;
    public double Need_Lv81_90;
    public double Need_Lv91_100;
    public double Need_Lv101_110;
    public double Need_Lv111_120;
    public double Need_Lv121_130;
    public double Need_Lv131_140;
    public double Need_Lv141_150;
    public double Need_Lv151_160;
    public double Need_Lv161_170;
    public double Need_Lv171_180;
    public double Need_Lv181_190;
    public double Need_Lv191_200;
    public double Need_Lv201_210;
    public double Need_Lv211_220;
    public double Need_Lv221_230;
    public double Need_Lv231_240;
    public double Need_Lv241_250;
    public double Need_Lv251_260;
    public double Need_Lv261_270;
    public double Need_Lv271_280;
    public double Need_Lv281_290;
    public double Need_Lv291_300;
    public double Need_Lv301_310;
    public double Need_Lv311_320;
    public double Need_Lv321_330;
    public double Need_Lv331_340;
    public double Need_Lv341_350;
    public double Need_Lv351_360;
    public double Need_Lv361_370;
    public double Need_Lv371_380;
    public double Need_Lv381_390;
    public double Need_Lv391_400;
    public double Need_Lv401_410;
    public double Need_Lv411_420;
    public double Need_Lv421_430;
    public double Need_Lv431_440;
    public double Need_Lv441_450;
    public double Need_Lv451_460;
    public double Need_Lv461_470;
    public double Need_Lv471_480;
    public double Need_Lv481_490;
    public double Need_Lv491_500;

    static public bool RePlay;

    static public long money; // 돈
    public long ConvertedMoney; // 변환된 돈
    public long DisplayedMoney; // 표시되는 돈
    public long moneyIncreaseAmount; // 클릭 시 돈 증가량
    static public long science; // 연구력
    public long ConvertedScience; // 변환된 연구력
    static public long scienceIncreaseAmount; // 클릭 시 연구력 증가량
    public string MoneyUnitSize; // 돈 변환 단위
    public string ScienceUnitSize; // 돈 변환 단위

    public long robotLevelUpPrice; // 로봇 레벨업 비용
    public Text robotTierAndLevel; // 로봇 업그레이드 패널 티어 및 레벨
    public Text robotInfo1; // 로봇 현재 골드 획득 및 지식 획득 정보
    public Text robotInfo2;
    public Text robotInfo3;
    public Button robotLevelUpButton; // 로봇 레벨업 버튼

    static public int years; // 연도
    static public int robotLevel; // 로봇 레벨

    public Text textMoney;
    public Text textScience;
    public Text textYears;

    public GameObject prefabMoney;
    public GameObject prefabScience;

    public GameObject Offer01;
    public GameObject Offer02;
    public GameObject Offer03;
    public ScrollRect ScR; // 제안창 스크롤렉트 코루틴 강제 진행을 위해 스프라이트 이미지 컬러 접근을 위한 변수
    public GameObject JokeButton;

    public GameObject Noti_R;
    public GameObject Noti_P;
    public GameObject Noti_T;
    public GameObject Noti_O;

    public Image Click_Button;
    public Sprite Button_normal;
    public Sprite Button_normal_pushed;
    public Sprite Button_Bomb;
    public Sprite Button_Bomb_pushed;

    public GameObject panel_robot;
    public GameObject panel_Quit;

    //-----------------------------------------
    static public float SpaceshipGoldBonus;

    static public float AdBonus;
    static public float CashBonus;
    static public float ClickBonus;

    static public float SpaceshipScienceBonus;

    static public bool eventOn;
    static public int ClickCount_Fuel2;
    static public int ClickCount_Cockpit2;
    static public bool Story_Fuel2_Complete;
    static public bool Story_Engine2_Complete;
    static public bool Story_Cockpit2_Complete;
    static public int Engine2_RobotSpeed;
    static public float Fuel2Debuff;
    static public float Engine2Debuff;
    static public float Cockpit2Debuff;

    static public float FinalGoldBonus;
    static public float FinalScienceBonus;

    static public float Fuel2Bonus;
    static public float Engine2Bonus;
    static public float Cockpit2Bonus;
    //------------------------------------


    /* 우주선 연료, 엔진, 조종판 1단계 관련 */
    static public long SSclickBonus;
    static public int SStimer;
    public GameObject SSclickIMG;
    static public GameObject sSclickIMG;
    //----------------------------------


    /*  */

    //---------------------


    /* 로봇 관련 */
    public SpriteRenderer Robot01;
    public SpriteRenderer Robot02;
    public SpriteRenderer Robot03;
    public SpriteRenderer Robot04;
    public SpriteRenderer Robot05;
    public SpriteRenderer Robot06;
    public SpriteRenderer Robot07;
    public SpriteRenderer Robot08;
    //-----------------------------------------
    int click_gauge;
    //-----------------------------------------
    public Text PerGoldInfo;
    public Text PerScienceInfo;
    public Text GoldMultipleInfo;
    public Text ScienceMultipleInfo;
    //--------------------------------

    void Awake()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep; // 강제 화면 On
        string path = Application.persistentDataPath + "/save.xml";
        if (System.IO.File.Exists(path))
        {
            Load();
        }
        Offer01.SetActive(true);
        sSclickIMG = SSclickIMG;
    }

    void Start()
    {
        if (RePlay == false)
        {
            money = 0;
            science = 0;
            years = 1700;
            robotLevel = 0;

            SSclickBonus = 1;
            SpaceshipGoldBonus = 1f;
            AdBonus = 1f;
            CashBonus = 1f;
            ClickBonus = 1f;
            SpaceshipScienceBonus = 1f;
            Fuel2Debuff = 1f;
            Engine2Debuff = 1f;
            Cockpit2Debuff = 1f;
            FinalGoldBonus = 1f;
            FinalScienceBonus = 1f;
            Fuel2Bonus = 1f;
            Engine2Bonus = 1f;
            Cockpit2Bonus = 1f;
            Engine2_RobotSpeed = 1;
}
        else
        {
            Image img1 = ScR.GetComponent<Image>();
            Image img2 = Offer01.GetComponent<Image>();
            Image img3 = Offer02.GetComponent<Image>();
            Image img4 = Offer03.GetComponent<Image>();

            img1.color = new Color32(255, 255, 255, 1);

            img2.color = new Color32(255, 255, 255, 220);
            if (TutorialManager.T04c == false)
            {
                img2.color = new Color32(255, 255, 255, 255);
            }
            img1.raycastTarget = true;
            img2.raycastTarget = true;
            img3.raycastTarget = true;
            img4.raycastTarget = true;

            if (robotLevel >= 150)
            {
                JokeButton.SetActive(true);
            }
        }

        click_gauge = 0;

        if (robotLevel == 0)
        {
            robotLevelUpPrice = StandardConst_Need;
        }

        passiveLoad();
        StartCoroutine(save());
        StartCoroutine(AutoMoney());
        StartCoroutine(AutoMoneyDigit());
        StartCoroutine(AutoScience());
        StartCoroutine(RobotGoldUpMec());
        StartCoroutine(ScienceUpMec());
        StartCoroutine(MoneyTransform());
        StartCoroutine(ScienceTransform());
        StartCoroutine(ShowInfo());
        StartCoroutine(UpdateRobotPanelText());
        StartCoroutine(RobotLevelUpButtonActiveCheck());
        StartCoroutine(FinalBonus());
        StartCoroutine(GoldScienceInfo());
        StartCoroutine(ClickGaugeControll());
        StartCoroutine(SSclick());

        RePlay = true;
    }

    void Update()
    {
        if(money >= 9000000000000000000 || money <= -8000000000000000000)
        {
            money = 9000000000000000000;
        }
        if(science >= 9000000000000000000 || science <= -8000000000000000000)
        {
            science = 9000000000000000000;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            panel_Quit.SetActive(true);
        }
    }

    public void Quit()
    {
        Save();
        Application.Quit();
    }

    private void OnApplicationQuit()
    {
        Save();
    }

    IEnumerator save()
    {
        while (true)
        {
            Save();
            yield return new WaitForSeconds(1.0f);
        }
    }

    void Save()
    {
        SaveData saveData = new SaveData();

        saveData.money = money;
        saveData.moneyIncreaseAmount = moneyIncreaseAmount;
        saveData.science = science;
        saveData.scienceIncreaseAmount = scienceIncreaseAmount;
        saveData.years = years;
        saveData.RePlay = RePlay;
        saveData.robotLevel = robotLevel;
        saveData.robotLevelUpPrice = robotLevelUpPrice;

        saveData.SpaceshipGoldBonus = SpaceshipGoldBonus;
        saveData.AdBonus = AdBonus;
        saveData.CashBonus = CashBonus;
        saveData.ClickBonus = ClickBonus;
        saveData.SpaceshipScienceBonus = SpaceshipScienceBonus;
        saveData.eventOn = eventOn;
        saveData.ClickCount_Fuel2 = ClickCount_Fuel2;
        saveData.ClickCount_Cockpit2 = ClickCount_Cockpit2;
        saveData.Story_Fuel2_Complete = Story_Fuel2_Complete;
        saveData.Story_Engine2_Complete = Story_Engine2_Complete;
        saveData.Story_Cockpit2_Complete = Story_Cockpit2_Complete;
        saveData.Engine2_RobotSpeed = Engine2_RobotSpeed;
        saveData.Fuel2Debuff = Fuel2Debuff;
        saveData.Engine2Debuff = Engine2Debuff;
        saveData.Cockpit2Debuff = Cockpit2Debuff;
        saveData.FinalGoldBonus = FinalGoldBonus;
        saveData.FinalScienceBonus = FinalScienceBonus;
        saveData.Fuel2Bonus = Fuel2Bonus;
        saveData.Engine2Bonus = Engine2Bonus;
        saveData.Cockpit2Bonus = Cockpit2Bonus;

        saveData.SSclickBonus = SSclickBonus;
        saveData.SStimer = SStimer;


        /* TechManager 관련 Save */
        saveData.Tech1Complete = TechManager.Tech1Complete;
        saveData.Tech2Complete = TechManager.Tech2Complete;
        saveData.Tech3Complete = TechManager.Tech3Complete;
        saveData.Tech4Complete = TechManager.Tech4Complete;
        saveData.Tech5Complete = TechManager.Tech5Complete;
        saveData.Tech6Complete = TechManager.Tech6Complete;
        saveData.Tech7Complete = TechManager.Tech7Complete;
        saveData.Tech8Complete = TechManager.Tech8Complete;
        saveData.Tech9Complete = TechManager.Tech9Complete;
        saveData.Tech10Complete = TechManager.Tech10Complete;
        saveData.Tech11Complete = TechManager.Tech11Complete;
        saveData.Tech12Complete = TechManager.Tech12Complete;
        saveData.Tech13Complete = TechManager.Tech13Complete;
        saveData.Tech14Complete = TechManager.Tech14Complete;
        saveData.Tech15Complete = TechManager.Tech15Complete;
        saveData.Tech16Complete = TechManager.Tech16Complete;
        saveData.Tech17Complete = TechManager.Tech17Complete;
        saveData.Tech18Complete = TechManager.Tech18Complete;
        saveData.Tech19Complete = TechManager.Tech19Complete;
        saveData.Tech20Complete = TechManager.Tech20Complete;
        saveData.Tech21Complete = TechManager.Tech21Complete;
        saveData.Tech22Complete = TechManager.Tech22Complete;
        saveData.Tech23Complete = TechManager.Tech23Complete;
        saveData.Tech24Complete = TechManager.Tech24Complete;
        saveData.Tech25Complete = TechManager.Tech25Complete;
        saveData.Tech26Complete = TechManager.Tech26Complete;
        saveData.Tech27Complete = TechManager.Tech27Complete;
        saveData.Tech28Complete = TechManager.Tech28Complete;
        saveData.Tech29Complete = TechManager.Tech29Complete;
        saveData.Tech30Complete = TechManager.Tech30Complete;
        saveData.Tech31Complete = TechManager.Tech31Complete;
        saveData.Tech32Complete = TechManager.Tech32Complete;
        saveData.Tech33Complete = TechManager.Tech33Complete;
        saveData.Tech34Complete = TechManager.Tech34Complete;
        saveData.Tech35Complete = TechManager.Tech35Complete;
        saveData.Tech36Complete = TechManager.Tech36Complete;
        saveData.Tech37Complete = TechManager.Tech37Complete;
        saveData.Tech38Complete = TechManager.Tech38Complete;
        saveData.Tech39Complete = TechManager.Tech39Complete;
        saveData.Tech40Complete = TechManager.Tech40Complete;
        saveData.Tech41Complete = TechManager.Tech41Complete;
        saveData.Tech42Complete = TechManager.Tech42Complete;
        saveData.Tech43Complete = TechManager.Tech43Complete;
        saveData.Tech44Complete = TechManager.Tech44Complete;
        saveData.Tech45Complete = TechManager.Tech45Complete;
        saveData.Tech46Complete = TechManager.Tech46Complete;
        saveData.Tech47Complete = TechManager.Tech47Complete;
        saveData.Tech48Complete = TechManager.Tech48Complete;
        saveData.Tech49Complete = TechManager.Tech49Complete;
        saveData.Tech50Complete = TechManager.Tech50Complete;
        saveData.Tech51Complete = TechManager.Tech51Complete;
        saveData.Tech52Complete = TechManager.Tech52Complete;
        saveData.Tech53Complete = TechManager.Tech53Complete;
        saveData.Tech54Complete = TechManager.Tech54Complete;
        saveData.Tech55Complete = TechManager.Tech55Complete;
        saveData.Tech56Complete = TechManager.Tech56Complete;
        saveData.Tech57Complete = TechManager.Tech57Complete;
        saveData.Tech58Complete = TechManager.Tech58Complete;
        saveData.Tech59Complete = TechManager.Tech59Complete;
        saveData.Tech60Complete = TechManager.Tech60Complete;
        saveData.Tech61Complete = TechManager.Tech61Complete;
        saveData.Tech62Complete = TechManager.Tech62Complete;
        saveData.Tech63Complete = TechManager.Tech63Complete;
        saveData.Tech64Complete = TechManager.Tech64Complete;
        saveData.Tech65Complete = TechManager.Tech65Complete;
        saveData.Tech66Complete = TechManager.Tech66Complete;
        saveData.Tech67Complete = TechManager.Tech67Complete;
        saveData.Tech68Complete = TechManager.Tech68Complete;
        saveData.Tech69Complete = TechManager.Tech69Complete;
        saveData.Tech70Complete = TechManager.Tech70Complete;

        saveData.Tech1AnimC = TechManager.Tech1AnimC;
        saveData.Tech2AnimC = TechManager.Tech2AnimC;
        saveData.Tech3AnimC = TechManager.Tech3AnimC;
        saveData.Tech4AnimC = TechManager.Tech4AnimC;
        saveData.Tech5AnimC = TechManager.Tech5AnimC;
        saveData.Tech6AnimC = TechManager.Tech6AnimC;
        saveData.Tech7AnimC = TechManager.Tech7AnimC;
        saveData.Tech8AnimC = TechManager.Tech8AnimC;
        saveData.Tech9AnimC = TechManager.Tech9AnimC;
        saveData.Tech10AnimC = TechManager.Tech10AnimC;
        saveData.Tech11AnimC = TechManager.Tech11AnimC;
        saveData.Tech12AnimC = TechManager.Tech12AnimC;
        saveData.Tech13AnimC = TechManager.Tech13AnimC;
        saveData.Tech14AnimC = TechManager.Tech14AnimC;
        saveData.Tech15AnimC = TechManager.Tech15AnimC;
        saveData.Tech16AnimC = TechManager.Tech16AnimC;
        saveData.Tech17AnimC = TechManager.Tech17AnimC;
        saveData.Tech18AnimC = TechManager.Tech18AnimC;
        saveData.Tech19AnimC = TechManager.Tech19AnimC;
        saveData.Tech20AnimC = TechManager.Tech20AnimC;
        saveData.Tech21AnimC = TechManager.Tech21AnimC;
        saveData.Tech22AnimC = TechManager.Tech22AnimC;
        saveData.Tech23AnimC = TechManager.Tech23AnimC;
        saveData.Tech24AnimC = TechManager.Tech24AnimC;
        saveData.Tech25AnimC = TechManager.Tech25AnimC;
        saveData.Tech26AnimC = TechManager.Tech26AnimC;
        saveData.Tech27AnimC = TechManager.Tech27AnimC;
        saveData.Tech28AnimC = TechManager.Tech28AnimC;
        saveData.Tech29AnimC = TechManager.Tech29AnimC;
        saveData.Tech30AnimC = TechManager.Tech30AnimC;
        saveData.Tech31AnimC = TechManager.Tech31AnimC;
        saveData.Tech32AnimC = TechManager.Tech32AnimC;
        saveData.Tech33AnimC = TechManager.Tech33AnimC;
        saveData.Tech34AnimC = TechManager.Tech34AnimC;
        saveData.Tech35AnimC = TechManager.Tech35AnimC;
        saveData.Tech36AnimC = TechManager.Tech36AnimC;
        saveData.Tech37AnimC = TechManager.Tech37AnimC;
        saveData.Tech38AnimC = TechManager.Tech38AnimC;
        saveData.Tech39AnimC = TechManager.Tech39AnimC;
        saveData.Tech40AnimC = TechManager.Tech40AnimC;
        saveData.Tech41AnimC = TechManager.Tech41AnimC;
        saveData.Tech42AnimC = TechManager.Tech42AnimC;
        saveData.Tech43AnimC = TechManager.Tech43AnimC;
        saveData.Tech44AnimC = TechManager.Tech44AnimC;
        saveData.Tech45AnimC = TechManager.Tech45AnimC;
        saveData.Tech46AnimC = TechManager.Tech46AnimC;
        saveData.Tech47AnimC = TechManager.Tech47AnimC;
        saveData.Tech48AnimC = TechManager.Tech48AnimC;
        saveData.Tech49AnimC = TechManager.Tech49AnimC;
        saveData.Tech50AnimC = TechManager.Tech50AnimC;
        saveData.Tech51AnimC = TechManager.Tech51AnimC;
        saveData.Tech52AnimC = TechManager.Tech52AnimC;
        saveData.Tech53AnimC = TechManager.Tech53AnimC;
        saveData.Tech54AnimC = TechManager.Tech54AnimC;
        saveData.Tech55AnimC = TechManager.Tech55AnimC;
        saveData.Tech56AnimC = TechManager.Tech56AnimC;
        saveData.Tech57AnimC = TechManager.Tech57AnimC;
        saveData.Tech58AnimC = TechManager.Tech58AnimC;
        saveData.Tech59AnimC = TechManager.Tech59AnimC;
        saveData.Tech60AnimC = TechManager.Tech60AnimC;
        saveData.Tech61AnimC = TechManager.Tech61AnimC;
        saveData.Tech62AnimC = TechManager.Tech62AnimC;
        saveData.Tech63AnimC = TechManager.Tech63AnimC;
        saveData.Tech64AnimC = TechManager.Tech64AnimC;
        saveData.Tech65AnimC = TechManager.Tech65AnimC;
        saveData.Tech66AnimC = TechManager.Tech66AnimC;
        saveData.Tech67AnimC = TechManager.Tech67AnimC;
        saveData.Tech68AnimC = TechManager.Tech68AnimC;
        saveData.Tech69AnimC = TechManager.Tech69AnimC;
        saveData.Tech70AnimC = TechManager.Tech70AnimC;

        saveData.age_war = TechManager.age_war;
        saveData.age_elec = TechManager.age_elec;
        saveData.age_modern = TechManager.age_modern;
        // ------------------------------------------


        /* ProductManager 관련 Save */
        saveData.autoMoney = ProductManager.autoMoney;
        saveData.autoScience = ProductManager.autoScience;

        saveData.Pd1 = ProductManager.Pd1;
        saveData.Pd3 = ProductManager.Pd3;
        saveData.Pd4 = ProductManager.Pd4;
        saveData.Pd5 = ProductManager.Pd5;
        saveData.Pd6 = ProductManager.Pd6;
        saveData.Pd7 = ProductManager.Pd7;
        saveData.Pd8 = ProductManager.Pd8;
        saveData.Pd9 = ProductManager.Pd9;
        saveData.Pd10 = ProductManager.Pd10;
        saveData.Pd11 = ProductManager.Pd11;
        saveData.Pd12 = ProductManager.Pd12;
        saveData.Pd13 = ProductManager.Pd13;
        saveData.Pd14 = ProductManager.Pd14;
        saveData.Pd15 = ProductManager.Pd15;
        saveData.Pd17 = ProductManager.Pd17;
        saveData.Pd18 = ProductManager.Pd18;
        saveData.Pd19 = ProductManager.Pd19;
        saveData.Pd20 = ProductManager.Pd20;
        saveData.Pd21 = ProductManager.Pd21;
        saveData.Pd22 = ProductManager.Pd22;
        saveData.Pd23 = ProductManager.Pd23;
        saveData.Pd24 = ProductManager.Pd24;
        saveData.Pd25 = ProductManager.Pd25;
        saveData.Pd26 = ProductManager.Pd26;
        saveData.Pd27 = ProductManager.Pd27;
        saveData.Pd28 = ProductManager.Pd28;
        saveData.Pd29 = ProductManager.Pd29;
        saveData.Pd30 = ProductManager.Pd30;
        saveData.Pd31 = ProductManager.Pd31;
        saveData.Pd32 = ProductManager.Pd32;
        saveData.Pd33 = ProductManager.Pd33;
        saveData.Pd34 = ProductManager.Pd34;
        saveData.Pd35 = ProductManager.Pd35;
        saveData.Pd36 = ProductManager.Pd36;
        saveData.Pd37 = ProductManager.Pd37;
        saveData.Pd38 = ProductManager.Pd38;
        saveData.Pd39 = ProductManager.Pd39;
        saveData.Pd40 = ProductManager.Pd40;
        saveData.Pd41 = ProductManager.Pd41;
        saveData.Pd42 = ProductManager.Pd42;
        saveData.Pd43 = ProductManager.Pd43;
        saveData.Pd44 = ProductManager.Pd44;
        saveData.Pd45 = ProductManager.Pd45;
        saveData.Pd46 = ProductManager.Pd46;
        saveData.Pd47 = ProductManager.Pd47;
        saveData.Pd48 = ProductManager.Pd48;
        saveData.Pd49 = ProductManager.Pd49;
        saveData.Pd51 = ProductManager.Pd51;
        saveData.Pd52 = ProductManager.Pd52;
        saveData.Pd53 = ProductManager.Pd53;
        saveData.Pd54 = ProductManager.Pd54;
        saveData.Pd55 = ProductManager.Pd55;
        saveData.Pd56 = ProductManager.Pd56;
        saveData.Pd58 = ProductManager.Pd58;
        saveData.Pd59 = ProductManager.Pd59;
        saveData.Pd60 = ProductManager.Pd60;
        saveData.Pd61 = ProductManager.Pd61;
        saveData.Pd62 = ProductManager.Pd62;
        saveData.Pd63 = ProductManager.Pd63;
        saveData.Pd64 = ProductManager.Pd64;
        saveData.Pd65 = ProductManager.Pd65;
        saveData.Pd66 = ProductManager.Pd66;
        saveData.Pd67 = ProductManager.Pd67;
        saveData.Pd68 = ProductManager.Pd68;
        saveData.Pd69 = ProductManager.Pd69;
        saveData.Pd70 = ProductManager.Pd70;
        saveData.PdS01 = ProductManager.PdS01;
        saveData.PdS02 = ProductManager.PdS02;
        saveData.PdS03 = ProductManager.PdS03;
        saveData.PdS04 = ProductManager.PdS04;

        saveData.Prod_1_Level = ProductManager.Prod_1_Level;
        saveData.Prod_3_Level = ProductManager.Prod_3_Level;
        saveData.Prod_4_Level = ProductManager.Prod_4_Level;
        saveData.Prod_5_Level = ProductManager.Prod_5_Level;
        saveData.Prod_6_Level = ProductManager.Prod_6_Level;
        saveData.Prod_7_Level = ProductManager.Prod_7_Level;
        saveData.Prod_8_Level = ProductManager.Prod_8_Level;
        saveData.Prod_9_Level = ProductManager.Prod_9_Level;
        saveData.Prod_10_Level = ProductManager.Prod_10_Level;
        saveData.Prod_11_Level = ProductManager.Prod_11_Level;
        saveData.Prod_12_Level = ProductManager.Prod_12_Level;
        saveData.Prod_13_Level = ProductManager.Prod_13_Level;
        saveData.Prod_14_Level = ProductManager.Prod_14_Level;
        saveData.Prod_15_Level = ProductManager.Prod_15_Level;
        saveData.Prod_17_Level = ProductManager.Prod_17_Level;
        saveData.Prod_18_Level = ProductManager.Prod_18_Level;
        saveData.Prod_19_Level = ProductManager.Prod_19_Level;
        saveData.Prod_20_Level = ProductManager.Prod_20_Level;
        saveData.Prod_21_Level = ProductManager.Prod_21_Level;
        saveData.Prod_22_Level = ProductManager.Prod_22_Level;
        saveData.Prod_23_Level = ProductManager.Prod_23_Level;
        saveData.Prod_24_Level = ProductManager.Prod_24_Level;
        saveData.Prod_25_Level = ProductManager.Prod_25_Level;
        saveData.Prod_26_Level = ProductManager.Prod_26_Level;
        saveData.Prod_27_Level = ProductManager.Prod_27_Level;
        saveData.Prod_28_Level = ProductManager.Prod_28_Level;
        saveData.Prod_29_Level = ProductManager.Prod_29_Level;
        saveData.Prod_30_Level = ProductManager.Prod_30_Level;
        saveData.Prod_31_Level = ProductManager.Prod_31_Level;
        saveData.Prod_32_Level = ProductManager.Prod_32_Level;
        saveData.Prod_33_Level = ProductManager.Prod_33_Level;
        saveData.Prod_34_Level = ProductManager.Prod_34_Level;
        saveData.Prod_35_Level = ProductManager.Prod_35_Level;
        saveData.Prod_36_Level = ProductManager.Prod_36_Level;
        saveData.Prod_37_Level = ProductManager.Prod_37_Level;
        saveData.Prod_38_Level = ProductManager.Prod_38_Level;
        saveData.Prod_39_Level = ProductManager.Prod_39_Level;
        saveData.Prod_40_Level = ProductManager.Prod_40_Level;
        saveData.Prod_41_Level = ProductManager.Prod_41_Level;
        saveData.Prod_42_Level = ProductManager.Prod_42_Level;
        saveData.Prod_43_Level = ProductManager.Prod_43_Level;
        saveData.Prod_44_Level = ProductManager.Prod_44_Level;
        saveData.Prod_45_Level = ProductManager.Prod_45_Level;
        saveData.Prod_46_Level = ProductManager.Prod_46_Level;
        saveData.Prod_47_Level = ProductManager.Prod_47_Level;
        saveData.Prod_48_Level = ProductManager.Prod_48_Level;
        saveData.Prod_49_Level = ProductManager.Prod_49_Level;
        saveData.Prod_51_Level = ProductManager.Prod_51_Level;
        saveData.Prod_52_Level = ProductManager.Prod_52_Level;
        saveData.Prod_53_Level = ProductManager.Prod_53_Level;
        saveData.Prod_54_Level = ProductManager.Prod_54_Level;
        saveData.Prod_55_Level = ProductManager.Prod_55_Level;
        saveData.Prod_56_Level = ProductManager.Prod_56_Level;
        saveData.Prod_58_Level = ProductManager.Prod_58_Level;
        saveData.Prod_59_Level = ProductManager.Prod_59_Level;
        saveData.Prod_60_Level = ProductManager.Prod_60_Level;
        saveData.Prod_61_Level = ProductManager.Prod_61_Level;
        saveData.Prod_62_Level = ProductManager.Prod_62_Level;
        saveData.Prod_63_Level = ProductManager.Prod_63_Level;
        saveData.Prod_64_Level = ProductManager.Prod_64_Level;
        saveData.Prod_65_Level = ProductManager.Prod_65_Level;
        saveData.Prod_66_Level = ProductManager.Prod_66_Level;
        saveData.Prod_67_Level = ProductManager.Prod_67_Level;
        saveData.Prod_68_Level = ProductManager.Prod_68_Level;
        saveData.Prod_69_Level = ProductManager.Prod_69_Level;
        saveData.Prod_70_Level = ProductManager.Prod_70_Level;
        saveData.Prod_S01_Level = ProductManager.Prod_S01_Level;
        saveData.Prod_S02_Level = ProductManager.Prod_S02_Level;
        saveData.Prod_S03_Level = ProductManager.Prod_S03_Level;
        saveData.Prod_S04_Level = ProductManager.Prod_S04_Level;

        saveData.PdS01Complete = ProductManager.PdS01Complete;
        saveData.PdS02Complete = ProductManager.PdS02Complete;
        saveData.PdS03Complete = ProductManager.PdS03Complete;
        saveData.PdS04Complete = ProductManager.PdS04Complete;
        saveData.JumpINDpossible = ProductManager.JumpINDpossible;
        saveData.JumpWARpossible = ProductManager.JumpWARpossible;
        saveData.JumpELECpossible = ProductManager.JumpELECpossible;
        saveData.JumpMODERNpossible = ProductManager.JumpMODERNpossible;
        // -------------------------------------------------------------


        /* SpaceshipManager 관련 Save */
        for (int i = 0; i < 21 ; i++)
        {
            saveData.SScomplete[i] = SpaceshipManager.SScomplete[i];
        }
        saveData.SSupNum = SpaceshipManager.SSupNum;
        saveData.SSgauge = SpaceshipManager.SSgauge;
        // ---------------------------------------------------------


        /* TutorialManager 및 MessageManager 관련 Save */
        saveData.T01 = TutorialManager.T01; // 대화창 변수
        saveData.T01c = TutorialManager.T01c; // 대화창 클리어 변수
        saveData.T02 = TutorialManager.T02;
        saveData.T02c = TutorialManager.T02c;
        saveData.T03 = TutorialManager.T03;
        saveData.T03c = TutorialManager.T03c;
        saveData.T04 = TutorialManager.T04;
        saveData.T04c = TutorialManager.T04c;
        saveData.P01 = TutorialManager.P01; // 푸시 변수
        saveData.P01c = TutorialManager.P01c; // 푸시 클리어 변수
        saveData.T05 = TutorialManager.T05;
        saveData.T05c = TutorialManager.T05c;
        saveData.P02 = TutorialManager.P02;
        saveData.P02c = TutorialManager.P02c;
        saveData.P03 = TutorialManager.P03;
        saveData.P03c = TutorialManager.P03c;
        saveData.T06 = TutorialManager.T06;
        saveData.T06c = TutorialManager.T06c;
        saveData.T07 = TutorialManager.T07;
        saveData.T07c = TutorialManager.T07c;
        saveData.P04 = TutorialManager.P04;
        saveData.P04c = TutorialManager.P04c;
        saveData.T08 = TutorialManager.T08;
        saveData.T08c = TutorialManager.T08c;
        saveData.T09 = TutorialManager.T09;
        saveData.T09c = TutorialManager.T09c;
        saveData.TutoAllClear = TutorialManager.TutoAllClear; // 튜토리얼 최종 완료 변수

        saveData.message01c = MessageManager.message01c;

        for (int i = 0; i < 71; i++)
        {
            saveData.techMessage[i] = MessageManager.techMessage[i];
        }
        for (int i = 0; i < 21; i++)
        {
            saveData.etcMessage[i] = MessageManager.etcMessage[i];
        }
        saveData.ageMessage_WAR = MessageManager.ageMessage_WAR;
        saveData.ageMessage_ELEC = MessageManager.ageMessage_ELEC;
        saveData.ageMessage_MODERN = MessageManager.ageMessage_MODERN;
        saveData.startTime = MessageManager.startTime.ToString();
        // -----------------------------------------------------------


        /* SoundManager 관련 Save */
        saveData.BGM_Meter = SoundManager.BGM_Meter;
        saveData.SFX_Meter = SoundManager.SFX_Meter;
        // -----------------------------------------


        /*
        saveData.1 = ProductManager.1;
        saveData.2 = ProductManager.2;
        saveData.3 = ProductManager.3;
        saveData.4 = ProductManager.4;
        saveData.5 = ProductManager.5;
        saveData.6 = ProductManager.6;
        saveData.7 = ProductManager.7;
        saveData.8 = ProductManager.8;
        saveData.9 = ProductManager.9;
        saveData.10 = ProductManager.10;
        saveData.11 = ProductManager.11;
        saveData.12 = ProductManager.12;
        saveData.13 = ProductManager.13;
        saveData.14 = ProductManager.14;
        saveData.15 = ProductManager.15;
        saveData.16 = ProductManager.16;
        saveData.17 = ProductManager.17;
        saveData.18 = ProductManager.18;
        saveData.19 = ProductManager.19;
        saveData.20 = ProductManager.20;
        saveData.21 = ProductManager.21;
        saveData.22 = ProductManager.22;
        saveData.23 = ProductManager.23;
        saveData.24 = ProductManager.24;
        saveData.25 = ProductManager.25;
        saveData.26 = ProductManager.26;
        saveData.27 = ProductManager.27;
        saveData.28 = ProductManager.28;
        saveData.29 = ProductManager.29;
        saveData.30 = ProductManager.30;
        saveData.31 = ProductManager.31;
        saveData.32 = ProductManager.32;
        saveData.33 = ProductManager.33;
        saveData.34 = ProductManager.34;
        saveData.35 = ProductManager.35;
        saveData.36 = ProductManager.36;
        saveData.37 = ProductManager.37;
        saveData.38 = ProductManager.38;
        saveData.39 = ProductManager.39;
        saveData.40 = ProductManager.40;
        saveData.41 = ProductManager.41;
        saveData.42 = ProductManager.42;
        saveData.43 = ProductManager.43;
        saveData.44 = ProductManager.44;
        saveData.45 = ProductManager.45;
        saveData.46 = ProductManager.46;
        saveData.47 = ProductManager.47;
        saveData.48 = ProductManager.48;
        saveData.49 = ProductManager.49;
        saveData.50 = ProductManager.50;
        saveData.51 = ProductManager.51;
        saveData.52 = ProductManager.52;
        saveData.53 = ProductManager.53;
        saveData.54 = ProductManager.54;
        saveData.55 = ProductManager.55;
        saveData.56 = ProductManager.56;
        saveData.57 = ProductManager.57;
        saveData.58 = ProductManager.58;
        saveData.59 = ProductManager.59;
        saveData.60 = ProductManager.60;
        saveData.61 = ProductManager.61;
        saveData.62 = ProductManager.62;
        saveData.63 = ProductManager.63;
        saveData.64 = ProductManager.64;
        saveData.65 = ProductManager.65;
        saveData.66 = ProductManager.66;
        saveData.67 = ProductManager.67;
        saveData.68 = ProductManager.68;
        saveData.69 = ProductManager.69;
        saveData.70 = ProductManager.70;
        */

        string path = Application.persistentDataPath + "/save.xml";
        // XmlManager.XmlSave<SaveData>(saveData, path);
        SaveManager.Save<SaveData>(saveData, path);
    }

    void Load()
    {
        SaveData saveData = new SaveData();

        string path = Application.persistentDataPath + "/save.xml";
        // saveData = XmlManager.XmlLoad<SaveData>(path);
        SaveManager.Load<SaveData>(ref saveData, path);

        money = saveData.money;
        moneyIncreaseAmount = saveData.moneyIncreaseAmount;
        science = saveData.science;
        scienceIncreaseAmount = saveData.scienceIncreaseAmount;
        years = saveData.years;
        RePlay = saveData.RePlay;
        robotLevel = saveData.robotLevel;
        robotLevelUpPrice = saveData.robotLevelUpPrice;

        SpaceshipGoldBonus = saveData.SpaceshipGoldBonus;
        AdBonus = saveData.AdBonus;
        CashBonus = saveData.CashBonus;
        ClickBonus = saveData.ClickBonus;
        SpaceshipScienceBonus = saveData.SpaceshipScienceBonus;
        eventOn = saveData.eventOn;
        ClickCount_Fuel2 = saveData.ClickCount_Fuel2;
        ClickCount_Cockpit2 = saveData.ClickCount_Cockpit2;
        Story_Fuel2_Complete = saveData.Story_Fuel2_Complete;
        Story_Engine2_Complete = saveData.Story_Engine2_Complete;
        Story_Cockpit2_Complete = saveData.Story_Cockpit2_Complete;
        Engine2_RobotSpeed = saveData.Engine2_RobotSpeed;
        Fuel2Debuff = saveData.Fuel2Debuff;
        Engine2Debuff = saveData.Engine2Debuff;
        Cockpit2Debuff = saveData.Cockpit2Debuff;
        FinalGoldBonus = saveData.FinalGoldBonus;
        FinalScienceBonus = saveData.FinalScienceBonus;
        Fuel2Bonus = saveData.Fuel2Bonus;
        Engine2Bonus = saveData.Engine2Bonus;
        Cockpit2Bonus = saveData.Cockpit2Bonus;

        SSclickBonus = saveData.SSclickBonus;
        SStimer = saveData.SStimer;


        /* TechManager 관련 Load */
        TechManager.Tech1Complete = saveData.Tech1Complete;
        TechManager.Tech2Complete = saveData.Tech2Complete;
        TechManager.Tech3Complete = saveData.Tech3Complete;
        TechManager.Tech4Complete = saveData.Tech4Complete;
        TechManager.Tech5Complete = saveData.Tech5Complete;
        TechManager.Tech6Complete = saveData.Tech6Complete;
        TechManager.Tech7Complete = saveData.Tech7Complete;
        TechManager.Tech8Complete = saveData.Tech8Complete;
        TechManager.Tech9Complete = saveData.Tech9Complete;
        TechManager.Tech10Complete = saveData.Tech10Complete;
        TechManager.Tech11Complete = saveData.Tech11Complete;
        TechManager.Tech12Complete = saveData.Tech12Complete;
        TechManager.Tech13Complete = saveData.Tech13Complete;
        TechManager.Tech14Complete = saveData.Tech14Complete;
        TechManager.Tech15Complete = saveData.Tech15Complete;
        TechManager.Tech16Complete = saveData.Tech16Complete;
        TechManager.Tech17Complete = saveData.Tech17Complete;
        TechManager.Tech18Complete = saveData.Tech18Complete;
        TechManager.Tech19Complete = saveData.Tech19Complete;
        TechManager.Tech20Complete = saveData.Tech20Complete;
        TechManager.Tech21Complete = saveData.Tech21Complete;
        TechManager.Tech22Complete = saveData.Tech22Complete;
        TechManager.Tech23Complete = saveData.Tech23Complete;
        TechManager.Tech24Complete = saveData.Tech24Complete;
        TechManager.Tech25Complete = saveData.Tech25Complete;
        TechManager.Tech26Complete = saveData.Tech26Complete;
        TechManager.Tech27Complete = saveData.Tech27Complete;
        TechManager.Tech28Complete = saveData.Tech28Complete;
        TechManager.Tech29Complete = saveData.Tech29Complete;
        TechManager.Tech30Complete = saveData.Tech30Complete;
        TechManager.Tech31Complete = saveData.Tech31Complete;
        TechManager.Tech32Complete = saveData.Tech32Complete;
        TechManager.Tech33Complete = saveData.Tech33Complete;
        TechManager.Tech34Complete = saveData.Tech34Complete;
        TechManager.Tech35Complete = saveData.Tech35Complete;
        TechManager.Tech36Complete = saveData.Tech36Complete;
        TechManager.Tech37Complete = saveData.Tech37Complete;
        TechManager.Tech38Complete = saveData.Tech38Complete;
        TechManager.Tech39Complete = saveData.Tech39Complete;
        TechManager.Tech40Complete = saveData.Tech40Complete;
        TechManager.Tech41Complete = saveData.Tech41Complete;
        TechManager.Tech42Complete = saveData.Tech42Complete;
        TechManager.Tech43Complete = saveData.Tech43Complete;
        TechManager.Tech44Complete = saveData.Tech44Complete;
        TechManager.Tech45Complete = saveData.Tech45Complete;
        TechManager.Tech46Complete = saveData.Tech46Complete;
        TechManager.Tech47Complete = saveData.Tech47Complete;
        TechManager.Tech48Complete = saveData.Tech48Complete;
        TechManager.Tech49Complete = saveData.Tech49Complete;
        TechManager.Tech50Complete = saveData.Tech50Complete;
        TechManager.Tech51Complete = saveData.Tech51Complete;
        TechManager.Tech52Complete = saveData.Tech52Complete;
        TechManager.Tech53Complete = saveData.Tech53Complete;
        TechManager.Tech54Complete = saveData.Tech54Complete;
        TechManager.Tech55Complete = saveData.Tech55Complete;
        TechManager.Tech56Complete = saveData.Tech56Complete;
        TechManager.Tech57Complete = saveData.Tech57Complete;
        TechManager.Tech58Complete = saveData.Tech58Complete;
        TechManager.Tech59Complete = saveData.Tech59Complete;
        TechManager.Tech60Complete = saveData.Tech60Complete;
        TechManager.Tech61Complete = saveData.Tech61Complete;
        TechManager.Tech62Complete = saveData.Tech62Complete;
        TechManager.Tech63Complete = saveData.Tech63Complete;
        TechManager.Tech64Complete = saveData.Tech64Complete;
        TechManager.Tech65Complete = saveData.Tech65Complete;
        TechManager.Tech66Complete = saveData.Tech66Complete;
        TechManager.Tech67Complete = saveData.Tech67Complete;
        TechManager.Tech68Complete = saveData.Tech68Complete;
        TechManager.Tech69Complete = saveData.Tech69Complete;
        TechManager.Tech70Complete = saveData.Tech70Complete;

        TechManager.Tech1AnimC = saveData.Tech1AnimC;
        TechManager.Tech2AnimC = saveData.Tech2AnimC;
        TechManager.Tech3AnimC = saveData.Tech3AnimC;
        TechManager.Tech4AnimC = saveData.Tech4AnimC;
        TechManager.Tech5AnimC = saveData.Tech5AnimC;
        TechManager.Tech6AnimC = saveData.Tech6AnimC;
        TechManager.Tech7AnimC = saveData.Tech7AnimC;
        TechManager.Tech8AnimC = saveData.Tech8AnimC;
        TechManager.Tech9AnimC = saveData.Tech9AnimC;
        TechManager.Tech10AnimC = saveData.Tech10AnimC;
        TechManager.Tech11AnimC = saveData.Tech11AnimC;
        TechManager.Tech12AnimC = saveData.Tech12AnimC;
        TechManager.Tech13AnimC = saveData.Tech13AnimC;
        TechManager.Tech14AnimC = saveData.Tech14AnimC;
        TechManager.Tech15AnimC = saveData.Tech15AnimC;
        TechManager.Tech16AnimC = saveData.Tech16AnimC;
        TechManager.Tech17AnimC = saveData.Tech17AnimC;
        TechManager.Tech18AnimC = saveData.Tech18AnimC;
        TechManager.Tech19AnimC = saveData.Tech19AnimC;
        TechManager.Tech20AnimC = saveData.Tech20AnimC;
        TechManager.Tech21AnimC = saveData.Tech21AnimC;
        TechManager.Tech22AnimC = saveData.Tech22AnimC;
        TechManager.Tech23AnimC = saveData.Tech23AnimC;
        TechManager.Tech24AnimC = saveData.Tech24AnimC;
        TechManager.Tech25AnimC = saveData.Tech25AnimC;
        TechManager.Tech26AnimC = saveData.Tech26AnimC;
        TechManager.Tech27AnimC = saveData.Tech27AnimC;
        TechManager.Tech28AnimC = saveData.Tech28AnimC;
        TechManager.Tech29AnimC = saveData.Tech29AnimC;
        TechManager.Tech30AnimC = saveData.Tech30AnimC;
        TechManager.Tech31AnimC = saveData.Tech31AnimC;
        TechManager.Tech32AnimC = saveData.Tech32AnimC;
        TechManager.Tech33AnimC = saveData.Tech33AnimC;
        TechManager.Tech34AnimC = saveData.Tech34AnimC;
        TechManager.Tech35AnimC = saveData.Tech35AnimC;
        TechManager.Tech36AnimC = saveData.Tech36AnimC;
        TechManager.Tech37AnimC = saveData.Tech37AnimC;
        TechManager.Tech38AnimC = saveData.Tech38AnimC;
        TechManager.Tech39AnimC = saveData.Tech39AnimC;
        TechManager.Tech40AnimC = saveData.Tech40AnimC;
        TechManager.Tech41AnimC = saveData.Tech41AnimC;
        TechManager.Tech42AnimC = saveData.Tech42AnimC;
        TechManager.Tech43AnimC = saveData.Tech43AnimC;
        TechManager.Tech44AnimC = saveData.Tech44AnimC;
        TechManager.Tech45AnimC = saveData.Tech45AnimC;
        TechManager.Tech46AnimC = saveData.Tech46AnimC;
        TechManager.Tech47AnimC = saveData.Tech47AnimC;
        TechManager.Tech48AnimC = saveData.Tech48AnimC;
        TechManager.Tech49AnimC = saveData.Tech49AnimC;
        TechManager.Tech50AnimC = saveData.Tech50AnimC;
        TechManager.Tech51AnimC = saveData.Tech51AnimC;
        TechManager.Tech52AnimC = saveData.Tech52AnimC;
        TechManager.Tech53AnimC = saveData.Tech53AnimC;
        TechManager.Tech54AnimC = saveData.Tech54AnimC;
        TechManager.Tech55AnimC = saveData.Tech55AnimC;
        TechManager.Tech56AnimC = saveData.Tech56AnimC;
        TechManager.Tech57AnimC = saveData.Tech57AnimC;
        TechManager.Tech58AnimC = saveData.Tech58AnimC;
        TechManager.Tech59AnimC = saveData.Tech59AnimC;
        TechManager.Tech60AnimC = saveData.Tech60AnimC;
        TechManager.Tech61AnimC = saveData.Tech61AnimC;
        TechManager.Tech62AnimC = saveData.Tech62AnimC;
        TechManager.Tech63AnimC = saveData.Tech63AnimC;
        TechManager.Tech64AnimC = saveData.Tech64AnimC;
        TechManager.Tech65AnimC = saveData.Tech65AnimC;
        TechManager.Tech66AnimC = saveData.Tech66AnimC;
        TechManager.Tech67AnimC = saveData.Tech67AnimC;
        TechManager.Tech68AnimC = saveData.Tech68AnimC;
        TechManager.Tech69AnimC = saveData.Tech69AnimC;
        TechManager.Tech70AnimC = saveData.Tech70AnimC;

        TechManager.age_war = saveData.age_war;
        TechManager.age_elec = saveData.age_elec;
        TechManager.age_modern = saveData.age_modern;
        // ------------------------------------------


        /* ProductManager 관련 Load */
        ProductManager.autoMoney = saveData.autoMoney;
        ProductManager.autoScience = saveData.autoScience;

        ProductManager.Pd1 = saveData.Pd1;
        ProductManager.Pd3 = saveData.Pd3;
        ProductManager.Pd4 = saveData.Pd4;
        ProductManager.Pd5 = saveData.Pd5;
        ProductManager.Pd6 = saveData.Pd6;
        ProductManager.Pd7 = saveData.Pd7;
        ProductManager.Pd8 = saveData.Pd8;
        ProductManager.Pd9 = saveData.Pd9;
        ProductManager.Pd10 = saveData.Pd10;
        ProductManager.Pd11 = saveData.Pd11;
        ProductManager.Pd12 = saveData.Pd12;
        ProductManager.Pd13 = saveData.Pd13;
        ProductManager.Pd14 = saveData.Pd14;
        ProductManager.Pd15 = saveData.Pd15;
        ProductManager.Pd17 = saveData.Pd17;
        ProductManager.Pd18 = saveData.Pd18;
        ProductManager.Pd19 = saveData.Pd19;
        ProductManager.Pd20 = saveData.Pd20;
        ProductManager.Pd21 = saveData.Pd21;
        ProductManager.Pd22 = saveData.Pd22;
        ProductManager.Pd23 = saveData.Pd23;
        ProductManager.Pd24 = saveData.Pd24;
        ProductManager.Pd25 = saveData.Pd25;
        ProductManager.Pd26 = saveData.Pd26;
        ProductManager.Pd27 = saveData.Pd27;
        ProductManager.Pd28 = saveData.Pd28;
        ProductManager.Pd29 = saveData.Pd29;
        ProductManager.Pd30 = saveData.Pd30;
        ProductManager.Pd31 = saveData.Pd31;
        ProductManager.Pd32 = saveData.Pd32;
        ProductManager.Pd33 = saveData.Pd33;
        ProductManager.Pd34 = saveData.Pd34;
        ProductManager.Pd35 = saveData.Pd35;
        ProductManager.Pd36 = saveData.Pd36;
        ProductManager.Pd37 = saveData.Pd37;
        ProductManager.Pd38 = saveData.Pd38;
        ProductManager.Pd39 = saveData.Pd39;
        ProductManager.Pd40 = saveData.Pd40;
        ProductManager.Pd41 = saveData.Pd41;
        ProductManager.Pd42 = saveData.Pd42;
        ProductManager.Pd43 = saveData.Pd43;
        ProductManager.Pd44 = saveData.Pd44;
        ProductManager.Pd45 = saveData.Pd45;
        ProductManager.Pd46 = saveData.Pd46;
        ProductManager.Pd47 = saveData.Pd47;
        ProductManager.Pd48 = saveData.Pd48;
        ProductManager.Pd49 = saveData.Pd49;
        ProductManager.Pd51 = saveData.Pd51;
        ProductManager.Pd52 = saveData.Pd52;
        ProductManager.Pd53 = saveData.Pd53;
        ProductManager.Pd54 = saveData.Pd54;
        ProductManager.Pd55 = saveData.Pd55;
        ProductManager.Pd56 = saveData.Pd56;
        ProductManager.Pd58 = saveData.Pd58;
        ProductManager.Pd59 = saveData.Pd59;
        ProductManager.Pd60 = saveData.Pd60;
        ProductManager.Pd61 = saveData.Pd61;
        ProductManager.Pd62 = saveData.Pd62;
        ProductManager.Pd63 = saveData.Pd63;
        ProductManager.Pd64 = saveData.Pd64;
        ProductManager.Pd65 = saveData.Pd65;
        ProductManager.Pd66 = saveData.Pd66;
        ProductManager.Pd67 = saveData.Pd67;
        ProductManager.Pd68 = saveData.Pd68;
        ProductManager.Pd69 = saveData.Pd69;
        ProductManager.Pd70 = saveData.Pd70;
        ProductManager.PdS01 = saveData.PdS01;
        ProductManager.PdS02 = saveData.PdS02;
        ProductManager.PdS03 = saveData.PdS03;
        ProductManager.PdS04 = saveData.PdS04;

        ProductManager.Prod_1_Level = saveData.Prod_1_Level;
        ProductManager.Prod_3_Level = saveData.Prod_3_Level;
        ProductManager.Prod_4_Level = saveData.Prod_4_Level;
        ProductManager.Prod_5_Level = saveData.Prod_5_Level;
        ProductManager.Prod_6_Level = saveData.Prod_6_Level;
        ProductManager.Prod_7_Level = saveData.Prod_7_Level;
        ProductManager.Prod_8_Level = saveData.Prod_8_Level;
        ProductManager.Prod_9_Level = saveData.Prod_9_Level;
        ProductManager.Prod_10_Level = saveData.Prod_10_Level;
        ProductManager.Prod_11_Level = saveData.Prod_11_Level;
        ProductManager.Prod_12_Level = saveData.Prod_12_Level;
        ProductManager.Prod_13_Level = saveData.Prod_13_Level;
        ProductManager.Prod_14_Level = saveData.Prod_14_Level;
        ProductManager.Prod_15_Level = saveData.Prod_15_Level;
        ProductManager.Prod_17_Level = saveData.Prod_17_Level;
        ProductManager.Prod_18_Level = saveData.Prod_18_Level;
        ProductManager.Prod_19_Level = saveData.Prod_19_Level;
        ProductManager.Prod_20_Level = saveData.Prod_20_Level;
        ProductManager.Prod_21_Level = saveData.Prod_21_Level;
        ProductManager.Prod_22_Level = saveData.Prod_22_Level;
        ProductManager.Prod_23_Level = saveData.Prod_23_Level;
        ProductManager.Prod_24_Level = saveData.Prod_24_Level;
        ProductManager.Prod_25_Level = saveData.Prod_25_Level;
        ProductManager.Prod_26_Level = saveData.Prod_26_Level;
        ProductManager.Prod_27_Level = saveData.Prod_27_Level;
        ProductManager.Prod_28_Level = saveData.Prod_28_Level;
        ProductManager.Prod_29_Level = saveData.Prod_29_Level;
        ProductManager.Prod_30_Level = saveData.Prod_30_Level;
        ProductManager.Prod_31_Level = saveData.Prod_31_Level;
        ProductManager.Prod_32_Level = saveData.Prod_32_Level;
        ProductManager.Prod_33_Level = saveData.Prod_33_Level;
        ProductManager.Prod_34_Level = saveData.Prod_34_Level;
        ProductManager.Prod_35_Level = saveData.Prod_35_Level;
        ProductManager.Prod_36_Level = saveData.Prod_36_Level;
        ProductManager.Prod_37_Level = saveData.Prod_37_Level;
        ProductManager.Prod_38_Level = saveData.Prod_38_Level;
        ProductManager.Prod_39_Level = saveData.Prod_39_Level;
        ProductManager.Prod_40_Level = saveData.Prod_40_Level;
        ProductManager.Prod_41_Level = saveData.Prod_41_Level;
        ProductManager.Prod_42_Level = saveData.Prod_42_Level;
        ProductManager.Prod_43_Level = saveData.Prod_43_Level;
        ProductManager.Prod_44_Level = saveData.Prod_44_Level;
        ProductManager.Prod_45_Level = saveData.Prod_45_Level;
        ProductManager.Prod_46_Level = saveData.Prod_46_Level;
        ProductManager.Prod_47_Level = saveData.Prod_47_Level;
        ProductManager.Prod_48_Level = saveData.Prod_48_Level;
        ProductManager.Prod_49_Level = saveData.Prod_49_Level;
        ProductManager.Prod_51_Level = saveData.Prod_51_Level;
        ProductManager.Prod_52_Level = saveData.Prod_52_Level;
        ProductManager.Prod_53_Level = saveData.Prod_53_Level;
        ProductManager.Prod_54_Level = saveData.Prod_54_Level;
        ProductManager.Prod_55_Level = saveData.Prod_55_Level;
        ProductManager.Prod_56_Level = saveData.Prod_56_Level;
        ProductManager.Prod_58_Level = saveData.Prod_58_Level;
        ProductManager.Prod_59_Level = saveData.Prod_59_Level;
        ProductManager.Prod_60_Level = saveData.Prod_60_Level;
        ProductManager.Prod_61_Level = saveData.Prod_61_Level;
        ProductManager.Prod_62_Level = saveData.Prod_62_Level;
        ProductManager.Prod_63_Level = saveData.Prod_63_Level;
        ProductManager.Prod_64_Level = saveData.Prod_64_Level;
        ProductManager.Prod_65_Level = saveData.Prod_65_Level;
        ProductManager.Prod_66_Level = saveData.Prod_66_Level;
        ProductManager.Prod_67_Level = saveData.Prod_67_Level;
        ProductManager.Prod_68_Level = saveData.Prod_68_Level;
        ProductManager.Prod_69_Level = saveData.Prod_69_Level;
        ProductManager.Prod_70_Level = saveData.Prod_70_Level;
        ProductManager.Prod_S01_Level = saveData.Prod_S01_Level;
        ProductManager.Prod_S02_Level = saveData.Prod_S02_Level;
        ProductManager.Prod_S03_Level = saveData.Prod_S03_Level;
        ProductManager.Prod_S04_Level = saveData.Prod_S04_Level;

        ProductManager.PdS01Complete = saveData.PdS01Complete;
        ProductManager.PdS02Complete = saveData.PdS02Complete;
        ProductManager.PdS03Complete = saveData.PdS03Complete;
        ProductManager.PdS04Complete = saveData.PdS04Complete;
        ProductManager.JumpINDpossible = saveData.JumpINDpossible;
        ProductManager.JumpWARpossible = saveData.JumpWARpossible;
        ProductManager.JumpELECpossible = saveData.JumpELECpossible;
        ProductManager.JumpMODERNpossible = saveData.JumpMODERNpossible;
        // -------------------------------------------------------------


        /* SpaceshipManager 관련 Load */
        for (int i = 0; i < 21; i++)
        {
            SpaceshipManager.SScomplete[i] = saveData.SScomplete[i];
        }
        SpaceshipManager.SSupNum = saveData.SSupNum;
        SpaceshipManager.SSgauge = saveData.SSgauge;
        // ---------------------------------------------------------


        /* TutorialManager 및 MessageManager 관련 Load */
        TutorialManager.T01 = saveData.T01; // 대화창 변수
        TutorialManager.T01c = saveData.T01c; // 대화창 클리어 변수
        TutorialManager.T02 = saveData.T02;
        TutorialManager.T02c = saveData.T02c;
        TutorialManager.T03 = saveData.T03;
        TutorialManager.T03c = saveData.T03c;
        TutorialManager.T04 = saveData.T04;
        TutorialManager.T04c = saveData.T04c;
        TutorialManager.P01 = saveData.P01; // 푸시 변수
        TutorialManager.P01c = saveData.P01c; // 푸시 클리어 변수
        TutorialManager.T05 = saveData.T05;
        TutorialManager.T05c = saveData.T05c;
        TutorialManager.P02 = saveData.P02;
        TutorialManager.P02c = saveData.P02c;
        TutorialManager.P03 = saveData.P03;
        TutorialManager.P03c = saveData.P03c;
        TutorialManager.T06 = saveData.T06;
        TutorialManager.T06c = saveData.T06c;
        TutorialManager.T07 = saveData.T07;
        TutorialManager.T07c = saveData.T07c;
        TutorialManager.P04 = saveData.P04;
        TutorialManager.P04c = saveData.P04c;
        TutorialManager.T08 = saveData.T08;
        TutorialManager.T08c = saveData.T08c;
        TutorialManager.T09 = saveData.T09;
        TutorialManager.T09c = saveData.T09c;
        TutorialManager.TutoAllClear = saveData.TutoAllClear; // 튜토리얼 최종 완료 변수

        MessageManager.message01c = saveData.message01c;

        for (int i = 0; i < 71; i++)
        {
            MessageManager.techMessage[i] = saveData.techMessage[i];
        }
        for (int i = 0; i < 21; i++)
        {
            MessageManager.etcMessage[i] = saveData.etcMessage[i];
        }

        MessageManager.ageMessage_WAR = saveData.ageMessage_WAR;
        MessageManager.ageMessage_ELEC = saveData.ageMessage_ELEC;
        MessageManager.ageMessage_MODERN = saveData.ageMessage_MODERN;

        MessageManager.startTime = System.Convert.ToDateTime(saveData.startTime);
        // ---------------------------------------------------------


        /* SoundManager 관련 Load */
        SoundManager.BGM_Meter = saveData.BGM_Meter;
        SoundManager.SFX_Meter = saveData.SFX_Meter;
        // -------------------------------------------------------


        /*
        ProductManager.1 = saveData.1;
        ProductManager.2 = saveData.2;
        ProductManager.3 = saveData.3;
        ProductManager.4 = saveData.4;
        ProductManager.5 = saveData.5;
        ProductManager.6 = saveData.6;
        ProductManager.7 = saveData.7;
        ProductManager.8 = saveData.8;
        ProductManager.9 = saveData.9;
        ProductManager.10 = saveData.10;
        ProductManager.11 = saveData.11;
        ProductManager.12 = saveData.12;
        ProductManager.13 = saveData.13;
        ProductManager.14 = saveData.14;
        ProductManager.15 = saveData.15;
        ProductManager.16 = saveData.16;
        ProductManager.17 = saveData.17;
        ProductManager.18 = saveData.18;
        ProductManager.19 = saveData.19;
        ProductManager.20 = saveData.20;
        ProductManager.21 = saveData.21;
        ProductManager.22 = saveData.22;
        ProductManager.23 = saveData.23;
        ProductManager.24 = saveData.24;
        ProductManager.25 = saveData.25;
        ProductManager.26 = saveData.26;
        ProductManager.27 = saveData.27;
        ProductManager.28 = saveData.28;
        ProductManager.29 = saveData.29;
        ProductManager.30 = saveData.30;
        ProductManager.31 = saveData.31;
        ProductManager.32 = saveData.32;
        ProductManager.33 = saveData.33;
        ProductManager.34 = saveData.34;
        ProductManager.35 = saveData.35;
        ProductManager.36 = saveData.36;
        ProductManager.37 = saveData.37;
        ProductManager.38 = saveData.38;
        ProductManager.39 = saveData.39;
        ProductManager.40 = saveData.40;
        ProductManager.41 = saveData.41;
        ProductManager.42 = saveData.42;
        ProductManager.43 = saveData.43;
        ProductManager.44 = saveData.44;
        ProductManager.45 = saveData.45;
        ProductManager.46 = saveData.46;
        ProductManager.47 = saveData.47;
        ProductManager.48 = saveData.48;
        ProductManager.49 = saveData.49;
        ProductManager.50 = saveData.50;
        ProductManager.51 = saveData.51;
        ProductManager.52 = saveData.52;
        ProductManager.53 = saveData.53;
        ProductManager.54 = saveData.54;
        ProductManager.55 = saveData.55;
        ProductManager.56 = saveData.56;
        ProductManager.57 = saveData.57;
        ProductManager.58 = saveData.58;
        ProductManager.59 = saveData.59;
        ProductManager.60 = saveData.60;
        ProductManager.61 = saveData.61;
        ProductManager.62 = saveData.62;
        ProductManager.63 = saveData.63;
        ProductManager.64 = saveData.64;
        ProductManager.65 = saveData.65;
        ProductManager.66 = saveData.66;
        ProductManager.67 = saveData.67;
        ProductManager.68 = saveData.68;
        ProductManager.69 = saveData.69;
        ProductManager.70 = saveData.70;
        */
    }

    void passiveLoad()
    {
        if (eventOn == true && Story_Fuel2_Complete == false && SpaceshipManager.SScomplete[6] == true)
        {
            Click_Button.sprite = Button_Bomb;
        }

        if (robotLevel >= 1)
        {
            Robot01.color = new Color32(255, 255, 255, 255);
        }
        if (robotLevel >= 2)
        {
            Robot02.color = new Color32(255, 255, 255, 255);
        }
        if (robotLevel >= 3)
        {
            Robot03.color = new Color32(255, 255, 255, 255);
        }
        if (robotLevel >= 4)
        {
            Robot04.color = new Color32(255, 255, 255, 255);
        }
        if (robotLevel >= 5)
        {
            Robot05.color = new Color32(255, 255, 255, 255);
        }
        if (robotLevel >= 6)
        {
            Robot06.color = new Color32(255, 255, 255, 255);
        }
        if (robotLevel >= 7)
        {
            Robot07.color = new Color32(255, 255, 255, 255);
        }
        if (robotLevel >= 8)
        {
            Robot08.color = new Color32(255, 255, 255, 255);
        }
    }

    public void MoneyIncrease()
    {
        money += (long)(moneyIncreaseAmount * FinalGoldBonus * SSclickBonus); // 돈을 '클릭 시 돈 증가량'만큼 증가시킴
        float r1 = Random.Range(-0.4f, 0.4f);
        Vector2 MoneyPosition = new Vector2(r1, -4);
        if (eventOn == false)
        {
            Instantiate(prefabMoney, MoneyPosition, Quaternion.identity);
        }
        else if(eventOn == true)
        {
            EventOn();
        }
        click_gauge = 23;
    }

    public void ScienceIncrease()
    {
        if (robotLevel >= 1)
        {
            science += (long)(scienceIncreaseAmount * FinalScienceBonus * SSclickBonus); // 연구력을 '클릭 시 연구력 증가량'만큼 증가시킴
            Instantiate(prefabScience, panel_robot.transform);
        }

    }

    void EventOn()
    {
        if (Story_Fuel2_Complete == false && MessageManager.etcMessage[6] == true)
        {
            ClickCount_Fuel2++;
            if (ClickCount_Fuel2 >= 50)
            {
                eventOn = false;
                Fuel2Debuff = 1f;
                Story_Fuel2_Complete = true;
                Click_Button.sprite = Button_normal;
            }
        }

        if (Story_Cockpit2_Complete == false && MessageManager.etcMessage[14] == true)
        {
            ClickCount_Cockpit2++;
            if (ClickCount_Cockpit2 >= 100)
            {
                eventOn = false;
                Cockpit2Debuff = 1f;
                Story_Cockpit2_Complete = true;
            }
        }
    }

    IEnumerator FinalBonus()
    {
        while(true)
        {
            FinalGoldBonus = 1 * SpaceshipGoldBonus * AdBonus * CashBonus * ClickBonus * Fuel2Debuff * Engine2Debuff * Cockpit2Debuff;
            FinalScienceBonus = 1 * SpaceshipScienceBonus * AdBonus * CashBonus * ClickBonus * Fuel2Debuff * Engine2Debuff * Cockpit2Debuff;

            yield return new WaitForSeconds(0.2f);
        }
    }

    public void Button_Down()
    {
        if(eventOn == true && Story_Fuel2_Complete == false && MessageManager.etcMessage[6] == true)
        {
            Click_Button.sprite = Button_Bomb_pushed;
        }
        else
        {
            Click_Button.sprite = Button_normal_pushed;
        }
    }

    public void Button_Up()
    {
        if (eventOn == true && Story_Fuel2_Complete == false && MessageManager.etcMessage[6] == true)
        {
            Click_Button.sprite = Button_Bomb;
        }
        else
        {
            Click_Button.sprite = Button_normal;
        }
    }

    IEnumerator MoneyTransform()
    {
        while(true)
        {
            if (money <= 999999999)
            {
                ConvertedMoney = money;
                MoneyUnitSize = "";
            }
            else if (money <= 9999999999)
            {
                ConvertedMoney = money / 1000;
                MoneyUnitSize = " k";
            }
            else if (money <= 99999999999)
            {
                ConvertedMoney = money / 1000;
                MoneyUnitSize = " k";
            }
            else if (money <= 999999999999)
            {
                ConvertedMoney = money / 1000;
                MoneyUnitSize = " k";
            }
            else if (money <= 9999999999999)
            {
                ConvertedMoney = money / 1000000;
                MoneyUnitSize = " m";
            }
            else if (money <= 99999999999999)
            {
                ConvertedMoney = money / 1000000;
                MoneyUnitSize = " m";
            }
            else if (money <= 999999999999999)
            {
                ConvertedMoney = money / 1000000;
                MoneyUnitSize = " m";
            }
            else if (money <= 9999999999999999)
            {
                ConvertedMoney = money / 1000000000;
                MoneyUnitSize = " b";
            }
            else if (money <= 99999999999999999)
            {
                ConvertedMoney = money / 1000000000;
                MoneyUnitSize = " b";
            }
            else if (money <= 999999999999999999)
            {
                ConvertedMoney = money / 1000000000;
                MoneyUnitSize = " b";
            }
            else if (money <= 9223372036854775807)
            {
                ConvertedMoney = money / 1000000000000;
                MoneyUnitSize = " t";
            }

            yield return new WaitForSeconds(0.02f);
        }
    }

    IEnumerator ScienceTransform()
    {
        while (true)
        {
            if (science <= 999999999)
            {
                ConvertedScience = science;
                ScienceUnitSize = "";
            }
            else if (science <= 9999999999)
            {
                ConvertedScience = science / 1000;
                ScienceUnitSize = " k";
            }
            else if (science <= 99999999999)
            {
                ConvertedScience = science / 1000;
                ScienceUnitSize = " k";
            }
            else if (science <= 999999999999)
            {
                ConvertedScience = science / 1000;
                ScienceUnitSize = " k";
            }
            else if (science <= 9999999999999)
            {
                ConvertedScience = science / 1000000;
                ScienceUnitSize = " m";
            }
            else if (science <= 99999999999999)
            {
                ConvertedScience = science / 1000000;
                ScienceUnitSize = " m";
            }
            else if (science <= 999999999999999)
            {
                ConvertedScience = science / 1000000;
                ScienceUnitSize = " m";
            }
            else if (science <= 9999999999999999)
            {
                ConvertedScience = science / 1000000000;
                ScienceUnitSize = " b";
            }
            else if (science <= 99999999999999999)
            {
                ConvertedScience = science / 1000000000;
                ScienceUnitSize = " b";
            }
            else if (science <= 999999999999999999)
            {
                ConvertedScience = science / 1000000000;
                ScienceUnitSize = " b";
            }
            else if (science <= 9223372036854775807)
            {
                ConvertedScience = science / 1000000000000;
                ScienceUnitSize = " t";
            }

            yield return new WaitForSeconds(0.1f);
        }
    }

    static public IEnumerator SSclick() // 클릭 보너스 관련 (우주선 업그레이드)
    {
        if (SStimer <= 0)
        {
            SSclickBonus = 1;
            yield break;
        }

        if (SpaceshipManager.SScomplete[13] == true)
        {
            sSclickIMG.GetComponent<Text>().text = "X 500";
        }
        else if (SpaceshipManager.SScomplete[9] == true)
        {
            sSclickIMG.GetComponent<Text>().text = "X 100";
        }
        else if (SpaceshipManager.SScomplete[5] == true)
        {
            sSclickIMG.GetComponent<Text>().text = "X 50";
        }
        sSclickIMG.SetActive(true);

        while (true)
        {
            yield return new WaitForSeconds(1f);

            SStimer--;
            if (SStimer <= 0)
            {
                sSclickIMG.SetActive(false);
                SSclickBonus = 1;
                yield break;
            }
        }
    }

    IEnumerator ShowInfo()
    {
        while(true)
        {
            if (DisplayedMoney != ConvertedMoney)
            {
                if (DisplayedMoney < ConvertedMoney)
                {
                    long DIF = ConvertedMoney - DisplayedMoney;

                    if (DIF > 11111111111110)
                    {
                        DisplayedMoney += 10000000000000;
                    }
                    if (DIF > 1111111111110)
                    {
                        DisplayedMoney += 1000000000000;
                    }
                    if (DIF > 111111111110)
                    {
                        DisplayedMoney += 100000000000;
                    }
                    if (DIF > 11111111110)
                    {
                        DisplayedMoney += 10000000000;
                    }
                    if (DIF > 1111111110)
                    {
                        DisplayedMoney += 1000000000;
                    }
                    if (DIF > 111111110)
                    {
                        DisplayedMoney += 100000000;
                    }
                    if (DIF > 11111110)
                    {
                        DisplayedMoney += 10000000;
                    }
                    if (DIF > 1111110)
                    {
                        DisplayedMoney += 1000000;
                    }
                    if (DIF > 111110)
                    {
                        DisplayedMoney += 100000;
                    }
                    if (DIF > 11110)
                    {
                        DisplayedMoney += 10000;
                    }
                    if (DIF > 1110)
                    {
                        DisplayedMoney += 1000;
                    }
                    if (DIF > 110)
                    {
                        DisplayedMoney += 100;
                    }
                    if (DIF > 10)
                    {
                        DisplayedMoney += 10;
                    }
                    if (DIF > 0)
                    {
                        DisplayedMoney += 1;
                    }
                }

                else if (DisplayedMoney > ConvertedMoney)
                {
                    long DIF = DisplayedMoney - ConvertedMoney;

                    if (DIF > 11111111111110)
                    {
                        DisplayedMoney -= 10000000000000;
                    }
                    if (DIF > 1111111111110)
                    {
                        DisplayedMoney -= 1000000000000;
                    }
                    if (DIF > 111111111110)
                    {
                        DisplayedMoney -= 100000000000;
                    }
                    if (DIF > 11111111110)
                    {
                        DisplayedMoney -= 10000000000;
                    }
                    if (DIF > 1111111110)
                    {
                        DisplayedMoney -= 1000000000;
                    }
                    if (DIF > 111111110)
                    {
                        DisplayedMoney -= 100000000;
                    }
                    if (DIF > 11111110)
                    {
                        DisplayedMoney -= 10000000;
                    }
                    if (DIF > 1111110)
                    {
                        DisplayedMoney -= 1000000;
                    }
                    if (DIF > 111110)
                    {
                        DisplayedMoney -= 100000;
                    }
                    if (DIF > 11110)
                    {
                        DisplayedMoney -= 10000;
                    }
                    if (DIF > 1110)
                    {
                        DisplayedMoney -= 1000;
                    }
                    if (DIF > 110)
                    {
                        DisplayedMoney -= 100;
                    }
                    if (DIF > 10)
                    {
                        DisplayedMoney -= 10;
                    }
                    if (DIF > 0)
                    {
                        DisplayedMoney -= 1;
                    }
                }
            }

            if (money == 0)
                textMoney.text = "0";
            else
                textMoney.text = DisplayedMoney.ToString("###,###") + MoneyUnitSize;

            if (science == 0)
                textScience.text = "0";
            else
                textScience.text = ConvertedScience.ToString("###,###") + ScienceUnitSize;

            textYears.text = years.ToString("####" + "년");

            yield return new WaitForSeconds(0.02f);
        }
    }

    IEnumerator UpdateRobotPanelText()
    {
        while(true)
        {
            robotTierAndLevel.text = robotLevel + " 단계";
            robotInfo1.text = "클릭 시       획득\n: " + UnitTransform((long)(moneyIncreaseAmount * FinalGoldBonus * SSclickBonus));
            robotInfo2.text = "클릭 시       획득\n: " + UnitTransform((long)(scienceIncreaseAmount * FinalScienceBonus * SSclickBonus));
            robotInfo3.text = UnitTransform(robotLevelUpPrice);

            yield return new WaitForSeconds(0.1f);
        }
    }

    string UnitTransform(long a)
    {
        long b;
        string c = "";
        if (a <= 999999999)
        {
            c = a.ToString("###,###");
        }
        else if (a <= 999999999999)
        {
            b = a / 1000;
            c = b.ToString("###,###") + " k";
        }
        else if (a <= 999999999999999)
        {
            b = a / 1000000;
            c = b.ToString("###,###") + " m";
        }
        else if (a <= 999999999999999999)
        {
            b = a / 1000000000;
            c = b.ToString("###,###") + " b";
        }
        else if (a <= 9223372036854775807)
        {
            b = a / 1000000000000;
            c = b.ToString("###,###") + " t";
        }
        return c;
    }

    IEnumerator RobotGoldUpMec()
    {
        while(true)
        {
            if (robotLevel == 0)
            {
                moneyIncreaseAmount = StandardConst_GoldUp;
            }
            else if (robotLevel >= 1 && robotLevel <= 10)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv1_10);
            }
            else if (robotLevel >= 11 && robotLevel <= 20)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv11_20);
            }
            else if (robotLevel >= 21 && robotLevel <= 30)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv21_30);
            }
            else if (robotLevel >= 31 && robotLevel <= 40)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv31_40);
            }
            else if (robotLevel >= 41 && robotLevel <= 50)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv41_50);
            }
            else if (robotLevel >= 51 && robotLevel <= 60)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv51_60);
            }
            else if (robotLevel >= 61 && robotLevel <= 70)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv61_70);
            }
            else if (robotLevel >= 71 && robotLevel <= 80)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv71_80);
            }
            else if (robotLevel >= 81 && robotLevel <= 90)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv81_90);
            }
            else if (robotLevel >= 91 && robotLevel <= 100)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv91_100);
            }
            else if (robotLevel >= 101 && robotLevel <= 110)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv101_110);
            }
            else if (robotLevel >= 111 && robotLevel <= 120)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv111_120);
            }
            else if (robotLevel >= 121 && robotLevel <= 130)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv121_130);
            }
            else if (robotLevel >= 131 && robotLevel <= 140)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv131_140);
            }
            else if (robotLevel >= 141 && robotLevel <= 150)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv141_150);
            }
            else if (robotLevel >= 151 && robotLevel <= 160)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv151_160);
            }
            else if (robotLevel >= 161 && robotLevel <= 170)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv161_170);
            }
            else if (robotLevel >= 171 && robotLevel <= 180)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv171_180);
            }
            else if (robotLevel >= 181 && robotLevel <= 190)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv181_190);
            }
            else if (robotLevel >= 191 && robotLevel <= 200)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv191_200);
            }
            else if (robotLevel >= 201 && robotLevel <= 210)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv201_210);
            }
            else if (robotLevel >= 211 && robotLevel <= 220)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv211_220);
            }
            else if (robotLevel >= 221 && robotLevel <= 230)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv221_230);
            }
            else if (robotLevel >= 231 && robotLevel <= 240)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv231_240);
            }
            else if (robotLevel >= 241 && robotLevel <= 250)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv241_250);
            }
            else if (robotLevel >= 251 && robotLevel <= 260)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv251_260);
            }
            else if (robotLevel >= 261 && robotLevel <= 270)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv261_270);
            }
            else if (robotLevel >= 271 && robotLevel <= 280)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv271_280);
            }
            else if (robotLevel >= 281 && robotLevel <= 290)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv281_290);
            }
            else if (robotLevel >= 291 && robotLevel <= 300)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv291_300);
            }
            else if (robotLevel >= 301 && robotLevel <= 310)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv301_310);
            }
            else if (robotLevel >= 311 && robotLevel <= 320)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv311_320);
            }
            else if (robotLevel >= 321 && robotLevel <= 330)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv321_330);
            }
            else if (robotLevel >= 331 && robotLevel <= 340)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv331_340);
            }
            else if (robotLevel >= 341 && robotLevel <= 350)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv341_350);
            }
            else if (robotLevel >= 351 && robotLevel <= 360)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv351_360);
            }
            else if (robotLevel >= 361 && robotLevel <= 370)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv361_370);
            }
            else if (robotLevel >= 371 && robotLevel <= 380)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv371_380);
            }
            else if (robotLevel >= 381 && robotLevel <= 390)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv381_390);
            }
            else if (robotLevel >= 391 && robotLevel <= 400)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv391_400);
            }
            else if (robotLevel >= 401 && robotLevel <= 410)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv401_410);
            }
            else if (robotLevel >= 411 && robotLevel <= 420)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv411_420);
            }
            else if (robotLevel >= 421 && robotLevel <= 430)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv421_430);
            }
            else if (robotLevel >= 431 && robotLevel <= 440)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv431_440);
            }
            else if (robotLevel >= 441 && robotLevel <= 450)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv441_450);
            }
            else if (robotLevel >= 451 && robotLevel <= 460)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv451_460);
            }
            else if (robotLevel >= 461 && robotLevel <= 470)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv461_470);
            }
            else if (robotLevel >= 471 && robotLevel <= 480)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv471_480);
            }
            else if (robotLevel >= 481 && robotLevel <= 490)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv481_490);
            }
            else if (robotLevel >= 491 && robotLevel <= 500)
            {
                moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_GoldUp * (double)GoldUp_Lv491_500);
            }
            yield return new WaitForSeconds(0.5f);
        }
    }

    IEnumerator ScienceUpMec()
    {
        while(true)
        {
            if (robotLevel == 0)
            {
                scienceIncreaseAmount = 0;
            }
            else if (robotLevel >= 1 && robotLevel <= 10)
            {
                scienceIncreaseAmount = robotLevel * Science_Lv1_10;
            }
            else if (robotLevel >= 11 && robotLevel <= 20)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv11_20;
            }
            else if (robotLevel >= 21 && robotLevel <= 30)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv21_30;
            }
            else if (robotLevel >= 31 && robotLevel <= 40)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv31_40;
            }
            else if (robotLevel >= 41 && robotLevel <= 50)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv41_50;
            }
            else if (robotLevel >= 51 && robotLevel <= 60)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv51_60;
            }
            else if (robotLevel >= 61 && robotLevel <= 70)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv61_70;
            }
            else if (robotLevel >= 71 && robotLevel <= 80)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv71_80;
            }
            else if (robotLevel >= 81 && robotLevel <= 90)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv81_90;
            }
            else if (robotLevel >= 91 && robotLevel <= 100)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv91_100;
            }
            else if (robotLevel >= 101 && robotLevel <= 110)
            {
                scienceIncreaseAmount = robotLevel * Science_Lv101_110;
            }
            else if (robotLevel >= 111 && robotLevel <= 120)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv111_120;
            }
            else if (robotLevel >= 121 && robotLevel <= 130)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv121_130;
            }
            else if (robotLevel >= 131 && robotLevel <= 140)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv131_140;
            }
            else if (robotLevel >= 141 && robotLevel <= 150)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv141_150;
            }
            else if (robotLevel >= 151 && robotLevel <= 160)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv151_160;
            }
            else if (robotLevel >= 161 && robotLevel <= 170)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv161_170;
            }
            else if (robotLevel >= 171 && robotLevel <= 180)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv171_180;
            }
            else if (robotLevel >= 181 && robotLevel <= 190)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv181_190;
            }
            else if (robotLevel >= 191 && robotLevel <= 200)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv191_200;
            }
            else if (robotLevel >= 201 && robotLevel <= 210)
            {
                scienceIncreaseAmount = robotLevel * Science_Lv201_210;
            }
            else if (robotLevel >= 211 && robotLevel <= 220)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv211_220;
            }
            else if (robotLevel >= 221 && robotLevel <= 230)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv221_230;
            }
            else if (robotLevel >= 231 && robotLevel <= 240)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv231_240;
            }
            else if (robotLevel >= 241 && robotLevel <= 250)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv241_250;
            }
            else if (robotLevel >= 251 && robotLevel <= 260)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv251_260;
            }
            else if (robotLevel >= 261 && robotLevel <= 270)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv261_270;
            }
            else if (robotLevel >= 271 && robotLevel <= 280)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv271_280;
            }
            else if (robotLevel >= 281 && robotLevel <= 290)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv281_290;
            }
            else if (robotLevel >= 291 && robotLevel <= 300)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv291_300;
            }
            else if (robotLevel >= 301 && robotLevel <= 310)
            {
                scienceIncreaseAmount = robotLevel * Science_Lv301_310;
            }
            else if (robotLevel >= 311 && robotLevel <= 320)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv311_320;
            }
            else if (robotLevel >= 321 && robotLevel <= 330)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv321_330;
            }
            else if (robotLevel >= 331 && robotLevel <= 340)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv331_340;
            }
            else if (robotLevel >= 341 && robotLevel <= 350)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv341_350;
            }
            else if (robotLevel >= 351 && robotLevel <= 360)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv351_360;
            }
            else if (robotLevel >= 361 && robotLevel <= 370)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv361_370;
            }
            else if (robotLevel >= 371 && robotLevel <= 380)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv371_380;
            }
            else if (robotLevel >= 381 && robotLevel <= 390)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv381_390;
            }
            else if (robotLevel >= 391 && robotLevel <= 400)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv391_400;
            }
            else if (robotLevel >= 401 && robotLevel <= 410)
            {
                scienceIncreaseAmount = robotLevel * Science_Lv401_410;
            }
            else if (robotLevel >= 411 && robotLevel <= 420)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv411_420;
            }
            else if (robotLevel >= 421 && robotLevel <= 430)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv421_430;
            }
            else if (robotLevel >= 431 && robotLevel <= 440)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv431_440;
            }
            else if (robotLevel >= 441 && robotLevel <= 450)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv441_450;
            }
            else if (robotLevel >= 451 && robotLevel <= 460)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv451_460;
            }
            else if (robotLevel >= 461 && robotLevel <= 470)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv461_470;
            }
            else if (robotLevel >= 471 && robotLevel <= 480)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv471_480;
            }
            else if (robotLevel >= 481 && robotLevel <= 490)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv481_490;
            }
            else if (robotLevel >= 491 && robotLevel <= 500)
            {
                scienceIncreaseAmount = (robotLevel) * Science_Lv491_500;
            }

            yield return new WaitForSeconds(0.5f);
        }
    }

    public void RobotLevelUp()
    {
        if (robotLevel < 500 && money >= robotLevelUpPrice)
        {
            money -= robotLevelUpPrice;
            robotLevel += 1;

            if (robotLevel >= 1 && robotLevel <= 10)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv1_10);
            }
            else if (robotLevel >= 11 && robotLevel <= 20)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv11_20);
            }
            else if (robotLevel >= 21 && robotLevel <= 30)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv21_30);
            }
            else if (robotLevel >= 31 && robotLevel <= 40)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv31_40);
            }
            else if (robotLevel >= 41 && robotLevel <= 50)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv41_50);
            }
            else if (robotLevel >= 51 && robotLevel <= 60)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv51_60);
            }
            else if (robotLevel >= 61 && robotLevel <= 70)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv61_70);
            }
            else if (robotLevel >= 71 && robotLevel <= 80)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv71_80);
            }
            else if (robotLevel >= 81 && robotLevel <= 90)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv81_90);
            }
            else if (robotLevel >= 91 && robotLevel <= 100)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv91_100);
            }
            else if (robotLevel >= 101 && robotLevel <= 110)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv101_110);
            }
            else if (robotLevel >= 111 && robotLevel <= 120)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv111_120);
            }
            else if (robotLevel >= 121 && robotLevel <= 130)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv121_130);
            }
            else if (robotLevel >= 131 && robotLevel <= 140)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv131_140);
            }
            else if (robotLevel >= 141 && robotLevel <= 150)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv141_150);
            }
            else if (robotLevel >= 151 && robotLevel <= 160)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv151_160);
            }
            else if (robotLevel >= 161 && robotLevel <= 170)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv161_170);
            }
            else if (robotLevel >= 171 && robotLevel <= 180)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv171_180);
            }
            else if (robotLevel >= 181 && robotLevel <= 190)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv181_190);
            }
            else if (robotLevel >= 191 && robotLevel <= 200)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv191_200);
            }
            else if (robotLevel >= 201 && robotLevel <= 210)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv201_210);
            }
            else if (robotLevel >= 211 && robotLevel <= 220)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv211_220);
            }
            else if (robotLevel >= 221 && robotLevel <= 230)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv221_230);
            }
            else if (robotLevel >= 231 && robotLevel <= 240)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv231_240);
            }
            else if (robotLevel >= 241 && robotLevel <= 250)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv241_250);
            }
            else if (robotLevel >= 251 && robotLevel <= 260)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv251_260);
            }
            else if (robotLevel >= 261 && robotLevel <= 270)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv261_270);
            }
            else if (robotLevel >= 271 && robotLevel <= 280)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv271_280);
            }
            else if (robotLevel >= 281 && robotLevel <= 290)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv281_290);
            }
            else if (robotLevel >= 291 && robotLevel <= 300)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv291_300);
            }
            else if (robotLevel >= 301 && robotLevel <= 310)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv301_310);
            }
            else if (robotLevel >= 311 && robotLevel <= 320)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv311_320);
            }
            else if (robotLevel >= 321 && robotLevel <= 330)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv321_330);
            }
            else if (robotLevel >= 331 && robotLevel <= 340)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv331_340);
            }
            else if (robotLevel >= 341 && robotLevel <= 350)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv341_350);
            }
            else if (robotLevel >= 351 && robotLevel <= 360)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv351_360);
            }
            else if (robotLevel >= 361 && robotLevel <= 370)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv361_370);
            }
            else if (robotLevel >= 371 && robotLevel <= 380)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv371_380);
            }
            else if (robotLevel >= 381 && robotLevel <= 390)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv381_390);
            }
            else if (robotLevel >= 391 && robotLevel <= 400)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv391_400);
            }
            else if (robotLevel >= 401 && robotLevel <= 410)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv401_410);
            }
            else if (robotLevel >= 411 && robotLevel <= 420)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv411_420);
            }
            else if (robotLevel >= 421 && robotLevel <= 430)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv421_430);
            }
            else if (robotLevel >= 431 && robotLevel <= 440)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv431_440);
            }
            else if (robotLevel >= 441 && robotLevel <= 450)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv441_450);
            }
            else if (robotLevel >= 451 && robotLevel <= 460)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv451_460);
            }
            else if (robotLevel >= 461 && robotLevel <= 470)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv461_470);
            }
            else if (robotLevel >= 471 && robotLevel <= 480)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv471_480);
            }
            else if (robotLevel >= 481 && robotLevel <= 490)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv481_490);
            }
            else if (robotLevel >= 491 && robotLevel <= 500)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_Need * (double)Need_Lv491_500);
            }
        }

        if (robotLevel <= 8)
        {
            if (robotLevel == 1)
            {
                Robot01.color = new Color32(255, 255, 255, 255);
            }
            else if (robotLevel == 2)
            {
                Robot02.color = new Color32(255, 255, 255, 255);
            }
            else if (robotLevel == 3)
            {
                Robot03.color = new Color32(255, 255, 255, 255);
            }
            else if (robotLevel == 4)
            {
                Robot04.color = new Color32(255, 255, 255, 255);
            }
            else if (robotLevel == 5)
            {
                Robot05.color = new Color32(255, 255, 255, 255);
            }
            else if (robotLevel == 6)
            {
                Robot06.color = new Color32(255, 255, 255, 255);
            }
            else if (robotLevel == 7)
            {
                Robot07.color = new Color32(255, 255, 255, 255);
            }
            else if (robotLevel == 8)
            {
                Robot08.color = new Color32(255, 255, 255, 255);
            }
        }
    }

    IEnumerator RobotLevelUpButtonActiveCheck()
    {
        while(true)
        {
            if (robotLevel < 500 && money >= robotLevelUpPrice)
            {
                robotLevelUpButton.interactable = true;
            }
            else
                robotLevelUpButton.interactable = false;

            yield return new WaitForSeconds(0.1f);
        }
    }

    public void StoryON()
    {
        Image img1 = ScR.GetComponent<Image>();
        img1.color = new Color32(255, 255, 255, 1);

        Image img2 = Offer01.GetComponent<Image>();
        img2.color = new Color32(255, 255, 255, 220);

        Image img3 = Offer02.GetComponent<Image>();

        Image img4 = Offer03.GetComponent<Image>();

        img1.raycastTarget = true;
        img2.raycastTarget = true;
        img3.raycastTarget = true;
        img4.raycastTarget = true;
    }

    public void StoryOnToOff()
    {
        Image img1 = ScR.GetComponent<Image>();
        Image img2 = Offer01.GetComponent<Image>();
        Image img3 = Offer02.GetComponent<Image>();
        Image img4 = Offer03.GetComponent<Image>();
        if (img2.color == new Color32(255, 255, 255, 0))
        {
            img1.color = new Color32(255, 255, 255, 1);

            img2.color = new Color32(255, 255, 255, 220);

            img1.raycastTarget = true;
            img2.raycastTarget = true;
            img3.raycastTarget = true;
            img4.raycastTarget = true;

            if(robotLevel >= 150)
            {
                JokeButton.SetActive(true);
            }
        }
        else if (img2.color == new Color32(255, 255, 255, 220))
        {
            img1.color = new Color32(255, 255, 255, 0);

            img2.color = new Color32(255, 255, 255, 0);

            img1.raycastTarget = false;
            img2.raycastTarget = false;
            img3.raycastTarget = false;
            img4.raycastTarget = false;

            if(robotLevel >= 150)
            {
                JokeButton.SetActive(false);
            }
        }

    }

    public void StoryOFF()
    {
        Image img1 = ScR.GetComponent<Image>();
        img1.color = new Color32(255, 255, 255, 0);

        Image img2 = Offer01.GetComponent<Image>();
        img2.color = new Color32(255, 255, 255, 0);

        Image img3 = Offer02.GetComponent<Image>();

        Image img4 = Offer03.GetComponent<Image>();

        img1.raycastTarget = false;
        img2.raycastTarget = false;
        img3.raycastTarget = false;
        img4.raycastTarget = false;
    }

    IEnumerator GoldScienceInfo()
    {
        while(true)
        {
            PerGoldInfo.text = "초당 " + UnitTransform((long)((ProductManager.autoMoney) * FinalGoldBonus)) + " 획득";
            PerScienceInfo.text = "초당 " + UnitTransform((long)((ProductManager.autoScience) * FinalScienceBonus)) + " 획득";
            if (ProductManager.autoMoney == 0)
            {
                PerGoldInfo.text = "초당 0 획득";
            }
            if (ProductManager.autoScience == 0)
            {
                PerScienceInfo.text = "초당 0 획득";
            }
            GoldMultipleInfo.text = "x " + FinalGoldBonus + "배";
            ScienceMultipleInfo.text = "x " + FinalScienceBonus + "배";

            yield return new WaitForSeconds(0.2f);
        }
    }

    IEnumerator AutoMoney()
    {
        while(true)
        {
            money += (long)(((ProductManager.autoMoney) * FinalGoldBonus) / 10);
            yield return new WaitForSeconds(0.1f);
        }
    }

    IEnumerator AutoMoneyDigit()
    {
        while (true)
        {
            money += (long)(((ProductManager.autoMoney) * FinalGoldBonus) % 10);
            yield return new WaitForSeconds(1f);
        }
    }

    IEnumerator AutoScience()
    {
        while (true)
        {
            science += (long)(ProductManager.autoScience * FinalScienceBonus);

            yield return new WaitForSeconds(1.0f);
        }
    }

    public void Noti_R_Off()
    {
        Noti_R.GetComponent<Image>().color = new Color(255, 255, 255, 0);
    }
    public void Noti_P_Off()
    {
        Noti_P.GetComponent<Image>().color = new Color(255, 255, 255, 0);
    }
    public void Noti_T_Off()
    {
        Noti_T.GetComponent<Image>().color = new Color(255, 255, 255, 0);
    }
    public void Noti_O_Off()
    {
        Noti_O.GetComponent<Image>().color = new Color(255, 255, 255, 0);
    }

    IEnumerator ClickGaugeControll() // 클릭게이지 컨트롤
    {
        while(true)
        {
            if (ProductManager.Prod_S03_Level > 0 || ProductManager.Prod_S04_Level > 0)
            {
                break;
            }
            yield return new WaitForSeconds(2f);
        }

        while(true)
        {
            if (click_gauge <= 0)
            {
                ClickBonus = 1f;
            }
            else if (click_gauge > 0)
            {
                if (ProductManager.Prod_S04_Level > 0)
                {
                    ClickBonus = 1.5f;
                }
                else if (ProductManager.Prod_S03_Level > 0)
                {
                    ClickBonus = 1.2f;
                }

                click_gauge--;
            }

            yield return new WaitForSeconds(0.1f);
        }
    }

    public void CreditReviveButton()
    {
        if (eventOn == true && MessageManager.etcMessage[10] == true && Story_Engine2_Complete == false)
        {
            eventOn = false;
            Story_Engine2_Complete = true;
            Engine2_RobotSpeed = 1;
            Engine2Debuff = 1f;
        }
    }
}
