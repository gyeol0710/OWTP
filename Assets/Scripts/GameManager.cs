using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

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

    static public bool gomsg;

    public GameObject Noti_R;
    public GameObject Noti_P;
    public GameObject Noti_T;
    public GameObject Noti_O;

    public Image Click_Button;
    public Sprite Button_normal;
    public Sprite Button_normal_pushed;

    public GameObject panel_robot;
    
    //-----------------------------------------
    static public float SpaceshipGoldBonus;

    static public float AdBonus;
    static public float CashBonus;
    static public float ClickBonus;

    static public float SpaceshipScienceBonus;


    static public int ClickCount_Fuel2;
    static public bool Story_Fuel2_Complete;
    static public float Fuel2Debuff;

    static public float FinalGoldBonus;
    static public float FinalScienceBonus;
    //-----------------------------------------
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


    void Awake()
    {
        /*
        string path = Application.persistentDataPath + "/save.xml";
        if (System.IO.File.Exists(path))
        {
            Load();
        }
        */
        Offer01.SetActive(true);
        SpaceshipGoldBonus = 1.1f;
        AdBonus = 1f;
        CashBonus = 1f;
        ClickBonus = 1f;
        SpaceshipScienceBonus = 1f;
        Fuel2Debuff = 1f;
        FinalGoldBonus = 1f;
        FinalScienceBonus = 1f;
        click_gauge = 0; // 클릭게이지 0으로 초기화
    }

    void Start()
    {
        if (robotLevel == 0)
        {
            robotLevelUpPrice = StandardConst_Need;
        }
        // StartCoroutine(save());
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
        if (ProductManager.Prod_S03_Level > 0 || ProductManager.Prod_S04_Level > 0)
        {
            StartCoroutine(ClickGaugeControll());
        }

        if (RePlay == false)
        {
            money = 0;
            science = 0;
            years = 1770;
            robotLevel = 0;
        }
        RePlay = true;
    }

    void Update()
    {

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
            yield return new WaitForSeconds(0.5f);
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

        string path = Application.persistentDataPath + "/save.xml";
        XmlManager.XmlSave<SaveData>(saveData, path);
    }

    void Load()
    {
        SaveData saveData = new SaveData();

        string path = Application.persistentDataPath + "/save.xml";
        saveData = XmlManager.XmlLoad<SaveData>(path);

        money = saveData.money;
        moneyIncreaseAmount = saveData.moneyIncreaseAmount;
        science = saveData.science;
        scienceIncreaseAmount = saveData.scienceIncreaseAmount;
        years = saveData.years;
        RePlay = saveData.RePlay;
    }

    public void MoneyIncrease()
    {
        money += (long)(moneyIncreaseAmount * FinalGoldBonus); // 돈을 '클릭 시 돈 증가량'만큼 증가시킴
        float r1 = Random.Range(-0.4f, 0.4f);
        Vector2 MoneyPosition = new Vector2(r1, -4);
        Instantiate(prefabMoney, MoneyPosition, Quaternion.identity);
        if (Story_Fuel2_Complete == false && SpaceshipManager.Fuel2_Complete == true)
        {
            ClickCount_Fuel2++;
            if (ClickCount_Fuel2 >= 50)
            {
                Fuel2Debuff = 1f;
                Story_Fuel2_Complete = true;
            }
        }
        click_gauge = 23;
    }

    public void ScienceIncrease()
    {
        if (robotLevel >= 1)
        {
            science += (long)(scienceIncreaseAmount * FinalScienceBonus); // 연구력을 '클릭 시 연구력 증가량'만큼 증가시킴
            Instantiate(prefabScience, panel_robot.transform);
        }

    }

    IEnumerator FinalBonus()
    {
        while(true)
        {
            FinalGoldBonus = 1 * SpaceshipGoldBonus * AdBonus * CashBonus * ClickBonus * Fuel2Debuff;
            FinalScienceBonus = 1 * SpaceshipScienceBonus * ClickBonus;

            yield return new WaitForSeconds(0.5f);
        }
    }

    public void Button_Down()
    {
        Click_Button.sprite = Button_normal_pushed;
    }

    public void Button_Up()
    {
        Click_Button.sprite = Button_normal;
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
            robotInfo1.text = "클릭 시       획득\n: " + UnitTransform((long)(moneyIncreaseAmount * FinalGoldBonus));
            robotInfo2.text = "클릭 시       획득\n: " + UnitTransform((long)(scienceIncreaseAmount * FinalScienceBonus));
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

            JokeButton.SetActive(true);
        }
        else if (img2.color == new Color32(255, 255, 255, 220))
        {
            img1.color = new Color32(255, 255, 255, 0);

            img2.color = new Color32(255, 255, 255, 0);

            img1.raycastTarget = false;
            img2.raycastTarget = false;
            img3.raycastTarget = false;
            img4.raycastTarget = false;

            JokeButton.SetActive(false);

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
}
