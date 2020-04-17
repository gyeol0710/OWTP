using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
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
    public Text robotLevelUpInfo;
    public Text robotTierUpInfo;
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

    void Start()
    {
        money = 0;
        science = 30;
        years = 1770;
        robotLevel = 0;
        robotTier = 1;
    }

    void Update()
    {
        ShowInfo();
        UpdateRobotPanelText();
        RobotLevelUpButtonActiveCheck();
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
        float r2 = Random.Range(0, 100); // 0이상 100미만의 실수 랜덤 출력 [원래는 rand() 함수를 사용하려고 했으나 표본이 적으면 확률이 극단적이라 게임본질을 헤칠 위험 있음 = 실력겜]
        if (r2 <= robotLevel)
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
        if (robotLevel <= 100)
        {
            robotTierAndLevel.text = "Tier " + robotTier + "   Level " + robotLevel;
            robotInfo1.text = "현재 Touch 골드 획득\n" + moneyIncreaseAmount.ToString("###,###");
            robotInfo2.text = "현재 Touch 지식 획득\n" + scienceIncreaseAmount + " [획득 확률 " + robotLevel * 2 + "%]" + "\n\n";
            robotInfo3.text = "레벨업! 비용 : " + robotLevelUpPrice.ToString("###,###");
        }
    }

    public void RobotLevelUp()
    {
        if (robotLevel < 100)
        {
            if (robotTier == 1)
            {
                if (money >= robotLevelUpPrice)
                {
                    money -= robotLevelUpPrice;
                    robotLevel += 1;
                    moneyIncreaseAmount += robotLevel * 10;
                    robotLevelUpPrice += robotLevel * 30;
                }
            }
            else if (robotTier == 2)
            {
                if (money >= robotLevelUpPrice)
                {
                    money -= robotLevelUpPrice;
                    robotLevel += 1;
                    moneyIncreaseAmount += robotLevel * 2000;
                    robotLevelUpPrice += robotLevel * 10000;
                }
            }
            else
            {
                if (money >= robotLevelUpPrice)
                {
                    money -= robotLevelUpPrice;
                    robotLevel += 1;
                    moneyIncreaseAmount += robotLevel * 40000;
                    robotLevelUpPrice += robotLevel * 200000;
                }
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
        if (robotLevel < 50)
        {
            if (money >= robotLevelUpPrice)
                robotLevelUpButton.interactable = true;
            else
                robotLevelUpButton.interactable = false;
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
        if (img2.color == new Color32(255, 255, 255, 220))
        {

        }
            img1 = ScR.GetComponent<Image>();
        img1.color = new Color32(255, 255, 255, 0);

        img2 = Offer01.GetComponent<Image>();
        img2.color = new Color32(255, 255, 255, 0);

        img3 = Offer02.GetComponent<Image>();

        img4 = Offer03.GetComponent<Image>();

        img1.raycastTarget = false;
        img2.raycastTarget = false;
        img3.raycastTarget = false;
        img4.raycastTarget = false;
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
