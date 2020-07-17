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
    public long DisplayedMoney; // 표시되는 돈
    public long moneyIncreaseAmount; // 클릭 시 돈 증가량
    static public long science; // 연구력
    public long scienceIncreaseAmount; // 클릭 시 연구력 증가량

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

    static public bool gomsg;

    public GameObject Noti_R;
    public GameObject Noti_P;
    public GameObject Noti_T;
    public GameObject Noti_O;

    void Awake()
    {
        /*
        string path = Application.persistentDataPath + "/save.xml";
        if (System.IO.File.Exists(path))
        {
            Load();
        }
        */
    }
    
    void Start()
    {
        // StartCoroutine(save());
        StartCoroutine(AutoMoney());
        StartCoroutine(AutoScience());
        StartCoroutine(RobotGoldUpMec());
        StartCoroutine(ScienceUpMec());
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
        ShowInfo();
        UpdateRobotPanelText();
        RobotLevelUpButtonActiveCheck();
        RobotGoldUpNeedMec();
    }

    private void OnApplicationQuit()
    {
        Save();
    }

    IEnumerator save()
    {
        while(true)
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
        money += moneyIncreaseAmount; // 돈을 '클릭 시 돈 증가량'만큼 증가시킴
        float r1 = Random.Range(-0.4f, 0.4f);
        Vector2 MoneyPosition = new Vector2(r1, -4);
        Instantiate(prefabMoney, MoneyPosition, Quaternion.identity);
    }

    public void ScienceIncrease()
    {
        if(robotLevel >= 1)
        {
            science += scienceIncreaseAmount; // 연구력을 '클릭 시 연구력 증가량'만큼 증가시킴
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(prefabScience, mousePosition, Quaternion.identity);
        }
    }

    void ShowInfo()
    {
        if (DisplayedMoney != money)
        {
            if (DisplayedMoney < money)
            {
                long DIF = money - DisplayedMoney;

                /*
                for(int n=10; n < 0; n--)
                {
                    int val = 1;
                    for(int m = 0; n<=m; m++)
                    {
                        val = val * 10;
                    }
                    if (DIF > val)
                    {
                        DisplayedMoney = DisplayedMoney + val;
                        val = 1;
                    }
                }
                */ //반복문 안먹음 일단 서렌 ㄱ

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

            else if (DisplayedMoney > money)
            {
                long DIF = DisplayedMoney - money;

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
            textMoney.text = DisplayedMoney.ToString("###,###");

        if (science == 0)
            textScience.text = "0";
        else
            textScience.text = science.ToString("###,###");

        textYears.text = years.ToString("####" + "년");
    }

    void UpdateRobotPanelText()
    {
            robotTierAndLevel.text = robotLevel + " 단계";
            robotInfo1.text = "클릭 시       획득\n: " + moneyIncreaseAmount.ToString("###,###");
            robotInfo2.text = "클릭 시       획득\n: " + scienceIncreaseAmount;
            robotInfo3.text = robotLevelUpPrice.ToString("###,###");
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
            yield return new WaitForSeconds(0.1f);
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
            yield return new WaitForSeconds(0.1f);
        }
    }

    void RobotGoldUpNeedMec()
    {
        if (robotTier == 1)
        {
            if (robotLevel == 0)
            {
                robotLevelUpPrice = StandardConst_IND_Need;
            }
            else if (robotLevel >= 1 && robotLevel <= 10)
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

    public void RobotLevelUp()
    {
        if (robotLevel < 100)
        {
            if (robotTier == 1)
            {
                money -= robotLevelUpPrice;
                robotLevel += 1;
            }
        }
    }

    public void RobotTierUp()
    {
        {
            if (money >= robotTierUpPrice)
            {
                money -= robotTierUpPrice;
                robotTier += 1;
                robotLevel = 1;
                scienceIncreaseAmount += 9;
            }
        }
    }

    void RobotLevelUpButtonActiveCheck()
    {
        if (robotLevel < 100 && money >= robotLevelUpPrice)
        {
            robotLevelUpButton.interactable = true;
        }
        else
            robotLevelUpButton.interactable = false;
    }

    void RobotTierUpButtonActiveCheck()
    {
        if (robotLevel == 50)
        {
            if (money >= robotTierUpPrice)
                robotTierUpButton.interactable = true;
            else
                robotTierUpButton.interactable = false;
        }
        else
            robotTierUpButton.interactable = false;
    }
    
    IEnumerable RobotFade()
    {
        yield return null;
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
        }
        else if (img2.color == new Color32(255, 255, 255, 220))
        {
            img1.color = new Color32(255, 255, 255, 0);

            img2.color = new Color32(255, 255, 255, 0);

            img1.raycastTarget = false;
            img2.raycastTarget = false;
            img3.raycastTarget = false;
            img4.raycastTarget = false;
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
            money += (ProductManager.autoMoney)/10;

            yield return new WaitForSeconds(0.1f);
        }
    }

    IEnumerator AutoScience()
    {
        while (true)
        {
            science += (ProductManager.autoScience);

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
