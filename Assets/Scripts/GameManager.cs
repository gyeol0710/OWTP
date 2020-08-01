using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    public long StandardConst_IND_GoldUp;
    public double GoldUp_Lv1_10_IND;
    public double GoldUp_Lv11_20_IND;
    public double GoldUp_Lv21_30_IND;
    public double GoldUp_Lv31_40_IND;
    public double GoldUp_Lv41_50_IND;
    public double GoldUp_Lv51_60_IND;
    public double GoldUp_Lv61_70_IND;
    public double GoldUp_Lv71_80_IND;
    public double GoldUp_Lv81_90_IND;
    public double GoldUp_Lv91_100_IND;

    public long Science_Lv1_10_IND;
    public long Science_Lv11_20_IND;
    public long Science_Lv21_30_IND;
    public long Science_Lv31_40_IND;
    public long Science_Lv41_50_IND;
    public long Science_Lv51_60_IND;
    public long Science_Lv61_70_IND;
    public long Science_Lv71_80_IND;
    public long Science_Lv81_90_IND;
    public long Science_Lv91_100_IND;

    public long StandardConst_IND_Need;
    public double Need_Lv1_10_IND;
    public double Need_Lv11_20_IND;
    public double Need_Lv21_30_IND;
    public double Need_Lv31_40_IND;
    public double Need_Lv41_50_IND;
    public double Need_Lv51_60_IND;
    public double Need_Lv61_70_IND;
    public double Need_Lv71_80_IND;
    public double Need_Lv81_90_IND;
    public double Need_Lv91_100_IND;

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
    public long robotTierUpPrice; // 로봇 티어업 비용
    public Text robotTierAndLevel; // 로봇 업그레이드 패널 티어 및 레벨
    public Text robotInfo1; // 로봇 현재 골드 획득 및 지식 획득 정보
    public Text robotInfo2;
    public Text robotInfo3;
    public Button robotLevelUpButton; // 로봇 레벨업 버튼
    public Button robotTierUpButton; // 로봇 티어업 버튼

    static public int years; // 연도
    static public int robotLevel; // 로봇 레벨
    static public int robotTier; // 로봇 티어

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
    static public float AdGoldBonus;
    static public float CashGoldBonus;

    static public float SpaceshipScienceBonus;

    static public int ClickCount_Fuel2;
    static public bool Story_Fuel2_Complete;
    static public float Fuel2GoldDebuff;

    static public float FinalGoldBonus;
    static public float FinalScienceBonus;
    //-----------------------------------------

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
        AdGoldBonus = 1f;
        CashGoldBonus = 1f;
        SpaceshipScienceBonus = 1.1f;
        Fuel2GoldDebuff = 1f;
        FinalGoldBonus = 1f;
        FinalScienceBonus = 1f;
    }

    void Start()
    {
        if (robotLevel == 0)
        {
            robotLevelUpPrice = StandardConst_IND_Need;
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
        if (RePlay == false)
        {
            money = 0;
            science = 0;
            years = 1770;
            robotLevel = 0;
            robotTier = 1;
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
                Fuel2GoldDebuff = 1f;
                Story_Fuel2_Complete = true;
            }
        }
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
            FinalGoldBonus = 1 * SpaceshipGoldBonus * AdGoldBonus * CashGoldBonus * Fuel2GoldDebuff;
            FinalScienceBonus = 1 * SpaceshipScienceBonus;

            yield return new WaitForSeconds(0.5f);
        }
    }

    public void pushButton()
    {
        StartCoroutine(PushButton());
    }

    IEnumerator PushButton()
    {
        Click_Button.sprite = Button_normal_pushed;

        yield return new WaitForSeconds(0.05f);

        Click_Button.sprite = Button_normal;

        yield break;
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
            if (robotTier == 1)
            {
                if (robotLevel == 0)
                {
                    moneyIncreaseAmount = StandardConst_IND_GoldUp;
                }
                else if (robotLevel >= 1 && robotLevel <= 10)
                {
                    moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_IND_GoldUp * (double)GoldUp_Lv1_10_IND);
                }
                else if (robotLevel >= 11 && robotLevel <= 20)
                {
                    moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_IND_GoldUp * (double)GoldUp_Lv11_20_IND);
                }
                else if (robotLevel >= 21 && robotLevel <= 30)
                {
                    moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_IND_GoldUp * (double)GoldUp_Lv21_30_IND);
                }
                else if (robotLevel >= 31 && robotLevel <= 40)
                {
                    moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_IND_GoldUp * (double)GoldUp_Lv31_40_IND);
                }
                else if (robotLevel >= 41 && robotLevel <= 50)
                {
                    moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_IND_GoldUp * (double)GoldUp_Lv41_50_IND);
                }
                else if (robotLevel >= 51 && robotLevel <= 60)
                {
                    moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_IND_GoldUp * (double)GoldUp_Lv51_60_IND);
                }
                else if (robotLevel >= 61 && robotLevel <= 70)
                {
                    moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_IND_GoldUp * (double)GoldUp_Lv61_70_IND);
                }
                else if (robotLevel >= 71 && robotLevel <= 80)
                {
                    moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_IND_GoldUp * (double)GoldUp_Lv71_80_IND);
                }
                else if (robotLevel >= 81 && robotLevel <= 90)
                {
                    moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_IND_GoldUp * (double)GoldUp_Lv81_90_IND);
                }
                else if (robotLevel >= 91 && robotLevel <= 100)
                {
                    moneyIncreaseAmount = (long)((double)robotLevel * StandardConst_IND_GoldUp * (double)GoldUp_Lv91_100_IND);
                }
            }
            yield return new WaitForSeconds(0.2f);
        }
    }

    IEnumerator ScienceUpMec()
    {
        while(true)
        {
            if (robotTier == 1)
            {
                if (robotLevel == 0)
                {
                    scienceIncreaseAmount = 0;
                }
                else if (robotLevel >= 1 && robotLevel <= 10)
                {
                    scienceIncreaseAmount = robotLevel * Science_Lv1_10_IND;
                }
                else if (robotLevel >= 11 && robotLevel < 20)
                {
                    scienceIncreaseAmount = (robotLevel) * Science_Lv11_20_IND;
                }
                else if (robotLevel == 20)
                {
                    scienceIncreaseAmount = robotLevel * Science_Lv11_20_IND;
                }
                else if (robotLevel >= 21 && robotLevel < 30)
                {
                    scienceIncreaseAmount = (robotLevel) * Science_Lv21_30_IND;
                }
                else if (robotLevel == 30)
                {
                    scienceIncreaseAmount = robotLevel * Science_Lv21_30_IND;
                }
                else if (robotLevel >= 31 && robotLevel < 40)
                {
                    scienceIncreaseAmount = (robotLevel) * Science_Lv31_40_IND;
                }
                else if (robotLevel == 40)
                {
                    scienceIncreaseAmount = robotLevel * Science_Lv31_40_IND;
                }
                else if (robotLevel >= 41 && robotLevel < 50)
                {
                    scienceIncreaseAmount = (robotLevel) * Science_Lv41_50_IND;
                }
                else if (robotLevel == 50)
                {
                    scienceIncreaseAmount = robotLevel * Science_Lv41_50_IND;
                }
                else if (robotLevel >= 51 && robotLevel < 60)
                {
                    scienceIncreaseAmount = (robotLevel) * Science_Lv51_60_IND;
                }
                else if (robotLevel == 60)
                {
                    scienceIncreaseAmount = robotLevel * Science_Lv51_60_IND;
                }
                else if (robotLevel >= 61 && robotLevel < 70)
                {
                    scienceIncreaseAmount = (robotLevel) * Science_Lv61_70_IND;
                }
                else if (robotLevel == 70)
                {
                    scienceIncreaseAmount = robotLevel * Science_Lv61_70_IND;
                }
                else if (robotLevel >= 71 && robotLevel < 80)
                {
                    scienceIncreaseAmount = (robotLevel) * Science_Lv71_80_IND;
                }
                else if (robotLevel == 80)
                {
                    scienceIncreaseAmount = robotLevel * Science_Lv71_80_IND;
                }
                else if (robotLevel >= 81 && robotLevel < 90)
                {
                    scienceIncreaseAmount = (robotLevel) * Science_Lv81_90_IND;
                }
                else if (robotLevel == 90)
                {
                    scienceIncreaseAmount = robotLevel * Science_Lv81_90_IND;
                }
                else if (robotLevel >= 91 && robotLevel < 100)
                {
                    scienceIncreaseAmount = (robotLevel) * Science_Lv91_100_IND;
                }
                else if (robotLevel == 100)
                {
                    scienceIncreaseAmount = robotLevel * Science_Lv91_100_IND;
                }
            }
            yield return new WaitForSeconds(0.2f);
        }
    }

    public void RobotLevelUp()
    {
        if (robotLevel < 100 && money >= robotLevelUpPrice)
        {
            money -= robotLevelUpPrice;
            robotLevel += 1;

            if (robotLevel >= 1 && robotLevel <= 10)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_IND_Need * (double)Need_Lv1_10_IND);
            }
            else if (robotLevel >= 11 && robotLevel <= 20)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_IND_Need * (double)Need_Lv11_20_IND);
            }
            else if (robotLevel >= 21 && robotLevel <= 30)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_IND_Need * (double)Need_Lv21_30_IND);
            }
            else if (robotLevel >= 31 && robotLevel <= 40)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_IND_Need * (double)Need_Lv31_40_IND);
            }
            else if (robotLevel >= 41 && robotLevel <= 50)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_IND_Need * (double)Need_Lv41_50_IND);
            }
            else if (robotLevel >= 51 && robotLevel <= 60)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_IND_Need * (double)Need_Lv51_60_IND);
            }
            else if (robotLevel >= 61 && robotLevel <= 70)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_IND_Need * (double)Need_Lv61_70_IND);
            }
            else if (robotLevel >= 71 && robotLevel <= 80)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_IND_Need * (double)Need_Lv71_80_IND);
            }
            else if (robotLevel >= 81 && robotLevel <= 90)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_IND_Need * (double)Need_Lv81_90_IND);
            }
            else if (robotLevel >= 91 && robotLevel <= 100)
            {
                robotLevelUpPrice = (long)((double)robotLevel * StandardConst_IND_Need * (double)Need_Lv91_100_IND);
            }
        }
    }

    IEnumerator RobotLevelUpButtonActiveCheck()
    {
        while(true)
        {
            if (robotLevel < 100 && money >= robotLevelUpPrice)
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
}
